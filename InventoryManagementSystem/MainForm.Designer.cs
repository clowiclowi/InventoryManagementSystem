namespace InventoryManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        
        // Top Bar Components
        private Panel panelTopBar;
        private TextBox txtGlobalSearch;
        private Button btnQuickAddProduct;
        private Button btnAlerts;
        private Label lblOrganization;
        
        // Left Sidebar Components
        private Panel panelSidebar;
        private Button btnDashboard;
        private Button btnProducts;
        private Button btnStock;
        private Button btnOrders;
        private Button btnSuppliers;
        private Button btnReports;
        private Button btnCollapseSidebar;
        
        // Main Content Area
        private Panel panelMainContent;
        private Panel panelContentHeader;
        private Label lblPageTitle;
        private Label lblPageSubtitle;
        private Panel panelDataTable;
        private DataGridView dgvMainData;
        
        // Right Context Drawer
        private Panel panelContextDrawer;
        private Button btnCloseDrawer;
        private Label lblDrawerTitle;
        private Panel panelDrawerContent;
        
        // Dashboard specific components
        private Panel panelDashboard;
        private Label lblTotalProducts;
        private Label lblLowStockCount;
        private Label lblTotalValue;
        private Label lblTodaySales;
        private Label lblTotalProductsLabel;
        private Label lblLowStockLabel;
        private Label lblTotalValueLabel;
        private Label lblTodaySalesLabel;
        private DataGridView dgvLowStock;
        private DataGridView dgvRecentTransactions;
        private Label lblLowStockTitle;
        private Label lblRecentTransactionsTitle;

        private void InitializeComponent()
        {
            this.panelTopBar = new Panel();
            this.txtGlobalSearch = new TextBox();
            this.btnQuickAddProduct = new Button();
            this.btnAlerts = new Button();
            this.lblOrganization = new Label();
            
            this.panelSidebar = new Panel();
            this.btnDashboard = new Button();
            this.btnProducts = new Button();
            this.btnStock = new Button();
            this.btnOrders = new Button();
            this.btnSuppliers = new Button();
            this.btnReports = new Button();
            this.btnCollapseSidebar = new Button();
            
            this.panelMainContent = new Panel();
            this.panelContentHeader = new Panel();
            this.lblPageTitle = new Label();
            this.lblPageSubtitle = new Label();
            this.panelDataTable = new Panel();
            this.dgvMainData = new DataGridView();
            
            this.panelContextDrawer = new Panel();
            this.btnCloseDrawer = new Button();
            this.lblDrawerTitle = new Label();
            this.panelDrawerContent = new Panel();
            
            this.panelDashboard = new Panel();
            this.lblTotalProducts = new Label();
            this.lblLowStockCount = new Label();
            this.lblTotalValue = new Label();
            this.lblTodaySales = new Label();
            this.lblTotalProductsLabel = new Label();
            this.lblLowStockLabel = new Label();
            this.lblTotalValueLabel = new Label();
            this.lblTodaySalesLabel = new Label();
            this.dgvLowStock = new DataGridView();
            this.dgvRecentTransactions = new DataGridView();
            this.lblLowStockTitle = new Label();
            this.lblRecentTransactionsTitle = new Label();
            
            this.panelTopBar.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.panelContentHeader.SuspendLayout();
            this.panelDataTable.SuspendLayout();
            this.panelContextDrawer.SuspendLayout();
            this.panelDrawerContent.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).BeginInit();
            this.SuspendLayout();

            // MainForm - Modern Enterprise Layout
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Text = "Inventory Management System";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new System.Drawing.Size(1400, 900);

            // Top Bar - Global Navigation
            this.panelTopBar.Controls.Add(this.txtGlobalSearch);
            this.panelTopBar.Controls.Add(this.btnQuickAddProduct);
            this.panelTopBar.Controls.Add(this.btnAlerts);
            this.panelTopBar.Controls.Add(this.lblOrganization);
            this.panelTopBar.Dock = DockStyle.Top;
            this.panelTopBar.Height = 60;
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelTopBar.Padding = new Padding(20, 10, 20, 10);

            // Global Search
            this.txtGlobalSearch.Location = new System.Drawing.Point(20, 15);
            this.txtGlobalSearch.Size = new System.Drawing.Size(400, 30);
            this.txtGlobalSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtGlobalSearch.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtGlobalSearch.ForeColor = System.Drawing.Color.White;
            this.txtGlobalSearch.BorderStyle = BorderStyle.FixedSingle;
            this.txtGlobalSearch.PlaceholderText = "Search products, SKUs, orders...";

            // Quick Add Product
            this.btnQuickAddProduct.Text = "+ Product";
            this.btnQuickAddProduct.Location = new System.Drawing.Point(440, 15);
            this.btnQuickAddProduct.Size = new System.Drawing.Size(100, 30);
            this.btnQuickAddProduct.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnQuickAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnQuickAddProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuickAddProduct.FlatStyle = FlatStyle.Flat;
            this.btnQuickAddProduct.FlatAppearance.BorderSize = 0;
            this.btnQuickAddProduct.Cursor = Cursors.Hand;
            this.btnQuickAddProduct.Click += new EventHandler(this.btnQuickAddProduct_Click);

            // Alerts
            this.btnAlerts.Text = "⚠️ 3";
            this.btnAlerts.Location = new System.Drawing.Point(1500, 15);
            this.btnAlerts.Size = new System.Drawing.Size(60, 30);
            this.btnAlerts.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnAlerts.ForeColor = System.Drawing.Color.White;
            this.btnAlerts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAlerts.FlatStyle = FlatStyle.Flat;
            this.btnAlerts.FlatAppearance.BorderSize = 0;
            this.btnAlerts.Cursor = Cursors.Hand;
            this.btnAlerts.Click += new EventHandler(this.btnAlerts_Click);

            // Organization
            this.lblOrganization.Text = "🏢 Acme Corp";
            this.lblOrganization.Location = new System.Drawing.Point(1620, 15);
            this.lblOrganization.Size = new System.Drawing.Size(120, 30);
            this.lblOrganization.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrganization.ForeColor = System.Drawing.Color.White;
            this.lblOrganization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Left Sidebar - Navigation Menu
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.btnProducts);
            this.panelSidebar.Controls.Add(this.btnStock);
            this.panelSidebar.Controls.Add(this.btnOrders);
            this.panelSidebar.Controls.Add(this.btnSuppliers);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnCollapseSidebar);
            this.panelSidebar.Dock = DockStyle.Left;
            this.panelSidebar.Width = 250;
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelSidebar.Padding = new Padding(10);

            // Navigation Buttons
            this.btnDashboard.Text = "📊 Dashboard";
            this.btnDashboard.Location = new System.Drawing.Point(10, 20);
            this.btnDashboard.Size = new System.Drawing.Size(230, 45);
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.FlatStyle = FlatStyle.Flat;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.Cursor = Cursors.Hand;
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Click += new EventHandler(this.btnDashboard_Click);

            this.btnProducts.Text = "📦 Products";
            this.btnProducts.Location = new System.Drawing.Point(10, 75);
            this.btnProducts.Size = new System.Drawing.Size(230, 45);
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnProducts.FlatStyle = FlatStyle.Flat;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.Cursor = Cursors.Hand;
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Click += new EventHandler(this.btnProducts_Click);

            this.btnStock.Text = "📊 Stock";
            this.btnStock.Location = new System.Drawing.Point(10, 130);
            this.btnStock.Size = new System.Drawing.Size(230, 45);
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnStock.FlatStyle = FlatStyle.Flat;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.Cursor = Cursors.Hand;
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Click += new EventHandler(this.btnStock_Click);

            this.btnOrders.Text = "💰 Orders";
            this.btnOrders.Location = new System.Drawing.Point(10, 185);
            this.btnOrders.Size = new System.Drawing.Size(230, 45);
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnOrders.FlatStyle = FlatStyle.Flat;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.Cursor = Cursors.Hand;
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Click += new EventHandler(this.btnOrders_Click);

            this.btnSuppliers.Text = "🏭 Suppliers";
            this.btnSuppliers.Location = new System.Drawing.Point(10, 240);
            this.btnSuppliers.Size = new System.Drawing.Size(230, 45);
            this.btnSuppliers.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSuppliers.FlatStyle = FlatStyle.Flat;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.Cursor = Cursors.Hand;
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.Click += new EventHandler(this.btnSuppliers_Click);

            this.btnReports.Text = "📈 Reports";
            this.btnReports.Location = new System.Drawing.Point(10, 295);
            this.btnReports.Size = new System.Drawing.Size(230, 45);
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnReports.FlatStyle = FlatStyle.Flat;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.Cursor = Cursors.Hand;
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Click += new EventHandler(this.btnReports_Click);

            // Collapse Sidebar Button
            this.btnCollapseSidebar.Text = "◀";
            this.btnCollapseSidebar.Location = new System.Drawing.Point(10, 500);
            this.btnCollapseSidebar.Size = new System.Drawing.Size(40, 30);
            this.btnCollapseSidebar.BackColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnCollapseSidebar.ForeColor = System.Drawing.Color.White;
            this.btnCollapseSidebar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCollapseSidebar.FlatStyle = FlatStyle.Flat;
            this.btnCollapseSidebar.FlatAppearance.BorderSize = 0;
            this.btnCollapseSidebar.Cursor = Cursors.Hand;
            this.btnCollapseSidebar.Click += new EventHandler(this.btnCollapseSidebar_Click);

            // Main Content Area
            this.panelMainContent.Controls.Add(this.panelContentHeader);
            this.panelMainContent.Controls.Add(this.panelDataTable);
            this.panelMainContent.Dock = DockStyle.Fill;
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelMainContent.Padding = new Padding(20);

            // Content Header
            this.panelContentHeader.Controls.Add(this.lblPageTitle);
            this.panelContentHeader.Controls.Add(this.lblPageSubtitle);
            this.panelContentHeader.Dock = DockStyle.Top;
            this.panelContentHeader.Height = 80;
            this.panelContentHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelContentHeader.Padding = new Padding(20);

            this.lblPageTitle.Text = "📊 Dashboard";
            this.lblPageTitle.Location = new System.Drawing.Point(20, 15);
            this.lblPageTitle.Size = new System.Drawing.Size(400, 35);
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;

            this.lblPageSubtitle.Text = "Overview of your inventory and business metrics";
            this.lblPageSubtitle.Location = new System.Drawing.Point(20, 50);
            this.lblPageSubtitle.Size = new System.Drawing.Size(600, 25);
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);

            // Data Table Panel
            this.panelDataTable.Controls.Add(this.dgvMainData);
            this.panelDataTable.Dock = DockStyle.Fill;
            this.panelDataTable.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelDataTable.Padding = new Padding(20);

            // Main Data Grid
            this.dgvMainData.Dock = DockStyle.Fill;
            this.dgvMainData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMainData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainData.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvMainData.BorderStyle = BorderStyle.None;
            this.dgvMainData.GridColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvMainData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvMainData.ForeColor = System.Drawing.Color.White;
            this.dgvMainData.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvMainData.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMainData.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvMainData.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvMainData.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMainData.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvMainData.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMainData.SelectionChanged += new EventHandler(this.dgvMainData_SelectionChanged);

            // Right Context Drawer
            this.panelContextDrawer.Controls.Add(this.btnCloseDrawer);
            this.panelContextDrawer.Controls.Add(this.lblDrawerTitle);
            this.panelContextDrawer.Controls.Add(this.panelDrawerContent);
            this.panelContextDrawer.Dock = DockStyle.Right;
            this.panelContextDrawer.Width = 400;
            this.panelContextDrawer.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.panelContextDrawer.Visible = false;

            this.btnCloseDrawer.Text = "✕";
            this.btnCloseDrawer.Location = new System.Drawing.Point(360, 10);
            this.btnCloseDrawer.Size = new System.Drawing.Size(30, 30);
            this.btnCloseDrawer.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnCloseDrawer.ForeColor = System.Drawing.Color.White;
            this.btnCloseDrawer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCloseDrawer.FlatStyle = FlatStyle.Flat;
            this.btnCloseDrawer.FlatAppearance.BorderSize = 0;
            this.btnCloseDrawer.Cursor = Cursors.Hand;
            this.btnCloseDrawer.Click += new EventHandler(this.btnCloseDrawer_Click);

            this.lblDrawerTitle.Text = "Quick View";
            this.lblDrawerTitle.Location = new System.Drawing.Point(20, 15);
            this.lblDrawerTitle.Size = new System.Drawing.Size(200, 25);
            this.lblDrawerTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDrawerTitle.ForeColor = System.Drawing.Color.White;

            this.panelDrawerContent.Location = new System.Drawing.Point(20, 50);
            this.panelDrawerContent.Size = new System.Drawing.Size(360, 600);
            this.panelDrawerContent.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);

            // Dashboard Panel (initially visible)
            this.panelDashboard.Controls.Add(this.lblTotalProductsLabel);
            this.panelDashboard.Controls.Add(this.lblTotalProducts);
            this.panelDashboard.Controls.Add(this.lblLowStockLabel);
            this.panelDashboard.Controls.Add(this.lblLowStockCount);
            this.panelDashboard.Controls.Add(this.lblTotalValueLabel);
            this.panelDashboard.Controls.Add(this.lblTotalValue);
            this.panelDashboard.Controls.Add(this.lblTodaySalesLabel);
            this.panelDashboard.Controls.Add(this.lblTodaySales);
            this.panelDashboard.Controls.Add(this.lblLowStockTitle);
            this.panelDashboard.Controls.Add(this.dgvLowStock);
            this.panelDashboard.Controls.Add(this.lblRecentTransactionsTitle);
            this.panelDashboard.Controls.Add(this.dgvRecentTransactions);
            this.panelDashboard.Dock = DockStyle.Fill;
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelDashboard.Padding = new Padding(20);

            // Dashboard Stats Cards
            this.lblTotalProductsLabel.Text = "📦 Total Products";
            this.lblTotalProductsLabel.Location = new System.Drawing.Point(20, 20);
            this.lblTotalProductsLabel.Size = new System.Drawing.Size(200, 30);
            this.lblTotalProductsLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalProductsLabel.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);

            this.lblTotalProducts.Text = "0";
            this.lblTotalProducts.Location = new System.Drawing.Point(20, 50);
            this.lblTotalProducts.Size = new System.Drawing.Size(200, 50);
            this.lblTotalProducts.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalProducts.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);

            this.lblLowStockLabel.Text = "⚠️ Low Stock Items";
            this.lblLowStockLabel.Location = new System.Drawing.Point(240, 20);
            this.lblLowStockLabel.Size = new System.Drawing.Size(200, 30);
            this.lblLowStockLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLowStockLabel.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);

            this.lblLowStockCount.Text = "0";
            this.lblLowStockCount.Location = new System.Drawing.Point(240, 50);
            this.lblLowStockCount.Size = new System.Drawing.Size(200, 50);
            this.lblLowStockCount.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblLowStockCount.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);

            this.lblTotalValueLabel.Text = "💰 Total Inventory Value";
            this.lblTotalValueLabel.Location = new System.Drawing.Point(460, 20);
            this.lblTotalValueLabel.Size = new System.Drawing.Size(200, 30);
            this.lblTotalValueLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalValueLabel.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);

            this.lblTotalValue.Text = "$0.00";
            this.lblTotalValue.Location = new System.Drawing.Point(460, 50);
            this.lblTotalValue.Size = new System.Drawing.Size(200, 50);
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);

            this.lblTodaySalesLabel.Text = "📈 Today's Sales";
            this.lblTodaySalesLabel.Location = new System.Drawing.Point(680, 20);
            this.lblTodaySalesLabel.Size = new System.Drawing.Size(200, 30);
            this.lblTodaySalesLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTodaySalesLabel.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);

            this.lblTodaySales.Text = "$0.00";
            this.lblTodaySales.Location = new System.Drawing.Point(680, 50);
            this.lblTodaySales.Size = new System.Drawing.Size(200, 50);
            this.lblTodaySales.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTodaySales.ForeColor = System.Drawing.Color.FromArgb(168, 85, 247);

            // Low Stock Table
            this.lblLowStockTitle.Text = "⚠️ Low Stock Alerts";
            this.lblLowStockTitle.Location = new System.Drawing.Point(20, 120);
            this.lblLowStockTitle.Size = new System.Drawing.Size(400, 30);
            this.lblLowStockTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLowStockTitle.ForeColor = System.Drawing.Color.White;

            this.dgvLowStock.Location = new System.Drawing.Point(20, 150);
            this.dgvLowStock.Size = new System.Drawing.Size(600, 200);
            this.dgvLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLowStock.ReadOnly = true;
            this.dgvLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvLowStock.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvLowStock.BorderStyle = BorderStyle.None;
            this.dgvLowStock.GridColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvLowStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvLowStock.ForeColor = System.Drawing.Color.White;
            this.dgvLowStock.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvLowStock.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLowStock.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvLowStock.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvLowStock.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLowStock.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvLowStock.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            // Recent Transactions Table
            this.lblRecentTransactionsTitle.Text = "📊 Recent Stock Transactions";
            this.lblRecentTransactionsTitle.Location = new System.Drawing.Point(640, 120);
            this.lblRecentTransactionsTitle.Size = new System.Drawing.Size(400, 30);
            this.lblRecentTransactionsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRecentTransactionsTitle.ForeColor = System.Drawing.Color.White;

            this.dgvRecentTransactions.Location = new System.Drawing.Point(640, 150);
            this.dgvRecentTransactions.Size = new System.Drawing.Size(600, 200);
            this.dgvRecentTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentTransactions.ReadOnly = true;
            this.dgvRecentTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentTransactions.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvRecentTransactions.BorderStyle = BorderStyle.None;
            this.dgvRecentTransactions.GridColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvRecentTransactions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvRecentTransactions.ForeColor = System.Drawing.Color.White;
            this.dgvRecentTransactions.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvRecentTransactions.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRecentTransactions.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvRecentTransactions.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvRecentTransactions.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRecentTransactions.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvRecentTransactions.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            // Add controls to form
            this.Controls.Add(this.panelContextDrawer);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelTopBar);

            // Initially show dashboard
            this.panelDataTable.Controls.Add(this.panelDashboard);

            this.panelTopBar.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelMainContent.ResumeLayout(false);
            this.panelContentHeader.ResumeLayout(false);
            this.panelDataTable.ResumeLayout(false);
            this.panelContextDrawer.ResumeLayout(false);
            this.panelDrawerContent.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).EndInit();
            this.ResumeLayout(false);
        }
    }
}