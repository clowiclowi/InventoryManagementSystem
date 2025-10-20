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
            lblProduct = new Label();
            cmbProduct = new ComboBox();
            lblProductPrice = new Label();
            lblProductStock = new Label();
            lblQuantity = new Label();
            nudQuantity = new NumericUpDown();
            btnAddItem = new Button();
            dgvSaleItems = new DataGridView();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblPaymentMethod = new Label();
            cmbPaymentMethod = new ComboBox();
            lblNotes = new Label();
            txtNotes = new TextBox();
            lblTotal = new Label();
            btnCompleteSale = new Button();
            btnCancelSale = new Button();
            btnRemoveItem = new Button();
            btnClose = new Button();
            panelSaleItems = new Panel();
            panelSaleDetails = new Panel();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleItems).BeginInit();
            panelSaleItems.SuspendLayout();
            panelSaleDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.ForeColor = SystemColors.Window;
            lblProduct.Location = new Point(18, 15);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(70, 19);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Product:";
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.Location = new Point(96, 15);
            cmbProduct.Margin = new Padding(3, 2, 3, 2);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(263, 23);
            cmbProduct.TabIndex = 1;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // lblProductPrice
            // 
            lblProductPrice.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblProductPrice.ForeColor = SystemColors.Window;
            lblProductPrice.Location = new Point(18, 45);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(131, 19);
            lblProductPrice.TabIndex = 2;
            lblProductPrice.Text = "Price: $0.00";
            // 
            // lblProductStock
            // 
            lblProductStock.ForeColor = SystemColors.Window;
            lblProductStock.Location = new Point(18, 68);
            lblProductStock.Name = "lblProductStock";
            lblProductStock.Size = new Size(131, 19);
            lblProductStock.TabIndex = 3;
            lblProductStock.Text = "Stock: 0";
            // 
            // lblQuantity
            // 
            lblQuantity.ForeColor = SystemColors.Window;
            lblQuantity.Location = new Point(18, 98);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(70, 19);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(96, 98);
            nudQuantity.Margin = new Padding(3, 2, 3, 2);
            nudQuantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(88, 23);
            nudQuantity.TabIndex = 5;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = SystemColors.Window;
            btnAddItem.Location = new Point(192, 98);
            btnAddItem.Margin = new Padding(3, 2, 3, 2);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(105, 22);
            btnAddItem.TabIndex = 6;
            btnAddItem.Text = "Add to Sale";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvSaleItems
            // 
            dgvSaleItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaleItems.Location = new Point(18, 135);
            dgvSaleItems.Margin = new Padding(3, 2, 3, 2);
            dgvSaleItems.Name = "dgvSaleItems";
            dgvSaleItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaleItems.Size = new Size(394, 150);
            dgvSaleItems.TabIndex = 7;
            // 
            // lblCustomerName
            // 
            lblCustomerName.ForeColor = SystemColors.Window;
            lblCustomerName.Location = new Point(18, 15);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(105, 19);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(131, 15);
            txtCustomerName.Margin = new Padding(3, 2, 3, 2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(176, 23);
            txtCustomerName.TabIndex = 1;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.ForeColor = SystemColors.Window;
            lblPaymentMethod.Location = new Point(18, 45);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(105, 19);
            lblPaymentMethod.TabIndex = 2;
            lblPaymentMethod.Text = "Payment Method:";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Debit Card", "Check" });
            cmbPaymentMethod.Location = new Point(131, 45);
            cmbPaymentMethod.Margin = new Padding(3, 2, 3, 2);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(176, 23);
            cmbPaymentMethod.TabIndex = 3;
            // 
            // lblNotes
            // 
            lblNotes.ForeColor = SystemColors.Window;
            lblNotes.Location = new Point(18, 75);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(105, 19);
            lblNotes.TabIndex = 4;
            lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(131, 75);
            txtNotes.Margin = new Padding(3, 2, 3, 2);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(263, 76);
            txtNotes.TabIndex = 5;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(18, 165);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(175, 22);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total: $0.00";
            // 
            // btnCompleteSale
            // 
            btnCompleteSale.BackColor = Color.Green;
            btnCompleteSale.FlatAppearance.BorderSize = 0;
            btnCompleteSale.ForeColor = Color.White;
            btnCompleteSale.Location = new Point(18, 202);
            btnCompleteSale.Margin = new Padding(3, 2, 3, 2);
            btnCompleteSale.Name = "btnCompleteSale";
            btnCompleteSale.Size = new Size(105, 30);
            btnCompleteSale.TabIndex = 7;
            btnCompleteSale.Text = "Complete Order";
            btnCompleteSale.UseVisualStyleBackColor = false;
            btnCompleteSale.Click += btnCompleteSale_Click;
            // 
            // btnCancelSale
            // 
            btnCancelSale.BackColor = Color.Red;
            btnCancelSale.FlatAppearance.BorderColor = Color.Red;
            btnCancelSale.FlatAppearance.BorderSize = 0;
            btnCancelSale.ForeColor = Color.White;
            btnCancelSale.Location = new Point(131, 202);
            btnCancelSale.Margin = new Padding(3, 2, 3, 2);
            btnCancelSale.Name = "btnCancelSale";
            btnCancelSale.Size = new Size(105, 30);
            btnCancelSale.TabIndex = 8;
            btnCancelSale.Text = "Cancel Order";
            btnCancelSale.UseVisualStyleBackColor = false;
            btnCancelSale.Click += btnCancelSale_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = SystemColors.Window;
            btnRemoveItem.Location = new Point(18, 300);
            btnRemoveItem.Margin = new Padding(3, 2, 3, 2);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(105, 22);
            btnRemoveItem.TabIndex = 8;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Window;
            btnClose.Location = new Point(245, 202);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(70, 30);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelSaleItems
            // 
            panelSaleItems.BackColor = Color.FromArgb(30, 41, 59);
            panelSaleItems.Controls.Add(lblProduct);
            panelSaleItems.Controls.Add(cmbProduct);
            panelSaleItems.Controls.Add(lblProductPrice);
            panelSaleItems.Controls.Add(lblProductStock);
            panelSaleItems.Controls.Add(lblQuantity);
            panelSaleItems.Controls.Add(nudQuantity);
            panelSaleItems.Controls.Add(btnAddItem);
            panelSaleItems.Controls.Add(dgvSaleItems);
            panelSaleItems.Controls.Add(btnRemoveItem);
            panelSaleItems.Dock = DockStyle.Left;
            panelSaleItems.Location = new Point(0, 0);
            panelSaleItems.Margin = new Padding(3, 2, 3, 2);
            panelSaleItems.Name = "panelSaleItems";
            panelSaleItems.Padding = new Padding(18, 15, 18, 15);
            panelSaleItems.Size = new Size(438, 525);
            panelSaleItems.TabIndex = 1;
            // 
            // panelSaleDetails
            // 
            panelSaleDetails.BackColor = Color.FromArgb(51, 65, 85);
            panelSaleDetails.Controls.Add(lblCustomerName);
            panelSaleDetails.Controls.Add(txtCustomerName);
            panelSaleDetails.Controls.Add(lblPaymentMethod);
            panelSaleDetails.Controls.Add(cmbPaymentMethod);
            panelSaleDetails.Controls.Add(lblNotes);
            panelSaleDetails.Controls.Add(txtNotes);
            panelSaleDetails.Controls.Add(lblTotal);
            panelSaleDetails.Controls.Add(btnCompleteSale);
            panelSaleDetails.Controls.Add(btnCancelSale);
            panelSaleDetails.Controls.Add(btnClose);
            panelSaleDetails.Dock = DockStyle.Fill;
            panelSaleDetails.Location = new Point(438, 0);
            panelSaleDetails.Margin = new Padding(3, 2, 3, 2);
            panelSaleDetails.Name = "panelSaleDetails";
            panelSaleDetails.Padding = new Padding(18, 15, 18, 15);
            panelSaleDetails.Size = new Size(437, 525);
            panelSaleDetails.TabIndex = 0;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 525);
            Controls.Add(panelSaleDetails);
            Controls.Add(panelSaleItems);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleItems).EndInit();
            panelSaleItems.ResumeLayout(false);
            panelSaleDetails.ResumeLayout(false);
            panelSaleDetails.PerformLayout();
            ResumeLayout(false);
        }
    }
}
