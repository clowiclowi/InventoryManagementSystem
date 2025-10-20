namespace InventoryManagementSystem
{
    partial class StockManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblProduct;
        private ComboBox cmbProduct;
        private Label lblCurrentStock;
        private Label lblReorderLevel;
        private Label lblNeedsReorder;
        private GroupBox groupTransactionType;
        private RadioButton radioStockIn;
        private RadioButton radioStockOut;
        private RadioButton radioAdjustment;
        private Label lblQuantity;
        private NumericUpDown nudQuantity;
        private Label lblReason;
        private TextBox txtReason;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Button btnProcessTransaction;
        private Button btnRefresh;
        private Button btnClose;
        private DataGridView dgvTransactions;
        private Panel panelTransaction;
        private Panel panelTransactions;


        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblProduct = new Label();
            cmbProduct = new ComboBox();
            lblCurrentStock = new Label();
            lblReorderLevel = new Label();
            lblNeedsReorder = new Label();
            groupTransactionType = new GroupBox();
            radioStockIn = new RadioButton();
            radioStockOut = new RadioButton();
            radioAdjustment = new RadioButton();
            lblQuantity = new Label();
            nudQuantity = new NumericUpDown();
            lblReason = new Label();
            txtReason = new TextBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            btnProcessTransaction = new Button();
            btnRefresh = new Button();
            btnClose = new Button();
            dgvTransactions = new DataGridView();
            panelTransaction = new Panel();
            panelTransactions = new Panel();
            lblTransactionsTitle = new Label();
            groupTransactionType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            panelTransaction.SuspendLayout();
            panelTransactions.SuspendLayout();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProduct.ForeColor = Color.FromArgb(52, 73, 94);
            lblProduct.Location = new Point(26, 22);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(131, 22);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "📦 Select Product";
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.Font = new Font("Segoe UI", 10F);
            cmbProduct.Location = new Point(26, 52);
            cmbProduct.Margin = new Padding(3, 2, 3, 2);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(333, 25);
            cmbProduct.TabIndex = 1;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // lblCurrentStock
            // 
            lblCurrentStock.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCurrentStock.ForeColor = Color.FromArgb(46, 204, 113);
            lblCurrentStock.Location = new Point(26, 98);
            lblCurrentStock.Name = "lblCurrentStock";
            lblCurrentStock.Size = new Size(175, 22);
            lblCurrentStock.TabIndex = 2;
            lblCurrentStock.Text = "Current Stock: 0";
            // 
            // lblReorderLevel
            // 
            lblReorderLevel.Font = new Font("Segoe UI", 10F);
            lblReorderLevel.ForeColor = Color.FromArgb(108, 117, 125);
            lblReorderLevel.Location = new Point(26, 120);
            lblReorderLevel.Name = "lblReorderLevel";
            lblReorderLevel.Size = new Size(175, 22);
            lblReorderLevel.TabIndex = 3;
            lblReorderLevel.Text = "Reorder Level: 0";
            // 
            // lblNeedsReorder
            // 
            lblNeedsReorder.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNeedsReorder.ForeColor = Color.FromArgb(46, 204, 113);
            lblNeedsReorder.Location = new Point(26, 142);
            lblNeedsReorder.Name = "lblNeedsReorder";
            lblNeedsReorder.Size = new Size(175, 22);
            lblNeedsReorder.TabIndex = 4;
            lblNeedsReorder.Text = "Stock OK";
            // 
            // groupTransactionType
            // 
            groupTransactionType.Controls.Add(radioStockIn);
            groupTransactionType.Controls.Add(radioStockOut);
            groupTransactionType.Controls.Add(radioAdjustment);
            groupTransactionType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupTransactionType.ForeColor = Color.FromArgb(52, 73, 94);
            groupTransactionType.Location = new Point(26, 180);
            groupTransactionType.Margin = new Padding(3, 2, 3, 2);
            groupTransactionType.Name = "groupTransactionType";
            groupTransactionType.Padding = new Padding(3, 2, 3, 2);
            groupTransactionType.Size = new Size(332, 90);
            groupTransactionType.TabIndex = 5;
            groupTransactionType.TabStop = false;
            groupTransactionType.Text = "🔄 Transaction Type";
            // 
            // radioStockIn
            // 
            radioStockIn.Checked = true;
            radioStockIn.Font = new Font("Segoe UI", 9F);
            radioStockIn.Location = new Point(18, 22);
            radioStockIn.Margin = new Padding(3, 2, 3, 2);
            radioStockIn.Name = "radioStockIn";
            radioStockIn.Size = new Size(175, 19);
            radioStockIn.TabIndex = 0;
            radioStockIn.TabStop = true;
            radioStockIn.Text = "📥 Stock In (Add inventory)";
            // 
            // radioStockOut
            // 
            radioStockOut.Font = new Font("Segoe UI", 9F);
            radioStockOut.Location = new Point(18, 45);
            radioStockOut.Margin = new Padding(3, 2, 3, 2);
            radioStockOut.Name = "radioStockOut";
            radioStockOut.Size = new Size(175, 19);
            radioStockOut.TabIndex = 1;
            radioStockOut.Text = "📤 Stock Out (Remove inventory)";
            // 
            // radioAdjustment
            // 
            radioAdjustment.Font = new Font("Segoe UI", 9F);
            radioAdjustment.Location = new Point(18, 68);
            radioAdjustment.Margin = new Padding(3, 2, 3, 2);
            radioAdjustment.Name = "radioAdjustment";
            radioAdjustment.Size = new Size(219, 19);
            radioAdjustment.TabIndex = 2;
            radioAdjustment.Text = "🔧 Stock Adjustment (Correct count)";
            // 
            // lblQuantity
            // 
            lblQuantity.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.FromArgb(52, 73, 94);
            lblQuantity.Location = new Point(26, 285);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(105, 22);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "📊 Quantity";
            // 
            // nudQuantity
            // 
            nudQuantity.BorderStyle = BorderStyle.FixedSingle;
            nudQuantity.Font = new Font("Segoe UI", 10F);
            nudQuantity.Location = new Point(26, 315);
            nudQuantity.Margin = new Padding(3, 2, 3, 2);
            nudQuantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(105, 25);
            nudQuantity.TabIndex = 7;
            // 
            // lblReason
            // 
            lblReason.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblReason.ForeColor = Color.FromArgb(52, 73, 94);
            lblReason.Location = new Point(26, 352);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(140, 22);
            lblReason.TabIndex = 8;
            lblReason.Text = "📝 Reason/Notes";
            // 
            // txtReason
            // 
            txtReason.BorderStyle = BorderStyle.FixedSingle;
            txtReason.Font = new Font("Segoe UI", 10F);
            txtReason.Location = new Point(26, 382);
            txtReason.Margin = new Padding(3, 2, 3, 2);
            txtReason.Name = "txtReason";
            txtReason.PlaceholderText = "e.g., Delivery, Sale, Damage, etc.";
            txtReason.Size = new Size(333, 25);
            txtReason.TabIndex = 9;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(52, 73, 94);
            lblDate.Location = new Point(26, 420);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(131, 22);
            lblDate.TabIndex = 10;
            lblDate.Text = "📅 Transaction Date";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 10F);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(26, 450);
            dtpDate.Margin = new Padding(3, 2, 3, 2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(176, 25);
            dtpDate.TabIndex = 11;
            dtpDate.Value = new DateTime(2025, 10, 20, 18, 13, 3, 383);
            // 
            // btnProcessTransaction
            // 
            btnProcessTransaction.BackColor = Color.FromArgb(46, 204, 113);
            btnProcessTransaction.Cursor = Cursors.Hand;
            btnProcessTransaction.FlatAppearance.BorderSize = 0;
            btnProcessTransaction.FlatStyle = FlatStyle.Flat;
            btnProcessTransaction.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProcessTransaction.ForeColor = Color.White;
            btnProcessTransaction.Location = new Point(26, 488);
            btnProcessTransaction.Margin = new Padding(3, 2, 3, 2);
            btnProcessTransaction.Name = "btnProcessTransaction";
            btnProcessTransaction.Size = new Size(158, 34);
            btnProcessTransaction.TabIndex = 12;
            btnProcessTransaction.Text = "✅ Process Transaction";
            btnProcessTransaction.UseVisualStyleBackColor = false;
            btnProcessTransaction.Click += btnProcessTransaction_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(201, 488);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(88, 34);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(231, 76, 60);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(306, 488);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(88, 34);
            btnClose.TabIndex = 14;
            btnClose.Text = "❌ Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.BorderStyle = BorderStyle.None;
            dgvTransactions.Font = new Font("Segoe UI", 9F);
            dgvTransactions.GridColor = Color.FromArgb(240, 244, 248);
            dgvTransactions.Location = new Point(18, 38);
            dgvTransactions.Margin = new Padding(3, 2, 3, 2);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(534, 465);
            dgvTransactions.TabIndex = 1;
            // 
            // panelTransaction
            // 
            panelTransaction.BackColor = Color.White;
            panelTransaction.Controls.Add(lblProduct);
            panelTransaction.Controls.Add(cmbProduct);
            panelTransaction.Controls.Add(lblCurrentStock);
            panelTransaction.Controls.Add(lblReorderLevel);
            panelTransaction.Controls.Add(lblNeedsReorder);
            panelTransaction.Controls.Add(groupTransactionType);
            panelTransaction.Controls.Add(lblQuantity);
            panelTransaction.Controls.Add(nudQuantity);
            panelTransaction.Controls.Add(lblReason);
            panelTransaction.Controls.Add(txtReason);
            panelTransaction.Controls.Add(lblDate);
            panelTransaction.Controls.Add(dtpDate);
            panelTransaction.Controls.Add(btnProcessTransaction);
            panelTransaction.Controls.Add(btnRefresh);
            panelTransaction.Controls.Add(btnClose);
            panelTransaction.Location = new Point(26, 22);
            panelTransaction.Margin = new Padding(3, 2, 3, 2);
            panelTransaction.Name = "panelTransaction";
            panelTransaction.Size = new Size(394, 525);
            panelTransaction.TabIndex = 1;
            // 
            // panelTransactions
            // 
            panelTransactions.BackColor = Color.White;
            panelTransactions.Controls.Add(lblTransactionsTitle);
            panelTransactions.Controls.Add(dgvTransactions);
            panelTransactions.Location = new Point(438, 22);
            panelTransactions.Margin = new Padding(3, 2, 3, 2);
            panelTransactions.Name = "panelTransactions";
            panelTransactions.Size = new Size(569, 525);
            panelTransactions.TabIndex = 0;
            // 
            // lblTransactionsTitle
            // 
            lblTransactionsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTransactionsTitle.ForeColor = Color.FromArgb(52, 73, 94);
            lblTransactionsTitle.Location = new Point(18, 8);
            lblTransactionsTitle.Name = "lblTransactionsTitle";
            lblTransactionsTitle.Size = new Size(350, 30);
            lblTransactionsTitle.TabIndex = 0;
            lblTransactionsTitle.Text = "📋 Recent Stock Transactions";
            // 
            // StockManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1050, 600);
            Controls.Add(panelTransactions);
            Controls.Add(panelTransaction);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StockManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "📊 Stock Management";
            WindowState = FormWindowState.Maximized;
            groupTransactionType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            panelTransaction.ResumeLayout(false);
            panelTransaction.PerformLayout();
            panelTransactions.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Label lblTransactionsTitle;
    }
}
