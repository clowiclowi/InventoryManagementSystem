using InventoryManagement.Services;
using InventoryManagement.Models;
using InventoryManagement.Data;

namespace InventoryManagementSystem
{
    public partial class SalesForm : Form
    {
        private readonly SalesService _salesService;
        private readonly ProductService _productService;
        private readonly AppDbContext _context;
        private List<SaleItem> _currentSaleItems = new List<SaleItem>();
        private Product? _selectedProduct;

        public SalesForm(SalesService salesService, ProductService productService)
        {
            InitializeComponent();
            _salesService = salesService;
            _productService = productService;
            _context = new AppDbContext();
            LoadProducts();
            UpdateTotal();
        }

        private async void LoadProducts()
        {
            try
            {
                var products = await _productService.GetAllProductsAsync();
                cmbProduct.DataSource = products;
                cmbProduct.DisplayMember = "Name";
                cmbProduct.ValueMember = "Id";
                
                // Ensure the ValueMember is properly set
                cmbProduct.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue != null && cmbProduct.SelectedIndex >= 0)
            {
                try
                {
                    // Handle both int and Product object cases
                    int productId;
                    if (cmbProduct.SelectedValue is int id)
                    {
                        productId = id;
                    }
                    else if (cmbProduct.SelectedValue is Product product)
                    {
                        productId = product.Id;
                    }
                    else
                    {
                        return; // Invalid selection
                    }
                    
                    _selectedProduct = await _productService.GetProductByIdAsync(productId);
                    if (_selectedProduct != null)
                    {
                        lblProductPrice.Text = $"Price: ${_selectedProduct.UnitPrice:N2}";
                        lblProductStock.Text = $"Stock: {_selectedProduct.CurrentStock}";
                        nudQuantity.Maximum = _selectedProduct.CurrentStock;
                        nudQuantity.Value = Math.Min(1, _selectedProduct.CurrentStock);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading product details: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (_selectedProduct == null)
            {
                MessageBox.Show("Please select a product.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.", "Invalid Quantity", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_selectedProduct.CurrentStock < nudQuantity.Value)
            {
                MessageBox.Show($"Insufficient stock. Available: {_selectedProduct.CurrentStock}", 
                    "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var quantity = (int)nudQuantity.Value;
            var existingItem = _currentSaleItems.FirstOrDefault(i => i.ProductId == _selectedProduct.Id);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                var saleItem = new SaleItem
                {
                    ProductId = _selectedProduct.Id,
                    Quantity = quantity,
                    UnitPrice = _selectedProduct.UnitPrice
                };
                _currentSaleItems.Add(saleItem);
            }

            RefreshSaleGrid();
            UpdateTotal();
            LoadProducts(); // Refresh to update stock levels
        }

        private void RefreshSaleGrid()
        {
            dgvSaleItems.DataSource = _currentSaleItems.Select(item => new
            {
                Product = _context.Products.Find(item.ProductId)?.Name ?? "N/A",
                Quantity = item.Quantity,
                UnitPrice = item.UnitPrice,
                TotalPrice = item.TotalPrice
            }).ToList();
        }

        private void UpdateTotal()
        {
            var total = _currentSaleItems.Sum(item => item.TotalPrice);
            lblTotal.Text = $"Total: ${total:N2}";
        }

        private async void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if (_currentSaleItems.Count == 0)
            {
                MessageBox.Show("Please add items to the sale.", "No Items", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Customer name is required.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var sale = new Sale
                {
                    CustomerName = txtCustomerName.Text.Trim(),
                    PaymentMethod = cmbPaymentMethod.SelectedItem?.ToString() ?? "Cash",
                    Notes = txtNotes.Text.Trim(),
                    SaleDate = DateTime.Now,
                    TotalAmount = _currentSaleItems.Sum(item => item.TotalPrice)
                };

                await _salesService.ProcessSaleAsync(sale, _currentSaleItems);
                MessageBox.Show($"Sale completed successfully! Total: ${sale.TotalAmount:N2}", 
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ClearSale();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error completing sale: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel this sale?", 
                "Cancel Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                ClearSale();
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvSaleItems.SelectedRows.Count > 0)
            {
                var selectedIndex = dgvSaleItems.SelectedRows[0].Index;
                if (selectedIndex < _currentSaleItems.Count)
                {
                    _currentSaleItems.RemoveAt(selectedIndex);
                    RefreshSaleGrid();
                    UpdateTotal();
                }
            }
        }

        private void ClearSale()
        {
            _currentSaleItems.Clear();
            txtCustomerName.Clear();
            txtNotes.Clear();
            cmbPaymentMethod.SelectedIndex = 0;
            RefreshSaleGrid();
            UpdateTotal();
            LoadProducts(); // Refresh product list
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_currentSaleItems.Count > 0)
            {
                var result = MessageBox.Show("You have items in your sale. Are you sure you want to close?", 
                    "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.No)
                    return;
            }
            this.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

