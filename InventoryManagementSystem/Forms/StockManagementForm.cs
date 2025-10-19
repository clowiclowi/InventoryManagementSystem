using InventoryManagement.Services;
using InventoryManagement.Models;
using InventoryManagement.Data;

namespace InventoryManagementSystem
{
    public partial class StockManagementForm : Form
    {
        private readonly StockService _stockService;
        private readonly ProductService _productService;
        private readonly AppDbContext _context;
        private Product? _selectedProduct;

        public StockManagementForm(StockService stockService, ProductService productService)
        {
            InitializeComponent();
            _stockService = stockService;
            _productService = productService;
            _context = new AppDbContext();
            LoadProducts();
            LoadRecentTransactions();
        }

        private async void LoadProducts()
        {
            try
            {
                var products = await _productService.GetAllProductsAsync();
                cmbProduct.DataSource = products;
                cmbProduct.DisplayMember = "Name";
                // Removed ValueMember since we're using SelectedItem directly
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadRecentTransactions()
        {
            try
            {
                var transactions = await _stockService.GetRecentTransactionsAsync(30);
                dgvTransactions.DataSource = transactions.Select(t => new
                {
                    Date = t.TransactionDate.ToString("MM/dd/yyyy HH:mm"),
                    Product = t.Product?.Name ?? "N/A",
                    Type = t.TransactionType,
                    Quantity = t.Quantity,
                    Reason = t.Reason,
                    CreatedBy = t.CreatedBy
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transactions: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem != null)
            {
                try
                {
                    var selectedProduct = (Product)cmbProduct.SelectedItem;
                    _selectedProduct = selectedProduct;
                    if (_selectedProduct != null)
                    {
                        lblCurrentStock.Text = $"Current Stock: {_selectedProduct.CurrentStock}";
                        lblReorderLevel.Text = $"Reorder Level: {_selectedProduct.ReorderLevel}";
                        lblNeedsReorder.Text = _selectedProduct.NeedsReorder() ? "NEEDS REORDER!" : "Stock OK";
                        lblNeedsReorder.ForeColor = _selectedProduct.NeedsReorder() ? 
                            System.Drawing.Color.Red : System.Drawing.Color.Green;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading product details: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnProcessTransaction_Click(object sender, EventArgs e)
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

            try
            {
                var quantity = (int)nudQuantity.Value;
                var reason = txtReason.Text.Trim();
                if (string.IsNullOrWhiteSpace(reason))
                {
                    reason = radioStockIn.Checked ? "Stock In" : "Stock Out";
                }

                if (radioStockIn.Checked)
                {
                    await _stockService.ProcessStockInAsync(_selectedProduct.Id, quantity, reason);
                    MessageBox.Show($"Added {quantity} units to stock.", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (radioStockOut.Checked)
                {
                    if (_selectedProduct.CurrentStock < quantity)
                    {
                        MessageBox.Show($"Insufficient stock. Available: {_selectedProduct.CurrentStock}", 
                            "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    await _stockService.ProcessStockOutAsync(_selectedProduct.Id, quantity, reason);
                    MessageBox.Show($"Removed {quantity} units from stock.", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (radioAdjustment.Checked)
                {
                    await _stockService.ProcessStockAdjustmentAsync(_selectedProduct.Id, quantity, reason);
                    MessageBox.Show($"Adjusted stock to {quantity} units.", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Refresh displays
                LoadRecentTransactions();
                cmbProduct_SelectedIndexChanged(sender, e);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing transaction: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            nudQuantity.Value = 0;
            txtReason.Clear();
            radioStockIn.Checked = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRecentTransactions();
            if (_selectedProduct != null)
            {
                cmbProduct_SelectedIndexChanged(sender, e);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
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

