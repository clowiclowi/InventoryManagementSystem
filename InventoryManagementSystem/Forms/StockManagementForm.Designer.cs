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
            this.lblProduct = new Label();
            this.cmbProduct = new ComboBox();
            this.lblCurrentStock = new Label();
            this.lblReorderLevel = new Label();
            this.lblNeedsReorder = new Label();
            this.groupTransactionType = new GroupBox();
            this.radioStockIn = new RadioButton();
            this.radioStockOut = new RadioButton();
            this.radioAdjustment = new RadioButton();
            this.lblQuantity = new Label();
            this.nudQuantity = new NumericUpDown();
            this.lblReason = new Label();
            this.txtReason = new TextBox();
            this.lblDate = new Label();
            this.dtpDate = new DateTimePicker();
            this.btnProcessTransaction = new Button();
            this.btnRefresh = new Button();
            this.btnClose = new Button();
            this.dgvTransactions = new DataGridView();
            this.panelTransaction = new Panel();
            this.panelTransactions = new Panel();
            this.groupTransactionType.SuspendLayout();
            this.panelTransaction.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();

            // StockManagementForm - Modern Design
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Text = "📊 Stock Management";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(240, 244, 248);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WindowState = FormWindowState.Maximized;

            // Panel Transaction - Modern Card Design
            this.panelTransaction.Location = new System.Drawing.Point(30, 30);
            this.panelTransaction.Size = new System.Drawing.Size(450, 700);
            this.panelTransaction.BackColor = System.Drawing.Color.White;
            this.panelTransaction.BorderStyle = BorderStyle.None;

            // Product selection - Modern styling
            this.lblProduct.Text = "📦 Select Product";
            this.lblProduct.Location = new System.Drawing.Point(30, 30);
            this.lblProduct.Size = new System.Drawing.Size(150, 30);
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);

            this.cmbProduct.Location = new System.Drawing.Point(30, 70);
            this.cmbProduct.Size = new System.Drawing.Size(380, 35);
            this.cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProduct.SelectedIndexChanged += new EventHandler(this.cmbProduct_SelectedIndexChanged);

            // Stock information - Card style
            this.lblCurrentStock.Text = "Current Stock: 0";
            this.lblCurrentStock.Location = new System.Drawing.Point(30, 130);
            this.lblCurrentStock.Size = new System.Drawing.Size(200, 30);
            this.lblCurrentStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCurrentStock.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);

            this.lblReorderLevel.Text = "Reorder Level: 0";
            this.lblReorderLevel.Location = new System.Drawing.Point(30, 160);
            this.lblReorderLevel.Size = new System.Drawing.Size(200, 30);
            this.lblReorderLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReorderLevel.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);

            this.lblNeedsReorder.Text = "Stock OK";
            this.lblNeedsReorder.Location = new System.Drawing.Point(30, 190);
            this.lblNeedsReorder.Size = new System.Drawing.Size(200, 30);
            this.lblNeedsReorder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNeedsReorder.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);

            // Transaction type group - Modern styling
            this.groupTransactionType.Text = "🔄 Transaction Type";
            this.groupTransactionType.Location = new System.Drawing.Point(30, 240);
            this.groupTransactionType.Size = new System.Drawing.Size(380, 120);
            this.groupTransactionType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupTransactionType.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);

            this.radioStockIn.Text = "📥 Stock In (Add inventory)";
            this.radioStockIn.Location = new System.Drawing.Point(20, 30);
            this.radioStockIn.Size = new System.Drawing.Size(200, 25);
            this.radioStockIn.Checked = true;
            this.radioStockIn.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.radioStockOut.Text = "📤 Stock Out (Remove inventory)";
            this.radioStockOut.Location = new System.Drawing.Point(20, 60);
            this.radioStockOut.Size = new System.Drawing.Size(200, 25);
            this.radioStockOut.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.radioAdjustment.Text = "🔧 Stock Adjustment (Correct count)";
            this.radioAdjustment.Location = new System.Drawing.Point(20, 90);
            this.radioAdjustment.Size = new System.Drawing.Size(250, 25);
            this.radioAdjustment.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.groupTransactionType.Controls.Add(this.radioStockIn);
            this.groupTransactionType.Controls.Add(this.radioStockOut);
            this.groupTransactionType.Controls.Add(this.radioAdjustment);

            // Quantity - Modern styling
            this.lblQuantity.Text = "📊 Quantity";
            this.lblQuantity.Location = new System.Drawing.Point(30, 380);
            this.lblQuantity.Size = new System.Drawing.Size(100, 30);
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);

            this.nudQuantity.Location = new System.Drawing.Point(30, 420);
            this.nudQuantity.Size = new System.Drawing.Size(120, 35);
            this.nudQuantity.Maximum = 999999;
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudQuantity.BorderStyle = BorderStyle.FixedSingle;

            // Reason - Modern styling
            this.lblReason.Text = "📝 Reason/Notes";
            this.lblReason.Location = new System.Drawing.Point(30, 470);
            this.lblReason.Size = new System.Drawing.Size(150, 30);
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblReason.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);

            this.txtReason.Location = new System.Drawing.Point(30, 510);
            this.txtReason.Size = new System.Drawing.Size(380, 35);
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReason.BorderStyle = BorderStyle.FixedSingle;
            this.txtReason.PlaceholderText = "e.g., Delivery, Sale, Damage, etc.";

            // Date - Modern styling
            this.lblDate.Text = "📅 Transaction Date";
            this.lblDate.Location = new System.Drawing.Point(30, 560);
            this.lblDate.Size = new System.Drawing.Size(150, 30);
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);

            this.dtpDate.Location = new System.Drawing.Point(30, 600);
            this.dtpDate.Size = new System.Drawing.Size(200, 35);
            this.dtpDate.Value = DateTime.Now;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.Format = DateTimePickerFormat.Short;

            // Buttons - Modern styling
            this.btnProcessTransaction.Text = "✅ Process Transaction";
            this.btnProcessTransaction.Location = new System.Drawing.Point(30, 650);
            this.btnProcessTransaction.Size = new System.Drawing.Size(180, 45);
            this.btnProcessTransaction.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnProcessTransaction.ForeColor = System.Drawing.Color.White;
            this.btnProcessTransaction.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnProcessTransaction.FlatStyle = FlatStyle.Flat;
            this.btnProcessTransaction.FlatAppearance.BorderSize = 0;
            this.btnProcessTransaction.Cursor = Cursors.Hand;
            this.btnProcessTransaction.Click += new EventHandler(this.btnProcessTransaction_Click);

            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(230, 650);
            this.btnRefresh.Size = new System.Drawing.Size(100, 45);
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Cursor = Cursors.Hand;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);

            this.btnClose.Text = "❌ Close";
            this.btnClose.Location = new System.Drawing.Point(350, 650);
            this.btnClose.Size = new System.Drawing.Size(100, 45);
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Cursor = Cursors.Hand;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // Panel Transactions - Modern design
            this.panelTransactions.Location = new System.Drawing.Point(500, 30);
            this.panelTransactions.Size = new System.Drawing.Size(650, 700);
            this.panelTransactions.BackColor = System.Drawing.Color.White;
            this.panelTransactions.BorderStyle = BorderStyle.None;

            this.dgvTransactions.Location = new System.Drawing.Point(20, 50);
            this.dgvTransactions.Size = new System.Drawing.Size(610, 620);
            this.dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactions.BorderStyle = BorderStyle.None;
            this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(240, 244, 248);
            this.dgvTransactions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvTransactions.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AllowUserToResizeRows = false;

            // Add header label for transactions
            var lblTransactionsTitle = new Label();
            lblTransactionsTitle.Text = "📋 Recent Stock Transactions";
            lblTransactionsTitle.Location = new System.Drawing.Point(20, 10);
            lblTransactionsTitle.Size = new System.Drawing.Size(400, 40);
            lblTransactionsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTransactionsTitle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);

            this.panelTransactions.Controls.Add(lblTransactionsTitle);
            this.panelTransactions.Controls.Add(this.dgvTransactions);

            // Add controls to transaction panel
            this.panelTransaction.Controls.Add(this.lblProduct);
            this.panelTransaction.Controls.Add(this.cmbProduct);
            this.panelTransaction.Controls.Add(this.lblCurrentStock);
            this.panelTransaction.Controls.Add(this.lblReorderLevel);
            this.panelTransaction.Controls.Add(this.lblNeedsReorder);
            this.panelTransaction.Controls.Add(this.groupTransactionType);
            this.panelTransaction.Controls.Add(this.lblQuantity);
            this.panelTransaction.Controls.Add(this.nudQuantity);
            this.panelTransaction.Controls.Add(this.lblReason);
            this.panelTransaction.Controls.Add(this.txtReason);
            this.panelTransaction.Controls.Add(this.lblDate);
            this.panelTransaction.Controls.Add(this.dtpDate);
            this.panelTransaction.Controls.Add(this.btnProcessTransaction);
            this.panelTransaction.Controls.Add(this.btnRefresh);
            this.panelTransaction.Controls.Add(this.btnClose);

            // Add panels to form
            this.Controls.Add(this.panelTransactions);
            this.Controls.Add(this.panelTransaction);

            this.groupTransactionType.ResumeLayout(false);
            this.groupTransactionType.PerformLayout();
            this.panelTransaction.ResumeLayout(false);
            this.panelTransaction.PerformLayout();
            this.panelTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
