namespace InventoryManagementSystem
{
    partial class ProductCatalogForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvProducts;
        private Panel panelDetails;
        private Label lblName;
        private TextBox txtName;
        private Label lblSKU;
        private TextBox txtSKU;
        private Label lblPrice;
        private NumericUpDown nudPrice;
        private Label lblCost;
        private NumericUpDown nudCost;
        private Label lblStock;
        private NumericUpDown nudStock;
        private Label lblReorderLevel;
        private NumericUpDown nudReorderLevel;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblSupplier;
        private ComboBox cmbSupplier;
        private Button btnSave;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnAddNew;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblSearch;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelAddProduct;
        private Label lblAddProductTitle;
        private RadioButton rbPhysicalProduct;
        private RadioButton rbPerishableProduct;
        private Label lblProductType;
        private DateTimePicker dtpExpiryDate;
        private Label lblExpiryDate;
        private TextBox txtBarcode;
        private Label lblBarcode;
        private NumericUpDown nudWeight;
        private Label lblWeight;
        private Button btnClearForm;
        private Label lblCurrency;
        private ComboBox cmbCurrency;
        private Label lblConvertedPrice;

        private void InitializeComponent()
        {
            this.dgvProducts = new DataGridView();
            this.panelDetails = new Panel();
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblSKU = new Label();
            this.txtSKU = new TextBox();
            this.lblPrice = new Label();
            this.nudPrice = new NumericUpDown();
            this.lblCost = new Label();
            this.nudCost = new NumericUpDown();
            this.lblStock = new Label();
            this.nudStock = new NumericUpDown();
            this.lblReorderLevel = new Label();
            this.nudReorderLevel = new NumericUpDown();
            this.lblCategory = new Label();
            this.cmbCategory = new ComboBox();
            this.lblSupplier = new Label();
            this.cmbSupplier = new ComboBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.btnDelete = new Button();
            this.btnAddNew = new Button();
            this.txtSearch = new TextBox();
            this.btnSearch = new Button();
            this.lblSearch = new Label();
            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.panelAddProduct = new Panel();
            this.lblAddProductTitle = new Label();
            this.rbPhysicalProduct = new RadioButton();
            this.rbPerishableProduct = new RadioButton();
            this.lblProductType = new Label();
            this.dtpExpiryDate = new DateTimePicker();
            this.lblExpiryDate = new Label();
            this.txtBarcode = new TextBox();
            this.lblBarcode = new Label();
            this.nudWeight = new NumericUpDown();
            this.lblWeight = new Label();
            this.btnClearForm = new Button();
            this.lblCurrency = new Label();
            this.cmbCurrency = new ComboBox();
            this.lblConvertedPrice = new Label();

            this.panelDetails.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.SuspendLayout();

            // ProductCatalogForm - Modern Design
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Text = "Product Catalog Management";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WindowState = FormWindowState.Maximized;

            // Header Panel
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 80;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);

            this.lblTitle.Text = "📦 Product Catalog Management";
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;

            // DataGridView - Modern Dark Theme
            this.dgvProducts.Dock = DockStyle.Left;
            this.dgvProducts.Width = 800;
            this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvProducts.BorderStyle = BorderStyle.None;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvProducts.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvProducts.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvProducts.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.SelectionChanged += new EventHandler(this.dgvProducts_SelectionChanged);

            // Panel Details - Modern Card Design
            this.panelDetails.Dock = DockStyle.Right;
            this.panelDetails.Width = 800;
            this.panelDetails.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelDetails.Padding = new Padding(30);

            // Search controls - Modern styling
            this.lblSearch.Text = "🔍 Search Products:";
            this.lblSearch.Location = new System.Drawing.Point(30, 30);
            this.lblSearch.Size = new System.Drawing.Size(150, 30);
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.White;

