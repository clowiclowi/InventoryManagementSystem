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
        // private Button btnAddNew;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvProducts = new DataGridView();
            panelDetails = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panelAddProduct = new Panel();
            lblAddProductTitle = new Label();
            lblProductType = new Label();
            rbPhysicalProduct = new RadioButton();
            rbPerishableProduct = new RadioButton();
            lblName = new Label();
            txtName = new TextBox();
            lblSKU = new Label();
            txtSKU = new TextBox();
            lblBarcode = new Label();
            txtBarcode = new TextBox();
            lblWeight = new Label();
            nudWeight = new NumericUpDown();
            lblExpiryDate = new Label();
            dtpExpiryDate = new DateTimePicker();
            lblPrice = new Label();
            nudPrice = new NumericUpDown();
            lblCost = new Label();
            nudCost = new NumericUpDown();
            lblStock = new Label();
            nudStock = new NumericUpDown();
            lblReorderLevel = new Label();
            nudReorderLevel = new NumericUpDown();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblSupplier = new Label();
            cmbSupplier = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            //btnAddNew = new Button();
            btnClearForm = new Button();
            lblCurrency = new Label();
            cmbCurrency = new ComboBox();
            lblConvertedPrice = new Label();
            panelHeader = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panelDetails.SuspendLayout();
            panelAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudReorderLevel).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.FromArgb(30, 41, 59);
            dgvProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.Dock = DockStyle.Left;
            dgvProducts.Font = new Font("Segoe UI", 10F);
            dgvProducts.GridColor = Color.FromArgb(51, 65, 85);
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.Margin = new Padding(3, 2, 3, 2);
            dgvProducts.Name = "dgvProducts";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(700, 675);
            dgvProducts.TabIndex = 2;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // panelDetails
            // 
            panelDetails.BackColor = Color.FromArgb(30, 41, 59);
            panelDetails.Controls.Add(lblSearch);
            panelDetails.Controls.Add(txtSearch);
            panelDetails.Controls.Add(btnSearch);
            panelDetails.Controls.Add(panelAddProduct);
            panelDetails.Dock = DockStyle.Right;
            panelDetails.Location = new Point(700, 0);
            panelDetails.Margin = new Padding(3, 2, 3, 2);
            panelDetails.Name = "panelDetails";
            panelDetails.Padding = new Padding(26, 22, 26, 22);
            panelDetails.Size = new Size(700, 675);
            panelDetails.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(26, 22);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(131, 22);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "🔍 Search Products:";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(51, 65, 85);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(175, 22);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(263, 25);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(59, 130, 246);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(455, 22);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 25);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panelAddProduct
            // 
            panelAddProduct.BackColor = Color.FromArgb(51, 65, 85);
            panelAddProduct.Controls.Add(lblAddProductTitle);
            panelAddProduct.Controls.Add(lblProductType);
            panelAddProduct.Controls.Add(rbPhysicalProduct);
            panelAddProduct.Controls.Add(rbPerishableProduct);
            panelAddProduct.Controls.Add(lblName);
            panelAddProduct.Controls.Add(txtName);
            panelAddProduct.Controls.Add(lblSKU);
            panelAddProduct.Controls.Add(txtSKU);
            panelAddProduct.Controls.Add(lblBarcode);
            panelAddProduct.Controls.Add(txtBarcode);
            panelAddProduct.Controls.Add(lblWeight);
            panelAddProduct.Controls.Add(nudWeight);
            panelAddProduct.Controls.Add(lblExpiryDate);
            panelAddProduct.Controls.Add(dtpExpiryDate);
            panelAddProduct.Controls.Add(lblPrice);
            panelAddProduct.Controls.Add(nudPrice);
            panelAddProduct.Controls.Add(lblCost);
            panelAddProduct.Controls.Add(nudCost);
            panelAddProduct.Controls.Add(lblStock);
            panelAddProduct.Controls.Add(nudStock);
            panelAddProduct.Controls.Add(lblReorderLevel);
            panelAddProduct.Controls.Add(nudReorderLevel);
            panelAddProduct.Controls.Add(lblCategory);
            panelAddProduct.Controls.Add(cmbCategory);
            panelAddProduct.Controls.Add(lblSupplier);
            panelAddProduct.Controls.Add(cmbSupplier);
            panelAddProduct.Controls.Add(btnSave);
            panelAddProduct.Controls.Add(btnCancel);
            panelAddProduct.Controls.Add(btnDelete);
            //panelAddProduct.Controls.Add(btnAddNew);
            panelAddProduct.Controls.Add(btnClearForm);
            panelAddProduct.Controls.Add(lblCurrency);
            panelAddProduct.Controls.Add(cmbCurrency);
            panelAddProduct.Controls.Add(lblConvertedPrice);
            panelAddProduct.Location = new Point(26, 60);
            panelAddProduct.Margin = new Padding(3, 2, 3, 2);
            panelAddProduct.Name = "panelAddProduct";
            panelAddProduct.Size = new Size(648, 525);
            panelAddProduct.TabIndex = 3;
            // 
            // lblAddProductTitle
            // 
            lblAddProductTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAddProductTitle.ForeColor = Color.FromArgb(34, 197, 94);
            lblAddProductTitle.Location = new Point(18, 15);
            lblAddProductTitle.Name = "lblAddProductTitle";
            lblAddProductTitle.Size = new Size(262, 30);
            lblAddProductTitle.TabIndex = 0;
            lblAddProductTitle.Text = "➕ Add New Product";
            // 
            // lblProductType
            // 
            lblProductType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProductType.ForeColor = Color.White;
            lblProductType.Location = new Point(18, 52);
            lblProductType.Name = "lblProductType";
            lblProductType.Size = new Size(105, 19);
            lblProductType.TabIndex = 1;
            lblProductType.Text = "Product Type:";
            // 
            // rbPhysicalProduct
            // 
            rbPhysicalProduct.BackColor = Color.Transparent;
            rbPhysicalProduct.Checked = true;
            rbPhysicalProduct.Font = new Font("Segoe UI", 10F);
            rbPhysicalProduct.ForeColor = Color.White;
            rbPhysicalProduct.Location = new Point(131, 52);
            rbPhysicalProduct.Margin = new Padding(3, 2, 3, 2);
            rbPhysicalProduct.Name = "rbPhysicalProduct";
            rbPhysicalProduct.Size = new Size(131, 19);
            rbPhysicalProduct.TabIndex = 2;
            rbPhysicalProduct.TabStop = true;
            rbPhysicalProduct.Text = "Physical Product";
            rbPhysicalProduct.UseVisualStyleBackColor = false;
            rbPhysicalProduct.CheckedChanged += rbProductType_CheckedChanged;
            // 
            // rbPerishableProduct
            // 
            rbPerishableProduct.BackColor = Color.Transparent;
            rbPerishableProduct.Font = new Font("Segoe UI", 10F);
            rbPerishableProduct.ForeColor = Color.White;
            rbPerishableProduct.Location = new Point(280, 52);
            rbPerishableProduct.Margin = new Padding(3, 2, 3, 2);
            rbPerishableProduct.Name = "rbPerishableProduct";
            rbPerishableProduct.Size = new Size(131, 19);
            rbPerishableProduct.TabIndex = 3;
            rbPerishableProduct.Text = "Perishable Product";
            rbPerishableProduct.UseVisualStyleBackColor = false;
            rbPerishableProduct.CheckedChanged += rbProductType_CheckedChanged;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(18, 82);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 19);
            lblName.TabIndex = 4;
            lblName.Text = "Product Name:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(30, 41, 59);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(131, 82);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(263, 25);
            txtName.TabIndex = 5;
            // 
            // lblSKU
            // 
            lblSKU.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSKU.ForeColor = Color.White;
            lblSKU.Location = new Point(18, 112);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(105, 19);
            lblSKU.TabIndex = 6;
            lblSKU.Text = "SKU:";
            // 
            // txtSKU
            // 
            txtSKU.BackColor = Color.FromArgb(30, 41, 59);
            txtSKU.BorderStyle = BorderStyle.FixedSingle;
            txtSKU.Font = new Font("Segoe UI", 10F);
            txtSKU.ForeColor = Color.White;
            txtSKU.Location = new Point(131, 112);
            txtSKU.Margin = new Padding(3, 2, 3, 2);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(263, 25);
            txtSKU.TabIndex = 7;
            // 
            // lblBarcode
            // 
            lblBarcode.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBarcode.ForeColor = Color.White;
            lblBarcode.Location = new Point(18, 142);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(105, 19);
            lblBarcode.TabIndex = 8;
            lblBarcode.Text = "Barcode:";
            // 
            // txtBarcode
            // 
            txtBarcode.BackColor = Color.FromArgb(30, 41, 59);
            txtBarcode.BorderStyle = BorderStyle.FixedSingle;
            txtBarcode.Font = new Font("Segoe UI", 10F);
            txtBarcode.ForeColor = Color.White;
            txtBarcode.Location = new Point(131, 142);
            txtBarcode.Margin = new Padding(3, 2, 3, 2);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(263, 25);
            txtBarcode.TabIndex = 9;
            // 
            // lblWeight
            // 
            lblWeight.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWeight.ForeColor = Color.White;
            lblWeight.Location = new Point(18, 172);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(105, 19);
            lblWeight.TabIndex = 10;
            lblWeight.Text = "Weight (kg):";
            // 
            // nudWeight
            // 
            nudWeight.BackColor = Color.FromArgb(30, 41, 59);
            nudWeight.DecimalPlaces = 2;
            nudWeight.Font = new Font("Segoe UI", 10F);
            nudWeight.ForeColor = Color.White;
            nudWeight.Location = new Point(131, 172);
            nudWeight.Margin = new Padding(3, 2, 3, 2);
            nudWeight.Maximum = new decimal(new int[] { 999999, 0, 0, 131072 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(131, 25);
            nudWeight.TabIndex = 11;
            // 
            // lblExpiryDate
            // 
            lblExpiryDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblExpiryDate.ForeColor = Color.White;
            lblExpiryDate.Location = new Point(18, 202);
            lblExpiryDate.Name = "lblExpiryDate";
            lblExpiryDate.Size = new Size(105, 19);
            lblExpiryDate.TabIndex = 12;
            lblExpiryDate.Text = "Expiry Date:";
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.BackColor = Color.FromArgb(30, 41, 59);
            dtpExpiryDate.Font = new Font("Segoe UI", 10F);
            dtpExpiryDate.ForeColor = Color.White;
            dtpExpiryDate.Format = DateTimePickerFormat.Short;
            dtpExpiryDate.Location = new Point(131, 202);
            dtpExpiryDate.Margin = new Padding(3, 2, 3, 2);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(176, 25);
            dtpExpiryDate.TabIndex = 13;
            dtpExpiryDate.Value = new DateTime(2025, 11, 19, 0, 0, 0, 0);
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrice.ForeColor = Color.White;
            lblPrice.Location = new Point(18, 240);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(105, 19);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Unit Price ($):";
            // 
            // nudPrice
            // 
            nudPrice.BackColor = Color.FromArgb(30, 41, 59);
            nudPrice.DecimalPlaces = 2;
            nudPrice.Font = new Font("Segoe UI", 10F);
            nudPrice.ForeColor = Color.White;
            nudPrice.Location = new Point(131, 240);
            nudPrice.Margin = new Padding(3, 2, 3, 2);
            nudPrice.Maximum = new decimal(new int[] { 9999999, 0, 0, 131072 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(131, 25);
            nudPrice.TabIndex = 15;
            // 
            // lblCost
            // 
            lblCost.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCost.ForeColor = Color.White;
            lblCost.Location = new Point(280, 240);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(105, 19);
            lblCost.TabIndex = 16;
            lblCost.Text = "Unit Cost ($):";
            // 
            // nudCost
            // 
            nudCost.BackColor = Color.FromArgb(30, 41, 59);
            nudCost.DecimalPlaces = 2;
            nudCost.Font = new Font("Segoe UI", 10F);
            nudCost.ForeColor = Color.White;
            nudCost.Location = new Point(394, 240);
            nudCost.Margin = new Padding(3, 2, 3, 2);
            nudCost.Maximum = new decimal(new int[] { 9999999, 0, 0, 131072 });
            nudCost.Name = "nudCost";
            nudCost.Size = new Size(131, 25);
            nudCost.TabIndex = 17;
            // 
            // lblStock
            // 
            lblStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(18, 296);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(105, 19);
            lblStock.TabIndex = 18;
            lblStock.Text = "Current Stock:";
            // 
            // nudStock
            // 
            nudStock.BackColor = Color.FromArgb(30, 41, 59);
            nudStock.Font = new Font("Segoe UI", 10F);
            nudStock.ForeColor = Color.White;
            nudStock.Location = new Point(131, 296);
            nudStock.Margin = new Padding(3, 2, 3, 2);
            nudStock.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(131, 25);
            nudStock.TabIndex = 19;
            // 
            // lblReorderLevel
            // 
            lblReorderLevel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReorderLevel.ForeColor = Color.White;
            lblReorderLevel.Location = new Point(280, 296);
            lblReorderLevel.Name = "lblReorderLevel";
            lblReorderLevel.Size = new Size(105, 19);
            lblReorderLevel.TabIndex = 20;
            lblReorderLevel.Text = "Reorder Level:";
            // 
            // nudReorderLevel
            // 
            nudReorderLevel.BackColor = Color.FromArgb(30, 41, 59);
            nudReorderLevel.Font = new Font("Segoe UI", 10F);
            nudReorderLevel.ForeColor = Color.White;
            nudReorderLevel.Location = new Point(394, 296);
            nudReorderLevel.Margin = new Padding(3, 2, 3, 2);
            nudReorderLevel.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudReorderLevel.Name = "nudReorderLevel";
            nudReorderLevel.Size = new Size(131, 25);
            nudReorderLevel.TabIndex = 21;
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(18, 326);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(105, 19);
            lblCategory.TabIndex = 22;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.FromArgb(30, 41, 59);
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.ForeColor = Color.White;
            cmbCategory.Location = new Point(131, 326);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(263, 25);
            cmbCategory.TabIndex = 23;
            // 
            // lblSupplier
            // 
            lblSupplier.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSupplier.ForeColor = Color.White;
            lblSupplier.Location = new Point(18, 356);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(105, 19);
            lblSupplier.TabIndex = 24;
            lblSupplier.Text = "Supplier:";
            // 
            // cmbSupplier
            // 
            cmbSupplier.BackColor = Color.FromArgb(30, 41, 59);
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.Font = new Font("Segoe UI", 10F);
            cmbSupplier.ForeColor = Color.White;
            cmbSupplier.Location = new Point(131, 356);
            cmbSupplier.Margin = new Padding(3, 2, 3, 2);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(263, 25);
            cmbSupplier.TabIndex = 25;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(34, 197, 94);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(18, 390);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 30);
            btnSave.TabIndex = 26;
            btnSave.Text = "💾 Save Product";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(239, 68, 68);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(411, 390);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 30);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "❌ Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 38, 127);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(516, 390);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 30);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "🗑️ Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
           
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.FromArgb(107, 114, 128);
            btnClearForm.Cursor = Cursors.Hand;
            btnClearForm.FlatAppearance.BorderSize = 0;
            btnClearForm.FlatStyle = FlatStyle.Flat;
            btnClearForm.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClearForm.ForeColor = Color.White;
            btnClearForm.Location = new Point(289, 390);
            btnClearForm.Margin = new Padding(3, 2, 3, 2);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(105, 30);
            btnClearForm.TabIndex = 30;
            btnClearForm.Text = "🗑️ Clear Form";
            btnClearForm.UseVisualStyleBackColor = false;
            btnClearForm.Click += btnClearForm_Click;
            // 
            // lblCurrency
            // 
            lblCurrency.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCurrency.ForeColor = Color.White;
            lblCurrency.Location = new Point(18, 266);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(114, 19);
            lblCurrency.TabIndex = 31;
            lblCurrency.Text = "View in Currency:";
            // 
            // cmbCurrency
            // 
            cmbCurrency.BackColor = Color.FromArgb(30, 41, 59);
            cmbCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCurrency.Font = new Font("Segoe UI", 10F);
            cmbCurrency.ForeColor = Color.White;
            cmbCurrency.Location = new Point(131, 266);
            cmbCurrency.Margin = new Padding(3, 2, 3, 2);
            cmbCurrency.Name = "cmbCurrency";
            cmbCurrency.Size = new Size(176, 25);
            cmbCurrency.TabIndex = 32;
            cmbCurrency.SelectedIndexChanged += cmbCurrency_SelectedIndexChanged;
            // 
            // lblConvertedPrice
            // 
            lblConvertedPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblConvertedPrice.ForeColor = Color.FromArgb(34, 197, 94);
            lblConvertedPrice.Location = new Point(315, 266);
            lblConvertedPrice.Name = "lblConvertedPrice";
            lblConvertedPrice.Size = new Size(175, 22);
            lblConvertedPrice.TabIndex = 33;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(30, 41, 59);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(700, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(0, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📦 Product Catalog Management";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductCatalogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1400, 675);
            Controls.Add(panelHeader);
            Controls.Add(panelDetails);
            Controls.Add(dgvProducts);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductCatalogForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Catalog Management";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
            panelAddProduct.ResumeLayout(false);
            panelAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudReorderLevel).EndInit();
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}