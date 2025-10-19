namespace InventoryManagementSystem
{
    partial class SalesForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblProduct;
        private ComboBox cmbProduct;
        private Label lblProductPrice;
        private Label lblProductStock;
        private Label lblQuantity;
        private NumericUpDown nudQuantity;
        private Button btnAddItem;
        private DataGridView dgvSaleItems;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblPaymentMethod;
        private ComboBox cmbPaymentMethod;
        private Label lblNotes;
        private TextBox txtNotes;
        private Label lblTotal;
        private Button btnCompleteSale;
        private Button btnCancelSale;
        private Button btnRemoveItem;
        private Button btnClose;
        private Panel panelSaleItems;
        private Panel panelSaleDetails;


        private void InitializeComponent()
        {
            this.lblProduct = new Label();
            this.cmbProduct = new ComboBox();
            this.lblProductPrice = new Label();
            this.lblProductStock = new Label();
            this.lblQuantity = new Label();
            this.nudQuantity = new NumericUpDown();
            this.btnAddItem = new Button();
            this.dgvSaleItems = new DataGridView();
            this.lblCustomerName = new Label();
            this.txtCustomerName = new TextBox();
            this.lblPaymentMethod = new Label();
            this.cmbPaymentMethod = new ComboBox();
            this.lblNotes = new Label();
            this.txtNotes = new TextBox();
            this.lblTotal = new Label();
            this.btnCompleteSale = new Button();
            this.btnCancelSale = new Button();
            this.btnRemoveItem = new Button();
            this.btnClose = new Button();
            this.panelSaleItems = new Panel();
            this.panelSaleDetails = new Panel();
            this.panelSaleItems.SuspendLayout();
            this.panelSaleDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).BeginInit();
            this.SuspendLayout();

            // SalesForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Text = "Sales";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Panel Sale Items
            this.panelSaleItems.Dock = DockStyle.Left;
            this.panelSaleItems.Width = 500;
            this.panelSaleItems.BackColor = System.Drawing.Color.LightBlue;
            this.panelSaleItems.Padding = new Padding(20);

            // Product selection
            this.lblProduct.Text = "Product:";
            this.lblProduct.Location = new System.Drawing.Point(20, 20);
            this.lblProduct.Size = new System.Drawing.Size(80, 25);

            this.cmbProduct.Location = new System.Drawing.Point(110, 20);
            this.cmbProduct.Size = new System.Drawing.Size(300, 25);
            this.cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbProduct.SelectedIndexChanged += new EventHandler(this.cmbProduct_SelectedIndexChanged);

            this.lblProductPrice.Text = "Price: $0.00";
            this.lblProductPrice.Location = new System.Drawing.Point(20, 60);
            this.lblProductPrice.Size = new System.Drawing.Size(150, 25);
            this.lblProductPrice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);

            this.lblProductStock.Text = "Stock: 0";
            this.lblProductStock.Location = new System.Drawing.Point(20, 90);
            this.lblProductStock.Size = new System.Drawing.Size(150, 25);

            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.Location = new System.Drawing.Point(20, 130);
            this.lblQuantity.Size = new System.Drawing.Size(80, 25);

            this.nudQuantity.Location = new System.Drawing.Point(110, 130);
            this.nudQuantity.Size = new System.Drawing.Size(100, 25);
            this.nudQuantity.Minimum = 1;
            this.nudQuantity.Maximum = 999999;

            this.btnAddItem.Text = "Add to Sale";
            this.btnAddItem.Location = new System.Drawing.Point(220, 130);
            this.btnAddItem.Size = new System.Drawing.Size(120, 30);
            this.btnAddItem.Click += new EventHandler(this.btnAddItem_Click);

            // Sale items grid
            this.dgvSaleItems.Location = new System.Drawing.Point(20, 180);
            this.dgvSaleItems.Size = new System.Drawing.Size(450, 200);
            this.dgvSaleItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaleItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.Location = new System.Drawing.Point(20, 400);
            this.btnRemoveItem.Size = new System.Drawing.Size(120, 30);
            this.btnRemoveItem.Click += new EventHandler(this.btnRemoveItem_Click);

            // Panel Sale Details
            this.panelSaleDetails.Dock = DockStyle.Fill;
            this.panelSaleDetails.BackColor = System.Drawing.Color.LightGray;
            this.panelSaleDetails.Padding = new Padding(20);

            // Customer details
            this.lblCustomerName.Text = "Customer Name:";
            this.lblCustomerName.Location = new System.Drawing.Point(20, 20);
            this.lblCustomerName.Size = new System.Drawing.Size(120, 25);

            this.txtCustomerName.Location = new System.Drawing.Point(150, 20);
            this.txtCustomerName.Size = new System.Drawing.Size(200, 25);

            this.lblPaymentMethod.Text = "Payment Method:";
            this.lblPaymentMethod.Location = new System.Drawing.Point(20, 60);
            this.lblPaymentMethod.Size = new System.Drawing.Size(120, 25);

            this.cmbPaymentMethod.Location = new System.Drawing.Point(150, 60);
            this.cmbPaymentMethod.Size = new System.Drawing.Size(200, 25);
            this.cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Debit Card", "Check" });
            this.cmbPaymentMethod.SelectedIndex = 0;

            this.lblNotes.Text = "Notes:";
            this.lblNotes.Location = new System.Drawing.Point(20, 100);
            this.lblNotes.Size = new System.Drawing.Size(120, 25);

            this.txtNotes.Location = new System.Drawing.Point(150, 100);
            this.txtNotes.Size = new System.Drawing.Size(300, 100);
            this.txtNotes.Multiline = true;
            this.txtNotes.ScrollBars = ScrollBars.Vertical;

            // Total and buttons
            this.lblTotal.Text = "Total: $0.00";
            this.lblTotal.Location = new System.Drawing.Point(20, 220);
            this.lblTotal.Size = new System.Drawing.Size(200, 30);
            this.lblTotal.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.DarkBlue;

            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.Location = new System.Drawing.Point(20, 270);
            this.btnCompleteSale.Size = new System.Drawing.Size(120, 40);
            this.btnCompleteSale.BackColor = System.Drawing.Color.Green;
            this.btnCompleteSale.ForeColor = System.Drawing.Color.White;
            this.btnCompleteSale.Click += new EventHandler(this.btnCompleteSale_Click);

            this.btnCancelSale.Text = "Cancel Sale";
            this.btnCancelSale.Location = new System.Drawing.Point(150, 270);
            this.btnCancelSale.Size = new System.Drawing.Size(120, 40);
            this.btnCancelSale.BackColor = System.Drawing.Color.Red;
            this.btnCancelSale.ForeColor = System.Drawing.Color.White;
            this.btnCancelSale.Click += new EventHandler(this.btnCancelSale_Click);

            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(280, 270);
            this.btnClose.Size = new System.Drawing.Size(80, 40);
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // Add controls to panels
            this.panelSaleItems.Controls.Add(this.lblProduct);
            this.panelSaleItems.Controls.Add(this.cmbProduct);
            this.panelSaleItems.Controls.Add(this.lblProductPrice);
            this.panelSaleItems.Controls.Add(this.lblProductStock);
            this.panelSaleItems.Controls.Add(this.lblQuantity);
            this.panelSaleItems.Controls.Add(this.nudQuantity);
            this.panelSaleItems.Controls.Add(this.btnAddItem);
            this.panelSaleItems.Controls.Add(this.dgvSaleItems);
            this.panelSaleItems.Controls.Add(this.btnRemoveItem);

            this.panelSaleDetails.Controls.Add(this.lblCustomerName);
            this.panelSaleDetails.Controls.Add(this.txtCustomerName);
            this.panelSaleDetails.Controls.Add(this.lblPaymentMethod);
            this.panelSaleDetails.Controls.Add(this.cmbPaymentMethod);
            this.panelSaleDetails.Controls.Add(this.lblNotes);
            this.panelSaleDetails.Controls.Add(this.txtNotes);
            this.panelSaleDetails.Controls.Add(this.lblTotal);
            this.panelSaleDetails.Controls.Add(this.btnCompleteSale);
            this.panelSaleDetails.Controls.Add(this.btnCancelSale);
            this.panelSaleDetails.Controls.Add(this.btnClose);

            // Add panels to form
            this.Controls.Add(this.panelSaleDetails);
            this.Controls.Add(this.panelSaleItems);

            this.panelSaleItems.ResumeLayout(false);
            this.panelSaleItems.PerformLayout();
            this.panelSaleDetails.ResumeLayout(false);
            this.panelSaleDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