            this.txtSearch.Location = new System.Drawing.Point(200, 30);
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = BorderStyle.FixedSingle;

            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(520, 30);
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Cursor = Cursors.Hand;
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);

            // Add Product Panel - Prominent section
            this.panelAddProduct.Controls.Add(this.lblAddProductTitle);
            this.panelAddProduct.Controls.Add(this.lblProductType);
            this.panelAddProduct.Controls.Add(this.rbPhysicalProduct);
            this.panelAddProduct.Controls.Add(this.rbPerishableProduct);
            this.panelAddProduct.Controls.Add(this.lblName);
            this.panelAddProduct.Controls.Add(this.txtName);
            this.panelAddProduct.Controls.Add(this.lblSKU);
            this.panelAddProduct.Controls.Add(this.txtSKU);
            this.panelAddProduct.Controls.Add(this.lblBarcode);
            this.panelAddProduct.Controls.Add(this.txtBarcode);
            this.panelAddProduct.Controls.Add(this.lblWeight);
            this.panelAddProduct.Controls.Add(this.nudWeight);
            this.panelAddProduct.Controls.Add(this.lblExpiryDate);
            this.panelAddProduct.Controls.Add(this.dtpExpiryDate);
            this.panelAddProduct.Controls.Add(this.lblPrice);
            this.panelAddProduct.Controls.Add(this.nudPrice);
            this.panelAddProduct.Controls.Add(this.lblCost);
            this.panelAddProduct.Controls.Add(this.nudCost);
            this.panelAddProduct.Controls.Add(this.lblStock);
            this.panelAddProduct.Controls.Add(this.nudStock);
            this.panelAddProduct.Controls.Add(this.lblReorderLevel);
            this.panelAddProduct.Controls.Add(this.nudReorderLevel);
            this.panelAddProduct.Controls.Add(this.lblCategory);
            this.panelAddProduct.Controls.Add(this.cmbCategory);
            this.panelAddProduct.Controls.Add(this.lblSupplier);
            this.panelAddProduct.Controls.Add(this.cmbSupplier);
            this.panelAddProduct.Controls.Add(this.btnSave);
            this.panelAddProduct.Controls.Add(this.btnCancel);
            this.panelAddProduct.Controls.Add(this.btnDelete);
            this.panelAddProduct.Controls.Add(this.btnAddNew);
            this.panelAddProduct.Controls.Add(this.btnClearForm);
            this.panelAddProduct.Controls.Add(this.lblCurrency);
            this.panelAddProduct.Controls.Add(this.cmbCurrency);
            this.panelAddProduct.Controls.Add(this.lblConvertedPrice);
            this.panelAddProduct.Location = new System.Drawing.Point(30, 80);
            this.panelAddProduct.Size = new System.Drawing.Size(740, 700);
            this.panelAddProduct.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.panelAddProduct.BorderStyle = BorderStyle.None;

            this.lblAddProductTitle.Text = "➕ Add New Product";
            this.lblAddProductTitle.Location = new System.Drawing.Point(20, 20);
            this.lblAddProductTitle.Size = new System.Drawing.Size(300, 40);
            this.lblAddProductTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAddProductTitle.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);

            // Product Type Selection
            this.lblProductType.Text = "Product Type:";
            this.lblProductType.Location = new System.Drawing.Point(20, 70);
            this.lblProductType.Size = new System.Drawing.Size(120, 25);
            this.lblProductType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProductType.ForeColor = System.Drawing.Color.White;

            this.rbPhysicalProduct.Text = "Physical Product";
            this.rbPhysicalProduct.Location = new System.Drawing.Point(150, 70);
            this.rbPhysicalProduct.Size = new System.Drawing.Size(150, 25);
            this.rbPhysicalProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbPhysicalProduct.ForeColor = System.Drawing.Color.White;
            this.rbPhysicalProduct.BackColor = System.Drawing.Color.Transparent;
            this.rbPhysicalProduct.Checked = true;
            this.rbPhysicalProduct.CheckedChanged += new EventHandler(this.rbProductType_CheckedChanged);

            this.rbPerishableProduct.Text = "Perishable Product";
            this.rbPerishableProduct.Location = new System.Drawing.Point(320, 70);
            this.rbPerishableProduct.Size = new System.Drawing.Size(150, 25);
            this.rbPerishableProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbPerishableProduct.ForeColor = System.Drawing.Color.White;
            this.rbPerishableProduct.BackColor = System.Drawing.Color.Transparent;
            this.rbPerishableProduct.CheckedChanged += new EventHandler(this.rbProductType_CheckedChanged);

            // Basic Product Information
            this.lblName.Text = "Product Name:";
            this.lblName.Location = new System.Drawing.Point(20, 110);
            this.lblName.Size = new System.Drawing.Size(120, 25);
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;

            this.txtName.Location = new System.Drawing.Point(150, 110);
            this.txtName.Size = new System.Drawing.Size(300, 30);
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = BorderStyle.FixedSingle;

            this.lblSKU.Text = "SKU:";
            this.lblSKU.Location = new System.Drawing.Point(20, 150);
            this.lblSKU.Size = new System.Drawing.Size(120, 25);
            this.lblSKU.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSKU.ForeColor = System.Drawing.Color.White;

            this.txtSKU.Location = new System.Drawing.Point(150, 150);
            this.txtSKU.Size = new System.Drawing.Size(300, 30);
            this.txtSKU.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSKU.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtSKU.ForeColor = System.Drawing.Color.White;
            this.txtSKU.BorderStyle = BorderStyle.FixedSingle;

            // Physical Product specific fields
            this.lblBarcode.Text = "Barcode:";
            this.lblBarcode.Location = new System.Drawing.Point(20, 190);
            this.lblBarcode.Size = new System.Drawing.Size(120, 25);
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBarcode.ForeColor = System.Drawing.Color.White;

            this.txtBarcode.Location = new System.Drawing.Point(150, 190);
            this.txtBarcode.Size = new System.Drawing.Size(300, 30);
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBarcode.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtBarcode.ForeColor = System.Drawing.Color.White;
            this.txtBarcode.BorderStyle = BorderStyle.FixedSingle;

            this.lblWeight.Text = "Weight (kg):";
            this.lblWeight.Location = new System.Drawing.Point(20, 230);
            this.lblWeight.Size = new System.Drawing.Size(120, 25);
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWeight.ForeColor = System.Drawing.Color.White;

            this.nudWeight.Location = new System.Drawing.Point(150, 230);
            this.nudWeight.Size = new System.Drawing.Size(150, 30);
            this.nudWeight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudWeight.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.nudWeight.ForeColor = System.Drawing.Color.White;
            this.nudWeight.DecimalPlaces = 2;
            this.nudWeight.Maximum = 9999.99m;

            // Perishable Product specific fields
            this.lblExpiryDate.Text = "Expiry Date:";
            this.lblExpiryDate.Location = new System.Drawing.Point(20, 270);
            this.lblExpiryDate.Size = new System.Drawing.Size(120, 25);
            this.lblExpiryDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblExpiryDate.ForeColor = System.Drawing.Color.White;

            this.dtpExpiryDate.Location = new System.Drawing.Point(150, 270);
            this.dtpExpiryDate.Size = new System.Drawing.Size(200, 30);
            this.dtpExpiryDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpExpiryDate.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dtpExpiryDate.ForeColor = System.Drawing.Color.White;
            this.dtpExpiryDate.Format = DateTimePickerFormat.Short;
            this.dtpExpiryDate.Value = DateTime.Today.AddDays(30);

            // Pricing and Inventory
            this.lblPrice.Text = "Unit Price ($):";
            this.lblPrice.Location = new System.Drawing.Point(20, 320);
            this.lblPrice.Size = new System.Drawing.Size(120, 25);
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.White;

            this.nudPrice.Location = new System.Drawing.Point(150, 320);
            this.nudPrice.Size = new System.Drawing.Size(150, 30);
            this.nudPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudPrice.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.nudPrice.ForeColor = System.Drawing.Color.White;
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Maximum = 99999.99m;

            // Currency Selection
            this.lblCurrency.Text = "View in Currency:";
            this.lblCurrency.Location = new System.Drawing.Point(20, 355);
            this.lblCurrency.Size = new System.Drawing.Size(130, 25);
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrency.ForeColor = System.Drawing.Color.White;

            this.cmbCurrency.Location = new System.Drawing.Point(150, 355);
            this.cmbCurrency.Size = new System.Drawing.Size(200, 30);
            this.cmbCurrency.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCurrency.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cmbCurrency.ForeColor = System.Drawing.Color.White;
            this.cmbCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCurrency.SelectedIndexChanged += new EventHandler(this.cmbCurrency_SelectedIndexChanged);

            this.lblConvertedPrice.Text = "";
            this.lblConvertedPrice.Location = new System.Drawing.Point(360, 355);
            this.lblConvertedPrice.Size = new System.Drawing.Size(200, 30);
            this.lblConvertedPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblConvertedPrice.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);

            this.lblCost.Text = "Unit Cost ($):";
            this.lblCost.Location = new System.Drawing.Point(320, 320);
            this.lblCost.Size = new System.Drawing.Size(120, 25);
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCost.ForeColor = System.Drawing.Color.White;

            this.nudCost.Location = new System.Drawing.Point(450, 320);
            this.nudCost.Size = new System.Drawing.Size(150, 30);
            this.nudCost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudCost.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.nudCost.ForeColor = System.Drawing.Color.White;
            this.nudCost.DecimalPlaces = 2;
            this.nudCost.Maximum = 99999.99m;

            this.lblStock.Text = "Current Stock:";
            this.lblStock.Location = new System.Drawing.Point(20, 395);
            this.lblStock.Size = new System.Drawing.Size(120, 25);
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStock.ForeColor = System.Drawing.Color.White;

            this.nudStock.Location = new System.Drawing.Point(150, 395);
            this.nudStock.Size = new System.Drawing.Size(150, 30);
            this.nudStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudStock.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.nudStock.ForeColor = System.Drawing.Color.White;
            this.nudStock.Maximum = 99999;

            this.lblReorderLevel.Text = "Reorder Level:";
            this.lblReorderLevel.Location = new System.Drawing.Point(320, 395);
            this.lblReorderLevel.Size = new System.Drawing.Size(120, 25);
            this.lblReorderLevel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReorderLevel.ForeColor = System.Drawing.Color.White;

            this.nudReorderLevel.Location = new System.Drawing.Point(450, 395);
            this.nudReorderLevel.Size = new System.Drawing.Size(150, 30);
            this.nudReorderLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudReorderLevel.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.nudReorderLevel.ForeColor = System.Drawing.Color.White;
            this.nudReorderLevel.Maximum = 99999;

            // Category and Supplier
            this.lblCategory.Text = "Category:";
            this.lblCategory.Location = new System.Drawing.Point(20, 435);
            this.lblCategory.Size = new System.Drawing.Size(120, 25);
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.White;

            this.cmbCategory.Location = new System.Drawing.Point(150, 435);
            this.cmbCategory.Size = new System.Drawing.Size(300, 30);
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cmbCategory.ForeColor = System.Drawing.Color.White;
            this.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            this.lblSupplier.Text = "Supplier:";
            this.lblSupplier.Location = new System.Drawing.Point(20, 475);
            this.lblSupplier.Size = new System.Drawing.Size(120, 25);
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSupplier.ForeColor = System.Drawing.Color.White;

            this.cmbSupplier.Location = new System.Drawing.Point(150, 475);
            this.cmbSupplier.Size = new System.Drawing.Size(300, 30);
            this.cmbSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSupplier.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cmbSupplier.ForeColor = System.Drawing.Color.White;
            this.cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;

            // Action Buttons - Modern styling
            this.btnSave.Text = "💾 Save Product";
            this.btnSave.Location = new System.Drawing.Point(20, 520);
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Cursor = Cursors.Hand;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            this.btnAddNew.Text = "➕ Add New";
            this.btnAddNew.Location = new System.Drawing.Point(190, 520);
            this.btnAddNew.Size = new System.Drawing.Size(120, 40);
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddNew.FlatStyle = FlatStyle.Flat;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.Cursor = Cursors.Hand;
            this.btnAddNew.Click += new EventHandler(this.btnAddNew_Click);

            this.btnClearForm.Text = "🗑️ Clear Form";
            this.btnClearForm.Location = new System.Drawing.Point(330, 520);
            this.btnClearForm.Size = new System.Drawing.Size(120, 40);
            this.btnClearForm.BackColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnClearForm.ForeColor = System.Drawing.Color.White;
            this.btnClearForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClearForm.FlatStyle = FlatStyle.Flat;
            this.btnClearForm.FlatAppearance.BorderSize = 0;
            this.btnClearForm.Cursor = Cursors.Hand;
            this.btnClearForm.Click += new EventHandler(this.btnClearForm_Click);

            this.btnCancel.Text = "❌ Cancel";
            this.btnCancel.Location = new System.Drawing.Point(470, 520);
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Cursor = Cursors.Hand;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            this.btnDelete.Text = "🗑️ Delete";
            this.btnDelete.Location = new System.Drawing.Point(590, 520);
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 38, 127);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Cursor = Cursors.Hand;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            this.panelDetails.Controls.Add(this.lblSearch);
            this.panelDetails.Controls.Add(this.txtSearch);
            this.panelDetails.Controls.Add(this.btnSearch);
            this.panelDetails.Controls.Add(this.panelAddProduct);

            // Add controls to form
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.dgvProducts);
           

            this.panelDetails.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelAddProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.ResumeLayout(false);
        }
    }
}