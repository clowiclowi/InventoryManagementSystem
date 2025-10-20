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


        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelMain = new Panel();
            panelTable = new Panel();
            dgvSuppliers = new DataGridView();
            panelControls = new Panel();
            btnAddNewSupplier = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panelHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelMain.SuspendLayout();
            panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            panelControls.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(15, 23, 42);
            panelMain.Controls.Add(panelTable);
            panelMain.Controls.Add(panelControls);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1400, 675);
            panelMain.TabIndex = 0;

            // 
            // panelTable
            // 
            panelTable.BackColor = Color.FromArgb(30, 41, 59);
            panelTable.Controls.Add(dgvSuppliers);
            panelTable.Dock = DockStyle.Fill;
            panelTable.Location = new Point(0, 125);
            panelTable.Margin = new Padding(3, 2, 3, 2);
            panelTable.Name = "panelTable";
            panelTable.Padding = new Padding(18, 15, 18, 15);
            panelTable.Size = new Size(1400, 550);
            panelTable.TabIndex = 1;
            // 
            // dgvSuppliers
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvSuppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.BackgroundColor = Color.FromArgb(30, 41, 59);
            dgvSuppliers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSuppliers.Dock = DockStyle.Fill;
            dgvSuppliers.Font = new Font("Segoe UI", 10F);
            dgvSuppliers.GridColor = Color.FromArgb(51, 65, 85);
            dgvSuppliers.Location = new Point(18, 15);
            dgvSuppliers.Margin = new Padding(3, 2, 3, 2);
            dgvSuppliers.Name = "dgvSuppliers";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dgvSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(1364, 520);
            dgvSuppliers.TabIndex = 0;
            // 
            // panelControls
            // 
            panelControls.BackColor = Color.FromArgb(30, 41, 59);
            panelControls.Controls.Add(btnAddNewSupplier);
            panelControls.Controls.Add(btnSearch);
            panelControls.Controls.Add(txtSearch);
            panelControls.Dock = DockStyle.Top;
            panelControls.Location = new Point(0, 76);
            panelControls.Margin = new Padding(3, 2, 3, 2);
            panelControls.Name = "panelControls";
            panelControls.Padding = new Padding(18, 8, 18, 8);
            panelControls.Size = new Size(1400, 49);
            panelControls.TabIndex = 2;
            // 
            // btnAddNewSupplier
            // 
            btnAddNewSupplier.BackColor = Color.FromArgb(34, 197, 94);
            btnAddNewSupplier.Cursor = Cursors.Hand;
            btnAddNewSupplier.FlatAppearance.BorderSize = 0;
            btnAddNewSupplier.FlatStyle = FlatStyle.Flat;
            btnAddNewSupplier.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddNewSupplier.ForeColor = Color.White;
            btnAddNewSupplier.Location = new Point(350, 11);
            btnAddNewSupplier.Margin = new Padding(3, 2, 3, 2);
            btnAddNewSupplier.Name = "btnAddNewSupplier";
            btnAddNewSupplier.Size = new Size(131, 28);
            btnAddNewSupplier.TabIndex = 0;
            btnAddNewSupplier.Text = "➕ Add New Supplier";
            btnAddNewSupplier.UseVisualStyleBackColor = false;
            btnAddNewSupplier.Click += btnAddNewSupplier_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(59, 130, 246);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(289, 11);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(35, 28);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "🔍";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(51, 65, 85);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(18, 11);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search suppliers by name, contact, email, phone, or location...";
            txtSearch.Size = new Size(263, 27);
            txtSearch.TabIndex = 2;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(30, 41, 59);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(18, 15, 18, 15);
            panelHeader.Size = new Size(1400, 76);
            panelHeader.TabIndex = 3;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtitle.Location = new Point(18, 48);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(525, 19);
            lblSubtitle.TabIndex = 0;
            lblSubtitle.Text = "Manage vendors, relationships, pricing, and lead times";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(11, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 50);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "🏭 Supplier Management";
            // 
            // SupplierManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1400, 675);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SupplierManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supplier Management";
            panelMain.ResumeLayout(false);
            panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}

