namespace InventoryManagementSystem
{
    partial class SupplierManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        
        // Main controls
        private Panel panelMain;
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelControls;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAddNewSupplier;
        private Panel panelTable;
        private DataGridView dgvSuppliers;
        
        // Supplier drawer
        private Panel panelSupplierDrawer;
        private Button btnCloseDrawer;
        private Label lblDrawerTitle;

        private void InitializeComponent()
        {
            this.panelMain = new Panel();
            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();
            this.panelControls = new Panel();
            this.txtSearch = new TextBox();
            this.btnSearch = new Button();
            this.btnAddNewSupplier = new Button();
            this.panelTable = new Panel();
            this.dgvSuppliers = new DataGridView();
            this.panelSupplierDrawer = new Panel();
            this.btnCloseDrawer = new Button();
            this.lblDrawerTitle = new Label();
            
            this.panelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.panelTable.SuspendLayout();
            this.panelSupplierDrawer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Text = "Supplier Management";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Main Panel
            this.panelMain.Controls.Add(this.panelSupplierDrawer);
            this.panelMain.Controls.Add(this.panelTable);
            this.panelMain.Controls.Add(this.panelControls);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);

            // Header Panel
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 80;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelHeader.Padding = new Padding(20);

            this.lblTitle.Text = "🏭 Supplier Management";
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(400, 35);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;

            this.lblSubtitle.Text = "Manage vendors, relationships, pricing, and lead times";
            this.lblSubtitle.Location = new System.Drawing.Point(20, 50);
            this.lblSubtitle.Size = new System.Drawing.Size(600, 25);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);

            // Controls Panel
            this.panelControls.Controls.Add(this.btnAddNewSupplier);
            this.panelControls.Controls.Add(this.btnSearch);
            this.panelControls.Controls.Add(this.txtSearch);
            this.panelControls.Dock = DockStyle.Top;
            this.panelControls.Height = 60;
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelControls.Padding = new Padding(20, 10, 20, 10);

            // Search Box
            this.txtSearch.Location = new System.Drawing.Point(20, 15);
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = BorderStyle.FixedSingle;
            this.txtSearch.PlaceholderText = "Search suppliers by name, contact, email, phone, or location...";

            // Search Button
            this.btnSearch.Text = "🔍";
            this.btnSearch.Location = new System.Drawing.Point(330, 15);
            this.btnSearch.Size = new System.Drawing.Size(40, 30);
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Cursor = Cursors.Hand;
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);

            // Add New Supplier Button
            this.btnAddNewSupplier.Text = "➕ Add New Supplier";
            this.btnAddNewSupplier.Location = new System.Drawing.Point(400, 15);
            this.btnAddNewSupplier.Size = new System.Drawing.Size(150, 30);
            this.btnAddNewSupplier.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnAddNewSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddNewSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddNewSupplier.FlatStyle = FlatStyle.Flat;
            this.btnAddNewSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddNewSupplier.Cursor = Cursors.Hand;
            this.btnAddNewSupplier.Click += new EventHandler(this.btnAddNewSupplier_Click);

            // Table Panel
            this.panelTable.Controls.Add(this.dgvSuppliers);
            this.panelTable.Dock = DockStyle.Fill;
            this.panelTable.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelTable.Padding = new Padding(20);

            // Suppliers Data Grid
            this.dgvSuppliers.Dock = DockStyle.Fill;
            this.dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvSuppliers.BorderStyle = BorderStyle.None;
            this.dgvSuppliers.GridColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvSuppliers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvSuppliers.ForeColor = System.Drawing.Color.White;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvSuppliers.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvSuppliers.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSuppliers.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvSuppliers.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSuppliers.SelectionChanged += new EventHandler(this.dgvSuppliers_SelectionChanged);

            // Supplier Drawer Panel
            this.panelSupplierDrawer.Controls.Add(this.btnCloseDrawer);
            this.panelSupplierDrawer.Controls.Add(this.lblDrawerTitle);
            this.panelSupplierDrawer.Dock = DockStyle.Right;
            this.panelSupplierDrawer.Width = 500;
            this.panelSupplierDrawer.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.panelSupplierDrawer.Visible = false;

            this.btnCloseDrawer.Text = "✕";
            this.btnCloseDrawer.Location = new System.Drawing.Point(460, 10);
            this.btnCloseDrawer.Size = new System.Drawing.Size(30, 30);
            this.btnCloseDrawer.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnCloseDrawer.ForeColor = System.Drawing.Color.White;
            this.btnCloseDrawer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCloseDrawer.FlatStyle = FlatStyle.Flat;
            this.btnCloseDrawer.FlatAppearance.BorderSize = 0;
            this.btnCloseDrawer.Cursor = Cursors.Hand;
            this.btnCloseDrawer.Click += new EventHandler(this.btnCloseDrawer_Click);

            this.lblDrawerTitle.Text = "Supplier Details";
            this.lblDrawerTitle.Location = new System.Drawing.Point(20, 15);
            this.lblDrawerTitle.Size = new System.Drawing.Size(200, 25);
            this.lblDrawerTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDrawerTitle.ForeColor = System.Drawing.Color.White;

            // Add main panel to form
            this.Controls.Add(this.panelMain);

            this.panelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelTable.ResumeLayout(false);
            this.panelSupplierDrawer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

