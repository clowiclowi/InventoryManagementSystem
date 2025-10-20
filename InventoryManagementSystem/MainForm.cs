using InventoryManagement.Services;
using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _context;
        private readonly ProductService _productService;
        private readonly StockService _stockService;
        private readonly SalesService _salesService;
        private readonly ReportService _reportService;
        private readonly SupplierService _supplierService;
        private readonly CurrencyExchangeService _currencyService;
        private bool _sidebarCollapsed = false;

        public MainForm()
        {
            InitializeComponent();
            
            _context = new AppDbContext();
            var productRepo = new Repository<Product>(_context);
            var stockRepo = new Repository<StockTransaction>(_context);
            var saleRepo = new Repository<Sale>(_context);
            var saleItemRepo = new Repository<SaleItem>(_context);
            var supplierRepo = new Repository<Supplier>(_context);
            
            _productService = new ProductService(_context, productRepo);
            _stockService = new StockService(_context, stockRepo);
            _salesService = new SalesService(_context, saleRepo, saleItemRepo, _stockService);
            _reportService = new ReportService(_context);
            _supplierService = new SupplierService(_context, supplierRepo);
            _currencyService = new CurrencyExchangeService();

            LoadDashboard();
        }

        private async void LoadDashboard()
        {
            try
            {
                var totalProducts = await _productService.GetAllProductsAsync();
                var lowStockProducts = await _productService.GetLowStockProductsAsync();
                var totalValue = await _productService.GetTotalInventoryValueAsync();
                var todaySales = await _salesService.GetTotalSalesAsync(DateTime.Today, DateTime.Today);

                lblTotalProducts.Text = totalProducts.Count.ToString();
                lblLowStockCount.Text = lowStockProducts.Count.ToString();
                lblTotalValue.Text = totalValue.ToString("C");
                lblTodaySales.Text = todaySales.ToString("C");

                // Load low stock products
                dgvLowStock.DataSource = lowStockProducts.Select(p => new
                {
                    p.Name,
                    p.SKU,
                    p.CurrentStock,
                    p.ReorderLevel,
                    Category = p.Category?.Name ?? "N/A",
                    Supplier = p.Supplier?.Name ?? "N/A"
                }).ToList();

                // Load recent transactions
                var recentTransactions = await _stockService.GetRecentTransactionsAsync(10);
                dgvRecentTransactions.DataSource = recentTransactions.Select(t => new
                {
                    Date = t.TransactionDate.ToString("MM/dd/yyyy"),
                    Product = t.Product?.Name ?? "N/A",
                    Type = t.TransactionType,
                    Quantity = t.Quantity,
                    Reason = t.Reason
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPage(string title, string subtitle, Control content)
        {
            lblPageTitle.Text = title;
            lblPageSubtitle.Text = subtitle;
            
            // Clear existing content
            panelDataTable.Controls.Clear();
            
            // Add new content
            panelDataTable.Controls.Add(content);
            
            // Update navigation buttons
            UpdateNavigationButtons();
        }

        private void UpdateNavigationButtons()
        {
            // Reset all buttons to default style
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnProducts.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnStock.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnOrders.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnSuppliers.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnReports.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);

            // Highlight current page
            if (lblPageTitle.Text.Contains("Dashboard"))
                btnDashboard.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            else if (lblPageTitle.Text.Contains("Products"))
                btnProducts.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            else if (lblPageTitle.Text.Contains("Stock"))
                btnStock.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            else if (lblPageTitle.Text.Contains("Orders"))
                btnOrders.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            else if (lblPageTitle.Text.Contains("Suppliers"))
                btnSuppliers.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            else if (lblPageTitle.Text.Contains("Reports"))
                btnReports.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
        }

        private void ShowContextDrawer(string title, Control content)
        {
            lblDrawerTitle.Text = title;
            panelDrawerContent.Controls.Clear();
            panelDrawerContent.Controls.Add(content);
            panelContextDrawer.Visible = true;
        }

        private void HideContextDrawer()
        {
            panelContextDrawer.Visible = false;
        }

        private void btnAlerts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Low Stock Alerts:\n\n• Product A: 2 units remaining\n• Product B: 1 unit remaining\n• Product C: 3 units remaining", 
                "Low Stock Alerts", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        // Sidebar Navigation Event Handlers
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowPage("📊 Dashboard", "Overview of your inventory and business metrics", panelDashboard);
            LoadDashboard();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            var form = new ProductCatalogForm(_productService, _currencyService);  // ← ADD , _currencyService
            form.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            var form = new StockManagementForm(_stockService, _productService);
            form.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            var form = new SalesForm(_salesService, _productService);
            form.ShowDialog();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            var form = new SupplierManagementForm(_supplierService);
            form.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var form = new ReportsForm(_reportService);
            form.ShowDialog();
        }



        private void btnCollapseSidebar_Click(object sender, EventArgs e)
        {
            _sidebarCollapsed = !_sidebarCollapsed;
            
            if (_sidebarCollapsed)
            {
                panelSidebar.Width = 60;
                btnCollapseSidebar.Text = "▶";
                
                // Hide text, show only icons
                btnDashboard.Text = "📊";
                btnDashboard.Width = 40;
                btnProducts.Text = "📦";
                btnProducts.Width = 40;
                btnStock.Text = "📊";
                btnStock.Width = 40;
                btnOrders.Text = "💰";
                btnOrders.Width = 40;
                btnSuppliers.Text = "🏭";
                btnSuppliers.Width = 40;
                btnReports.Text = "📈";
                btnReports.Width = 40;
            }
            else
            {
                panelSidebar.Width = 220;
                btnCollapseSidebar.Text = "◀";
                
                // Show full text
                btnDashboard.Text = "📊 Dashboard";
                btnDashboard.Width = 200;
                btnProducts.Text = "📦 Products";
                btnProducts.Width = 200;
                btnStock.Text = "📊 Stock";
                btnStock.Width = 200;
                btnOrders.Text = "💰 Orders";
                btnOrders.Width = 200;
                btnSuppliers.Text = "🏭 Suppliers";
                btnSuppliers.Width = 200;   
                btnReports.Text = "📈 Reports";
                btnReports.Width = 200;
            }
        }

        // Context Drawer Event Handlers
        private void btnCloseDrawer_Click(object sender, EventArgs e)
        {
            HideContextDrawer();
        }

        private void dgvMainData_SelectionChanged(object sender, EventArgs e)
        {
            // Show context drawer when item is selected
            if (dgvMainData.SelectedRows.Count > 0)
            {
                var selectedRow = dgvMainData.SelectedRows[0];
                // Create quick view content based on current page
                // This would be implemented based on the specific data being displayed
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