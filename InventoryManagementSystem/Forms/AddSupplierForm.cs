using InventoryManagement.Services;
using InventoryManagement.Models;
using InventoryManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem
{
    public partial class AddSupplierForm : Form
    {
        private readonly SupplierService _supplierService;
        private readonly AppDbContext _context;

        // Form controls
        private TextBox txtName;
        private TextBox txtContactPerson;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPostalCode;
        private NumericUpDown nudLeadTime;
        private TextBox txtPaymentTerms;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;

        public AddSupplierForm(SupplierService supplierService)
        {
            _supplierService = supplierService;
            _context = new AppDbContext();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtName = new TextBox();
            this.txtContactPerson = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPhone = new TextBox();
            this.txtAddress = new TextBox();
            this.txtCity = new TextBox();
            this.txtCountry = new TextBox();
            this.txtPostalCode = new TextBox();
            this.nudLeadTime = new NumericUpDown();
            this.txtPaymentTerms = new TextBox();
            this.cmbStatus = new ComboBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.nudLeadTime)).BeginInit();
            this.SuspendLayout();

            // Form setup
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Text = "Add New Supplier";
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);

            // Title
            var lblTitle = new Label
            {
                Text = "➕ Add New Supplier",
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(460, 30),
                Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };

            // Form fields
            int yPos = 70;
            int fieldHeight = 35;
            int spacing = 45;

            // Supplier Name
            var lblName = CreateLabel("Supplier Name:", yPos);
            this.txtName.Location = new System.Drawing.Point(20, yPos + 20);
            this.txtName.Size = new System.Drawing.Size(460, fieldHeight);
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = BorderStyle.FixedSingle;
            yPos += spacing;

            // Contact Person
            var lblContact = CreateLabel("Contact Person:", yPos);
            this.txtContactPerson.Location = new System.Drawing.Point(20, yPos + 20);
            this.txtContactPerson.Size = new System.Drawing.Size(460, fieldHeight);
            this.txtContactPerson.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtContactPerson.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtContactPerson.ForeColor = System.Drawing.Color.White;
            this.txtContactPerson.BorderStyle = BorderStyle.FixedSingle;
            yPos += spacing;

            // Email
            var lblEmail = CreateLabel("Email:", yPos);
            this.txtEmail.Location = new System.Drawing.Point(20, yPos + 20);
            this.txtEmail.Size = new System.Drawing.Size(460, fieldHeight);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = BorderStyle.FixedSingle;
            yPos += spacing;

            // Phone
            var lblPhone = CreateLabel("Phone:", yPos);
            this.txtPhone.Location = new System.Drawing.Point(20, yPos + 20);
            this.txtPhone.Size = new System.Drawing.Size(460, fieldHeight);
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = BorderStyle.FixedSingle;
            yPos += spacing;

            // Address
            var lblAddress = CreateLabel("Address:", yPos);
            this.txtAddress.Location = new System.Drawing.Point(20, yPos + 20);
            this.txtAddress.Size = new System.Drawing.Size(460, fieldHeight);
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = BorderStyle.FixedSingle;
            yPos += spacing;

            // City
            var lblCity = CreateLabel("City:", yPos);
            this.txtCity.Location = new System.Drawing.Point(20, yPos + 20);
            this.txtCity.Size = new System.Drawing.Size(220, fieldHeight);
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.BorderStyle = BorderStyle.FixedSingle;

            // Country
            var lblCountry = CreateLabel("Country:", yPos + 120);
            this.txtCountry.Location = new System.Drawing.Point(260, yPos + 20);
            this.txtCountry.Size = new System.Drawing.Size(220, fieldHeight);
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCountry.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtCountry.ForeColor = System.Drawing.Color.White;
            this.txtCountry.BorderStyle = BorderStyle.FixedSingle;
            yPos += spacing;

            // Lead Time
            var lblLeadTime = CreateLabel("Lead Time (Days):", yPos);
            this.nudLeadTime.Location = new System.Drawing.Point(20, yPos + 20);
            this.nudLeadTime.Size = new System.Drawing.Size(220, fieldHeight);
            this.nudLeadTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nudLeadTime.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.nudLeadTime.ForeColor = System.Drawing.Color.White;
            this.nudLeadTime.Minimum = 1;
            this.nudLeadTime.Maximum = 365;
            this.nudLeadTime.Value = 7;

            // Payment Terms
            var lblPaymentTerms = CreateLabel("Payment Terms:", yPos + 120);
            this.txtPaymentTerms.Location = new System.Drawing.Point(260, yPos + 20);
            this.txtPaymentTerms.Size = new System.Drawing.Size(220, fieldHeight);
            this.txtPaymentTerms.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPaymentTerms.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtPaymentTerms.ForeColor = System.Drawing.Color.White;
            this.txtPaymentTerms.BorderStyle = BorderStyle.FixedSingle;
            this.txtPaymentTerms.Text = "Net 30";
            yPos += spacing;

            // Status
            var lblStatus = CreateLabel("Status:", yPos);
            this.cmbStatus.Location = new System.Drawing.Point(20, yPos + 20);
            this.cmbStatus.Size = new System.Drawing.Size(220, fieldHeight);
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.cmbStatus.ForeColor = System.Drawing.Color.White;
            this.cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] { "Active", "Inactive", "Pending" });
            this.cmbStatus.SelectedIndex = 0;

            // Buttons
            this.btnSave.Text = "Save Supplier";
            this.btnSave.Location = new System.Drawing.Point(20, yPos + 80);
            this.btnSave.Size = new System.Drawing.Size(220, 40);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Cursor = Cursors.Hand;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(260, yPos + 80);
            this.btnCancel.Size = new System.Drawing.Size(220, 40);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Cursor = Cursors.Hand;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // Add controls to form
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(lblContact);
            this.Controls.Add(this.txtContactPerson);
            this.Controls.Add(lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(lblCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(lblLeadTime);
            this.Controls.Add(this.nudLeadTime);
            this.Controls.Add(lblPaymentTerms);
            this.Controls.Add(this.txtPaymentTerms);
            this.Controls.Add(lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            ((System.ComponentModel.ISupportInitialize)(this.nudLeadTime)).EndInit();
            this.ResumeLayout(false);
        }

        private Label CreateLabel(string text, int yPos)
        {
            return new Label
            {
                Text = text,
                Location = new System.Drawing.Point(20, yPos),
                Size = new System.Drawing.Size(200, 20),
                Font = new System.Drawing.Font("Segoe UI", 10F),
                ForeColor = System.Drawing.Color.FromArgb(148, 163, 184)
            };
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm())
                    return;

                var newSupplier = new Supplier
                {
                    Name = txtName.Text.Trim(),
                    ContactPerson = txtContactPerson.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    Country = txtCountry.Text.Trim(),
                    PostalCode = txtPostalCode.Text.Trim(),
                    AverageLeadTimeDays = (int)nudLeadTime.Value,
                    PaymentTerms = txtPaymentTerms.Text.Trim(),
                    IsActive = cmbStatus.SelectedItem?.ToString() == "Active"
                };

                await _supplierService.AddSupplierAsync(newSupplier);
                
                MessageBox.Show("Supplier added successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding supplier: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Supplier name is required.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContactPerson.Text))
            {
                MessageBox.Show("Contact person is required.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactPerson.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
