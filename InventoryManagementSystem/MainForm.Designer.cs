namespace InventoryManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        
        // Top Bar Components
        private Panel panelTopBar;
        private Label lblMainMenuTitle;
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
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            panelTopBar = new Panel();
            lblMainMenuTitle = new Label();
            btnAlerts = new Button();
            lblOrganization = new Label();
            panelSidebar = new Panel();
            btnDashboard = new Button();
            btnProducts = new Button();
            btnStock = new Button();
            btnOrders = new Button();
            btnSuppliers = new Button();
            btnReports = new Button();
            btnCollapseSidebar = new Button();
            panelMainContent = new Panel();
            panelContentHeader = new Panel();
            lblPageTitle = new Label();
            lblPageSubtitle = new Label();
            panelDataTable = new Panel();
            dgvMainData = new DataGridView();
            panelDashboard = new Panel();
            lblTotalProductsLabel = new Label();
            lblTotalProducts = new Label();
            lblLowStockLabel = new Label();
            lblLowStockCount = new Label();
            lblTotalValueLabel = new Label();
            lblTotalValue = new Label();
            lblTodaySalesLabel = new Label();
            lblTodaySales = new Label();
            lblLowStockTitle = new Label();
            dgvLowStock = new DataGridView();
            lblRecentTransactionsTitle = new Label();
            dgvRecentTransactions = new DataGridView();
            panelContextDrawer = new Panel();
            btnCloseDrawer = new Button();
            lblDrawerTitle = new Label();
            panelDrawerContent = new Panel();
            panelTopBar.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelMainContent.SuspendLayout();
            panelContentHeader.SuspendLayout();
            panelDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainData).BeginInit();
            panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentTransactions).BeginInit();
            panelContextDrawer.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(30, 41, 59);
            panelTopBar.Controls.Add(lblMainMenuTitle);
            panelTopBar.Controls.Add(btnAlerts);
            panelTopBar.Controls.Add(lblOrganization);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Margin = new Padding(3, 2, 3, 2);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Padding = new Padding(18, 8, 18, 8);
            panelTopBar.Size = new Size(1680, 45);
            panelTopBar.TabIndex = 3;
            // 
            // lblMainMenuTitle
            // 
            lblMainMenuTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMainMenuTitle.ForeColor = Color.White;
            lblMainMenuTitle.Location = new Point(18, 11);
            lblMainMenuTitle.Name = "lblMainMenuTitle";
            lblMainMenuTitle.Size = new Size(88, 22);
            lblMainMenuTitle.TabIndex = 0;
            lblMainMenuTitle.Text = "Menu";
            // 
            // btnAlerts
            // 
            btnAlerts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAlerts.BackColor = Color.FromArgb(239, 68, 68);
            btnAlerts.Cursor = Cursors.Hand;
            btnAlerts.FlatAppearance.BorderSize = 0;
            btnAlerts.FlatStyle = FlatStyle.Flat;
            btnAlerts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAlerts.ForeColor = Color.White;
            btnAlerts.Location = new Point(1312, 8);
            btnAlerts.Margin = new Padding(3, 2, 3, 2);
            btnAlerts.Name = "btnAlerts";
            btnAlerts.Size = new Size(52, 30);
            btnAlerts.TabIndex = 1;
            btnAlerts.Text = "⚠️ 3";
            btnAlerts.UseVisualStyleBackColor = false;
            btnAlerts.Click += btnAlerts_Click;
            // 
            // lblOrganization
            // 
            lblOrganization.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOrganization.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOrganization.ForeColor = Color.White;
            lblOrganization.Location = new Point(1418, 15);
            lblOrganization.Name = "lblOrganization";
            lblOrganization.Size = new Size(105, 22);
            lblOrganization.TabIndex = 2;
            lblOrganization.Text = "🏢 Acme Corp";
            lblOrganization.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 41, 59);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(btnProducts);
            panelSidebar.Controls.Add(btnStock);
            panelSidebar.Controls.Add(btnOrders);
            panelSidebar.Controls.Add(btnSuppliers);
            panelSidebar.Controls.Add(btnReports);
            panelSidebar.Controls.Add(btnCollapseSidebar);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 45);
            panelSidebar.Margin = new Padding(3, 2, 3, 2);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(9, 8, 9, 8);
            panelSidebar.Size = new Size(219, 751);
            panelSidebar.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(59, 130, 246);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(9, 15);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(201, 34);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "📊 Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.MouseCaptureChanged += btnDashboard_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(51, 65, 85);
            btnProducts.Cursor = Cursors.Hand;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 11F);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(9, 56);
            btnProducts.Margin = new Padding(3, 2, 3, 2);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(201, 34);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "📦 Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.FromArgb(51, 65, 85);
            btnStock.Cursor = Cursors.Hand;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI", 11F);
            btnStock.ForeColor = Color.White;
            btnStock.Location = new Point(9, 98);
            btnStock.Margin = new Padding(3, 2, 3, 2);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(201, 34);
            btnStock.TabIndex = 2;
            btnStock.Text = "📊 Stock";
            btnStock.TextAlign = ContentAlignment.MiddleLeft;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.FromArgb(51, 65, 85);
            btnOrders.Cursor = Cursors.Hand;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Segoe UI", 11F);
            btnOrders.ForeColor = Color.White;
            btnOrders.Location = new Point(9, 139);
            btnOrders.Margin = new Padding(3, 2, 3, 2);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(201, 34);
            btnOrders.TabIndex = 3;
            btnOrders.Text = "💰 Orders";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = Color.FromArgb(51, 65, 85);
            btnSuppliers.Cursor = Cursors.Hand;
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Segoe UI", 11F);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(9, 180);
            btnSuppliers.Margin = new Padding(3, 2, 3, 2);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(201, 34);
            btnSuppliers.TabIndex = 4;
            btnSuppliers.Text = "🏭 Suppliers";
            btnSuppliers.TextAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.UseVisualStyleBackColor = false;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(51, 65, 85);
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 11F);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(9, 221);
            btnReports.Margin = new Padding(3, 2, 3, 2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(201, 34);
            btnReports.TabIndex = 5;
            btnReports.Text = "📈 Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnCollapseSidebar
            // 
            btnCollapseSidebar.BackColor = Color.FromArgb(107, 114, 128);
            btnCollapseSidebar.Cursor = Cursors.Hand;
            btnCollapseSidebar.FlatAppearance.BorderSize = 0;
            btnCollapseSidebar.FlatStyle = FlatStyle.Flat;
            btnCollapseSidebar.Font = new Font("Segoe UI", 10F);
            btnCollapseSidebar.ForeColor = Color.White;
            btnCollapseSidebar.Location = new Point(9, 375);
            btnCollapseSidebar.Margin = new Padding(3, 2, 3, 2);
            btnCollapseSidebar.Name = "btnCollapseSidebar";
            btnCollapseSidebar.Size = new Size(35, 22);
            btnCollapseSidebar.TabIndex = 6;
            btnCollapseSidebar.Text = "◀";
            btnCollapseSidebar.UseVisualStyleBackColor = false;
            btnCollapseSidebar.Click += btnCollapseSidebar_Click;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.FromArgb(15, 23, 42);
            panelMainContent.Controls.Add(panelContentHeader);
            panelMainContent.Controls.Add(panelDataTable);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(219, 45);
            panelMainContent.Margin = new Padding(3, 2, 3, 2);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Padding = new Padding(18, 15, 18, 15);
            panelMainContent.Size = new Size(1461, 751);
            panelMainContent.TabIndex = 1;
            // 
            // panelContentHeader
            // 
            panelContentHeader.BackColor = Color.FromArgb(30, 41, 59);
            panelContentHeader.Controls.Add(lblPageTitle);
            panelContentHeader.Controls.Add(lblPageSubtitle);
            panelContentHeader.Dock = DockStyle.Top;
            panelContentHeader.Location = new Point(18, 15);
            panelContentHeader.Margin = new Padding(3, 2, 3, 2);
            panelContentHeader.Name = "panelContentHeader";
            panelContentHeader.Padding = new Padding(18, 15, 18, 15);
            panelContentHeader.Size = new Size(1425, 60);
            panelContentHeader.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            lblPageTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(18, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(350, 40);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "📊 Dashboard";
            lblPageTitle.Click += lblPageTitle_Click;
            // 
            // lblPageSubtitle
            // 
            lblPageSubtitle.Font = new Font("Segoe UI", 12F);
            lblPageSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblPageSubtitle.Location = new Point(18, 40);
            lblPageSubtitle.Name = "lblPageSubtitle";
            lblPageSubtitle.Size = new Size(525, 30);
            lblPageSubtitle.TabIndex = 1;
            lblPageSubtitle.Text = "Overview of your inventory and business metrics";
            // 
            // panelDataTable
            // 
            panelDataTable.BackColor = Color.FromArgb(30, 41, 59);
            panelDataTable.Controls.Add(dgvMainData);
            panelDataTable.Controls.Add(panelDashboard);
            panelDataTable.Dock = DockStyle.Fill;
            panelDataTable.Location = new Point(18, 15);
            panelDataTable.Margin = new Padding(3, 2, 3, 2);
            panelDataTable.Name = "panelDataTable";
            panelDataTable.Padding = new Padding(18, 15, 18, 15);
            panelDataTable.Size = new Size(1425, 721);
            panelDataTable.TabIndex = 1;
            // 
            // dgvMainData
            // 
            dataGridViewCellStyle19.BackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle19.ForeColor = Color.White;
            dgvMainData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dgvMainData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMainData.BackgroundColor = Color.FromArgb(30, 41, 59);
            dgvMainData.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = Color.White;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            dgvMainData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            dgvMainData.Dock = DockStyle.Fill;
            dgvMainData.Font = new Font("Segoe UI", 10F);
            dgvMainData.GridColor = Color.FromArgb(51, 65, 85);
            dgvMainData.Location = new Point(18, 15);
            dgvMainData.Margin = new Padding(3, 2, 3, 2);
            dgvMainData.Name = "dgvMainData";
            dataGridViewCellStyle21.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle21.ForeColor = Color.White;
            dgvMainData.RowsDefaultCellStyle = dataGridViewCellStyle21;
            dgvMainData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMainData.Size = new Size(1389, 691);
            dgvMainData.TabIndex = 0;
            dgvMainData.SelectionChanged += dgvMainData_SelectionChanged;
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.FromArgb(15, 23, 42);
            panelDashboard.Controls.Add(lblTotalProductsLabel);
            panelDashboard.Controls.Add(lblTotalProducts);
            panelDashboard.Controls.Add(lblLowStockLabel);
            panelDashboard.Controls.Add(lblLowStockCount);
            panelDashboard.Controls.Add(lblTotalValueLabel);
            panelDashboard.Controls.Add(lblTotalValue);
            panelDashboard.Controls.Add(lblTodaySalesLabel);
            panelDashboard.Controls.Add(lblTodaySales);
            panelDashboard.Controls.Add(lblLowStockTitle);
            panelDashboard.Controls.Add(dgvLowStock);
            panelDashboard.Controls.Add(lblRecentTransactionsTitle);
            panelDashboard.Controls.Add(dgvRecentTransactions);
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.Location = new Point(18, 15);
            panelDashboard.Margin = new Padding(3, 2, 3, 2);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Padding = new Padding(18, 15, 18, 15);
            panelDashboard.Size = new Size(1389, 691);
            panelDashboard.TabIndex = 1;
            // 
            // lblTotalProductsLabel
            // 
            lblTotalProductsLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalProductsLabel.ForeColor = Color.FromArgb(148, 163, 184);
            lblTotalProductsLabel.Location = new Point(18, 60);
            lblTotalProductsLabel.Name = "lblTotalProductsLabel";
            lblTotalProductsLabel.Size = new Size(175, 22);
            lblTotalProductsLabel.TabIndex = 0;
            lblTotalProductsLabel.Text = "📦 Total Products";
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalProducts.ForeColor = Color.FromArgb(59, 130, 246);
            lblTotalProducts.Location = new Point(18, 100);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(175, 42);
            lblTotalProducts.TabIndex = 1;
            lblTotalProducts.Text = "0";
            // 
            // lblLowStockLabel
            // 
            lblLowStockLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLowStockLabel.ForeColor = Color.FromArgb(148, 163, 184);
            lblLowStockLabel.Location = new Point(210, 60);
            lblLowStockLabel.Name = "lblLowStockLabel";
            lblLowStockLabel.Size = new Size(175, 22);
            lblLowStockLabel.TabIndex = 2;
            lblLowStockLabel.Text = "⚠️ Low Stock Items";
            // 
            // lblLowStockCount
            // 
            lblLowStockCount.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblLowStockCount.ForeColor = Color.FromArgb(239, 68, 68);
            lblLowStockCount.Location = new Point(210, 100);
            lblLowStockCount.Name = "lblLowStockCount";
            lblLowStockCount.Size = new Size(175, 42);
            lblLowStockCount.TabIndex = 3;
            lblLowStockCount.Text = "0";
            // 
            // lblTotalValueLabel
            // 
            lblTotalValueLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalValueLabel.ForeColor = Color.FromArgb(148, 163, 184);
            lblTotalValueLabel.Location = new Point(402, 60);
            lblTotalValueLabel.Name = "lblTotalValueLabel";
            lblTotalValueLabel.Size = new Size(175, 22);
            lblTotalValueLabel.TabIndex = 4;
            lblTotalValueLabel.Text = "💰 Total Inventory Value";
            // 
            // lblTotalValue
            // 
            lblTotalValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalValue.ForeColor = Color.FromArgb(34, 197, 94);
            lblTotalValue.Location = new Point(402, 100);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(175, 42);
            lblTotalValue.TabIndex = 5;
            lblTotalValue.Text = "$0.00";
            // 
            // lblTodaySalesLabel
            // 
            lblTodaySalesLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTodaySalesLabel.ForeColor = Color.FromArgb(148, 163, 184);
            lblTodaySalesLabel.Location = new Point(595, 60);
            lblTodaySalesLabel.Name = "lblTodaySalesLabel";
            lblTodaySalesLabel.Size = new Size(175, 22);
            lblTodaySalesLabel.TabIndex = 6;
            lblTodaySalesLabel.Text = "📈 Today's Sales";
            // 
            // lblTodaySales
            // 
            lblTodaySales.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTodaySales.ForeColor = Color.FromArgb(168, 85, 247);
            lblTodaySales.Location = new Point(595, 100);
            lblTodaySales.Name = "lblTodaySales";
            lblTodaySales.Size = new Size(175, 42);
            lblTodaySales.TabIndex = 7;
            lblTodaySales.Text = "$0.00";
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLowStockTitle.ForeColor = Color.White;
            lblLowStockTitle.Location = new Point(18, 175);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(350, 22);
            lblLowStockTitle.TabIndex = 8;
            lblLowStockTitle.Text = "⚠️ Low Stock Alerts";
            // 
            // dgvLowStock
            // 
            dataGridViewCellStyle22.BackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle22.ForeColor = Color.White;
            dgvLowStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            dgvLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLowStock.BackgroundColor = Color.FromArgb(30, 41, 59);
            dgvLowStock.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle23.ForeColor = Color.White;
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            dgvLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dgvLowStock.Font = new Font("Segoe UI", 10F);
            dgvLowStock.GridColor = Color.FromArgb(51, 65, 85);
            dgvLowStock.Location = new Point(18, 200);
            dgvLowStock.Margin = new Padding(3, 2, 3, 2);
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.ReadOnly = true;
            dataGridViewCellStyle24.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle24.ForeColor = Color.White;
            dgvLowStock.RowsDefaultCellStyle = dataGridViewCellStyle24;
            dgvLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLowStock.Size = new Size(525, 148);
            dgvLowStock.TabIndex = 9;
            // 
            // lblRecentTransactionsTitle
            // 
            lblRecentTransactionsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRecentTransactionsTitle.ForeColor = Color.White;
            lblRecentTransactionsTitle.Location = new Point(560, 175);
            lblRecentTransactionsTitle.Name = "lblRecentTransactionsTitle";
            lblRecentTransactionsTitle.Size = new Size(350, 22);
            lblRecentTransactionsTitle.TabIndex = 10;
            lblRecentTransactionsTitle.Text = "📊 Recent Stock Transactions";
            // 
            // dgvRecentTransactions
            // 
            dataGridViewCellStyle25.BackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle25.ForeColor = Color.White;
            dgvRecentTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            dgvRecentTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentTransactions.BackgroundColor = Color.FromArgb(30, 41, 59);
            dgvRecentTransactions.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle26.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = Color.White;
            dataGridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.True;
            dgvRecentTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            dgvRecentTransactions.Font = new Font("Segoe UI", 10F);
            dgvRecentTransactions.GridColor = Color.FromArgb(51, 65, 85);
            dgvRecentTransactions.Location = new Point(560, 200);
            dgvRecentTransactions.Margin = new Padding(3, 2, 3, 2);
            dgvRecentTransactions.Name = "dgvRecentTransactions";
            dgvRecentTransactions.ReadOnly = true;
            dataGridViewCellStyle27.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle27.ForeColor = Color.White;
            dgvRecentTransactions.RowsDefaultCellStyle = dataGridViewCellStyle27;
            dgvRecentTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentTransactions.Size = new Size(525, 150);
            dgvRecentTransactions.TabIndex = 11;
            // 
            // panelContextDrawer
            // 
            panelContextDrawer.BackColor = Color.FromArgb(51, 65, 85);
            panelContextDrawer.Controls.Add(btnCloseDrawer);
            panelContextDrawer.Controls.Add(lblDrawerTitle);
            panelContextDrawer.Controls.Add(panelDrawerContent);
            panelContextDrawer.Dock = DockStyle.Right;
            panelContextDrawer.Location = new Point(1330, 45);
            panelContextDrawer.Margin = new Padding(3, 2, 3, 2);
            panelContextDrawer.Name = "panelContextDrawer";
            panelContextDrawer.Size = new Size(350, 751);
            panelContextDrawer.TabIndex = 0;
            panelContextDrawer.Visible = false;
            // 
            // btnCloseDrawer
            // 
            btnCloseDrawer.BackColor = Color.FromArgb(239, 68, 68);
            btnCloseDrawer.Cursor = Cursors.Hand;
            btnCloseDrawer.FlatAppearance.BorderSize = 0;
            btnCloseDrawer.FlatStyle = FlatStyle.Flat;
            btnCloseDrawer.Font = new Font("Segoe UI", 10F);
            btnCloseDrawer.ForeColor = Color.White;
            btnCloseDrawer.Location = new Point(315, 8);
            btnCloseDrawer.Margin = new Padding(3, 2, 3, 2);
            btnCloseDrawer.Name = "btnCloseDrawer";
            btnCloseDrawer.Size = new Size(26, 22);
            btnCloseDrawer.TabIndex = 0;
            btnCloseDrawer.Text = "✕";
            btnCloseDrawer.UseVisualStyleBackColor = false;
            btnCloseDrawer.Click += btnCloseDrawer_Click;
            // 
            // lblDrawerTitle
            // 
            lblDrawerTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDrawerTitle.ForeColor = Color.White;
            lblDrawerTitle.Location = new Point(18, 11);
            lblDrawerTitle.Name = "lblDrawerTitle";
            lblDrawerTitle.Size = new Size(175, 19);
            lblDrawerTitle.TabIndex = 1;
            lblDrawerTitle.Text = "Quick View";
            // 
            // panelDrawerContent
            // 
            panelDrawerContent.BackColor = Color.FromArgb(30, 41, 59);
            panelDrawerContent.Location = new Point(18, 38);
            panelDrawerContent.Margin = new Padding(3, 2, 3, 2);
            panelDrawerContent.Name = "panelDrawerContent";
            panelDrawerContent.Size = new Size(315, 450);
            panelDrawerContent.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1680, 796);
            Controls.Add(panelContextDrawer);
            Controls.Add(panelMainContent);
            Controls.Add(panelSidebar);
            Controls.Add(panelTopBar);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1227, 685);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            WindowState = FormWindowState.Maximized;
            panelTopBar.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            panelMainContent.ResumeLayout(false);
            panelContentHeader.ResumeLayout(false);
            panelDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMainData).EndInit();
            panelDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentTransactions).EndInit();
            panelContextDrawer.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}