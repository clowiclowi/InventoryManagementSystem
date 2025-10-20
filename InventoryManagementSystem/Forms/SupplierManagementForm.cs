using InventoryManagement.Services;
using InventoryManagement.Models;
using InventoryManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem
{
    public partial class SupplierManagementForm : Form
    {
        private readonly SupplierService _supplierService;
        private readonly AppDbContext _context;

        public SupplierManagementForm(SupplierService supplierService)
        {
            InitializeComponent();
            _supplierService = supplierService;
            _context = new AppDbContext();
            LoadSuppliers();
        }

        private async void LoadSuppliers()
        {
            try
            {
                var suppliers = await _supplierService.GetSupplierSummaryAsync();
                dgvSuppliers.DataSource = suppliers;
                
                // Configure columns
                if (dgvSuppliers.Columns.Count > 0)
                {
                    dgvSuppliers.Columns["Id"].Visible = false;
                    dgvSuppliers.Columns["Name"].HeaderText = "Supplier Name";
                    dgvSuppliers.Columns["ContactPerson"].HeaderText = "Contact Person";
                    dgvSuppliers.Columns["Email"].HeaderText = "Email";
                    dgvSuppliers.Columns["Phone"].HeaderText = "Phone";
                    dgvSuppliers.Columns["LeadTime"].HeaderText = "Lead Time";
                    dgvSuppliers.Columns["PaymentTerms"].HeaderText = "Payment Terms";
                    dgvSuppliers.Columns["LinkedSKUs"].HeaderText = "Linked SKUs";
                    dgvSuppliers.Columns["Status"].HeaderText = "Status";
                    dgvSuppliers.Columns["City"].HeaderText = "City";
                    dgvSuppliers.Columns["Country"].HeaderText = "Country";
                    dgvSuppliers.Columns["LastOrder"].HeaderText = "Last Order";
                    dgvSuppliers.Columns["TotalValue"].HeaderText = "Total Value";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            ShowAddSupplierForm();
        }

        private void ShowAddSupplierForm()
        {
            var addSupplierForm = new AddSupplierForm(_supplierService);
            if (addSupplierForm.ShowDialog() == DialogResult.OK)
            {
                LoadSuppliers(); // Refresh the supplier list
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                SearchSuppliers(txtSearch.Text);
            }
            else
            {
                LoadSuppliers();
            }
        }

        private async void SearchSuppliers(string searchTerm)
        {
            try
            {
                var suppliers = await _supplierService.SearchSuppliersAsync(searchTerm);
                var supplierData = suppliers.Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.ContactPerson,
                    s.Email,
                    s.Phone,
                    LeadTime = $"{s.LeadTimeDays} days",
                    s.PaymentTerms,
                    LinkedSKUs = s.LinkedSKUsCount,
                    Status = s.IsActive ? "Active" : "Inactive",
                    s.City,
                    s.Country,
                    LastOrder = s.LastOrderDate?.ToString("MM/dd/yyyy") ?? "Never",
                    TotalValue = s.TotalOrderValue.ToString("C")
                }).ToList();

                dgvSuppliers.DataSource = supplierData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching suppliers: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

