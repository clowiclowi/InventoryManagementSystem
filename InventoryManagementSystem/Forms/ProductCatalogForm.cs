using InventoryManagement.Services;
using InventoryManagement.Models;
using InventoryManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem
{
    public partial class ProductCatalogForm : Form
    {
        private readonly ProductService _productService;
        private readonly AppDbContext _context;
        private readonly CurrencyExchangeService _currencyService;
        private Product? _selectedProduct;

        public ProductCatalogForm(ProductService productService, CurrencyExchangeService currencyService)
        {
            InitializeComponent();
            _productService = productService;
            _currencyService = currencyService;
            _context = new AppDbContext();
            LoadProducts();
            LoadCategories();
            LoadSuppliers();
            LoadCurrencies();
        }

        private async void LoadProducts()
        {
            try
            {
                var products = await _productService.GetAllProductsAsync();
                dgvProducts.DataSource = products.Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.SKU,
                    Category = p.Category?.Name ?? "N/A",
                    Supplier = p.Supplier?.Name ?? "N/A",
                    p.UnitPrice,
                    p.UnitCost,
                    p.CurrentStock,
                    p.ReorderLevel,
                    Value = p.CalculateValue(),
                    NeedsReorder = p.NeedsReorder()
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadCategories()
        {
            try
            {
                var categories = await _context.Categories.ToListAsync();
                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadSuppliers()
        {
            try
            {
                var suppliers = await _context.Suppliers.ToListAsync();
                cmbSupplier.DataSource = suppliers;
                cmbSupplier.DisplayMember = "Name";
                cmbSupplier.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                var selectedRow = dgvProducts.SelectedRows[0];
                if (selectedRow.Cells["Id"].Value != null)
                {
                    var productId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    LoadProductDetails(productId);
                }
            }
        }

        private async void LoadProductDetails(int productId)
        {
            try
            {
                _selectedProduct = await _productService.GetProductByIdAsync(productId);
                if (_selectedProduct != null)
                {
                    txtName.Text = _selectedProduct.Name;
                    txtSKU.Text = _selectedProduct.SKU;
                    nudPrice.Value = _selectedProduct.UnitPrice;
                    nudCost.Value = _selectedProduct.UnitCost;
                    nudStock.Value = _selectedProduct.CurrentStock;
                    nudReorderLevel.Value = _selectedProduct.ReorderLevel;
                    cmbCategory.SelectedValue = _selectedProduct.CategoryId;
                    cmbSupplier.SelectedValue = _selectedProduct.SupplierId;

                    // Handle product type specific fields
                    if (_selectedProduct is PhysicalProduct physicalProduct)
                    {
                        rbPhysicalProduct.Checked = true;
                        rbPerishableProduct.Checked = false;
                        txtBarcode.Text = physicalProduct.Barcode ?? "";
                        nudWeight.Value = physicalProduct.WeightKg ?? 0;
                        
                        if (_selectedProduct is PerishableProduct perishableProduct)
                        {
                            rbPerishableProduct.Checked = true;
                            rbPhysicalProduct.Checked = false;
                            dtpExpiryDate.Value = perishableProduct.ExpiryDate ?? DateTime.Today.AddDays(30);
                        }
                    }
                    
                    // Update field visibility
                    rbProductType_CheckedChanged(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product details: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtSKU.Clear();
            txtBarcode.Clear();
            nudPrice.Value = 0;
            nudCost.Value = 0;
            nudStock.Value = 0;
            nudReorderLevel.Value = 0;
            nudWeight.Value = 0;
            dtpExpiryDate.Value = DateTime.Today.AddDays(30);
            cmbCategory.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
            cmbCurrency.SelectedIndex = 0;
            lblConvertedPrice.Text = "";
            rbPhysicalProduct.Checked = true;
            rbPerishableProduct.Checked = false;
            _selectedProduct = null;
            
            // Update field visibility
            rbProductType_CheckedChanged(this, EventArgs.Empty);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Product name is required.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSKU.Text))
                {
                    MessageBox.Show("SKU is required.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbCategory.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbSupplier.SelectedValue == null)
                {
                    MessageBox.Show("Please select a supplier.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Product product;
                
                if (_selectedProduct == null)
                {
                    // Create new product based on selected type
                    if (rbPerishableProduct.Checked)
                    {
                        product = new PerishableProduct
                        {
                            ExpiryDate = dtpExpiryDate.Value
                        };
                    }
                    else
                    {
                        product = new PhysicalProduct();
                    }
                }
                else
                {
                    product = _selectedProduct;
                }

                // Set common properties
                product.Name = txtName.Text.Trim();
                product.SKU = txtSKU.Text.Trim();
                product.UnitPrice = nudPrice.Value;
                product.UnitCost = nudCost.Value;
                product.CurrentStock = (int)nudStock.Value;
                product.ReorderLevel = (int)nudReorderLevel.Value;
                product.CategoryId = (int)cmbCategory.SelectedValue;
                product.SupplierId = (int)cmbSupplier.SelectedValue;

                // Set physical product specific properties
                if (product is PhysicalProduct physicalProduct)
                {
                    physicalProduct.Barcode = string.IsNullOrWhiteSpace(txtBarcode.Text) ? null : txtBarcode.Text.Trim();
                    physicalProduct.WeightKg = nudWeight.Value > 0 ? nudWeight.Value : null;
                }

                // Set perishable product specific properties
                if (product is PerishableProduct perishableProduct)
                {
                    perishableProduct.ExpiryDate = dtpExpiryDate.Value;
                }

                if (_selectedProduct == null)
                {
                    await _productService.AddProductAsync(product);
                    MessageBox.Show("Product added successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await _productService.UpdateProductAsync(product);
                    MessageBox.Show("Product updated successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadProducts();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving product: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedProduct == null)
            {
                MessageBox.Show("Please select a product to delete.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete '{_selectedProduct.Name}'?", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                try
                {
                    await _productService.DeleteProductAsync(_selectedProduct.Id);
                    MessageBox.Show("Product deleted successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting product: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void rbProductType_CheckedChanged(object sender, EventArgs e)
        {
            // Show/hide perishable product specific fields
            bool isPerishable = rbPerishableProduct.Checked;
            lblExpiryDate.Visible = isPerishable;
            dtpExpiryDate.Visible = isPerishable;
            
            // Physical product specific fields are always visible
            lblBarcode.Visible = true;
            txtBarcode.Visible = true;
            lblWeight.Visible = true;
            nudWeight.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                SearchProducts(txtSearch.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private async void SearchProducts(string searchTerm)
        {
            try
            {
                var products = await _productService.SearchProductsAsync(searchTerm);
                dgvProducts.DataSource = products.Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.SKU,
                    Category = p.Category?.Name ?? "N/A",
                    Supplier = p.Supplier?.Name ?? "N/A",
                    p.UnitPrice,
                    p.UnitCost,
                    p.CurrentStock,
                    p.ReorderLevel,
                    Value = p.CalculateValue(),
                    NeedsReorder = p.NeedsReorder()
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching products: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LoadCurrencies()
        {
            try
            {
                await _currencyService.UpdateExchangeRatesAsync();

                var currencies = _currencyService.GetPopularCurrencies();
                cmbCurrency.Items.Clear();
                cmbCurrency.Items.Add("AUD (Default)");

                foreach (var currency in currencies)
                {
                    if (currency != "AUD")
                    {
                        var currencyName = _currencyService.GetCurrencyName(currency);
                        cmbCurrency.Items.Add($"{currency} - {currencyName}");
                    }
                }

                cmbCurrency.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading currencies: {ex.Message}", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UpdatePriceDisplay();
        }

        private async Task UpdatePriceDisplay()
        {
            try
            {
                if (nudPrice.Value == 0 || cmbCurrency.SelectedItem == null)
                {
                    lblConvertedPrice.Text = "";
                    return;
                }

                var selectedCurrency = cmbCurrency.SelectedItem.ToString();

                if (selectedCurrency == "AUD (Default)")
                {
                    lblConvertedPrice.Text = "";
                    return;
                }

                // Extract currency code (first 3 characters)
                selectedCurrency = selectedCurrency!.Substring(0, 3);

                decimal audPrice = nudPrice.Value;
                decimal convertedPrice = await _currencyService.ConvertCurrencyAsync(
                    audPrice, "AUD", selectedCurrency);

                string symbol = _currencyService.GetCurrencySymbol(selectedCurrency);
                lblConvertedPrice.Text = $"≈ {symbol}{convertedPrice:N2} {selectedCurrency}";
            }
            catch (Exception ex)
            {
                lblConvertedPrice.Text = "Conversion error";
                Console.WriteLine($"Currency conversion error: {ex.Message}");
            }
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
