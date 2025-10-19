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
        private Supplier? _selectedSupplier;

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

        private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                var selectedRow = dgvSuppliers.SelectedRows[0];
                if (selectedRow.Cells["Id"].Value != null)
                {
                    var supplierId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    LoadSupplierDetails(supplierId);
                }
            }
        }

        private async void LoadSupplierDetails(int supplierId)
        {
            try
            {
                _selectedSupplier = await _supplierService.GetSupplierByIdAsync(supplierId);
                if (_selectedSupplier != null)
                {
                    ShowSupplierDrawer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading supplier details: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowSupplierDrawer()
        {
            if (_selectedSupplier == null) return;

            // Create supplier drawer content
            var drawerContent = CreateSupplierDrawerContent();
            panelSupplierDrawer.Controls.Clear();
            panelSupplierDrawer.Controls.Add(drawerContent);
            panelSupplierDrawer.Visible = true;
        }

        private Control CreateSupplierDrawerContent()
        {
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = System.Drawing.Color.FromArgb(30, 41, 59),
                Padding = new Padding(20)
            };

            // Create tab control
            var tabControl = new TabControl
            {
                Dock = DockStyle.Fill,
                Font = new System.Drawing.Font("Segoe UI", 10F),
                BackColor = System.Drawing.Color.FromArgb(30, 41, 59),
                ForeColor = System.Drawing.Color.White
            };

            // Overview Tab
            var overviewTab = new TabPage("Overview");
            overviewTab.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            overviewTab.Controls.Add(CreateOverviewContent());
            tabControl.TabPages.Add(overviewTab);

            // Products Tab
            var productsTab = new TabPage("Products");
            productsTab.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            productsTab.Controls.Add(CreateProductsContent());
            tabControl.TabPages.Add(productsTab);

            // Purchase Orders Tab
            var ordersTab = new TabPage("Purchase Orders");
            ordersTab.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            ordersTab.Controls.Add(CreatePurchaseOrdersContent());
            tabControl.TabPages.Add(ordersTab);

            // Performance Tab
            var performanceTab = new TabPage("Performance");
            performanceTab.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            performanceTab.Controls.Add(CreatePerformanceContent());
            tabControl.TabPages.Add(performanceTab);

            panel.Controls.Add(tabControl);
            return panel;
        }

        private Control CreateOverviewContent()
        {
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = System.Drawing.Color.FromArgb(30, 41, 59),
                Padding = new Padding(20)
            };

            var y = 20;
            var labelHeight = 25;
            var textHeight = 30;
            var spacing = 40;

            // Supplier Name
            var lblName = new Label
            {
                Text = "Supplier Name:",
                Location = new System.Drawing.Point(20, y),
                Size = new System.Drawing.Size(120, labelHeight),
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White
            };
            panel.Controls.Add(lblName);

            var txtName = new TextBox
            {
                Text = _selectedSupplier?.Name ?? "",
                Location = new System.Drawing.Point(150, y),
                Size = new System.Drawing.Size(200, textHeight),
                BackColor = System.Drawing.Color.FromArgb(51, 65, 85),
                ForeColor = System.Drawing.Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                ReadOnly = true
            };
            panel.Controls.Add(txtName);

            y += spacing;

            // Contact Person
            var lblContact = new Label
            {
                Text = "Contact Person:",
                Location = new System.Drawing.Point(20, y),
                Size = new System.Drawing.Size(120, labelHeight),
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White
            };
            panel.Controls.Add(lblContact);

            var txtContact = new TextBox
            {
                Text = _selectedSupplier?.ContactPerson ?? "",
                Location = new System.Drawing.Point(150, y),
                Size = new System.Drawing.Size(200, textHeight),
                BackColor = System.Drawing.Color.FromArgb(51, 65, 85),
                ForeColor = System.Drawing.Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                ReadOnly = true
            };
            panel.Controls.Add(txtContact);

            y += spacing;

            // Email
            var lblEmail = new Label
            {
                Text = "Email:",
                Location = new System.Drawing.Point(20, y),
                Size = new System.Drawing.Size(120, labelHeight),
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White
            };
            panel.Controls.Add(lblEmail);

            var txtEmail = new TextBox
            {
                Text = _selectedSupplier?.Email ?? "",
                Location = new System.Drawing.Point(150, y),
                Size = new System.Drawing.Size(200, textHeight),
                BackColor = System.Drawing.Color.FromArgb(51, 65, 85),
                ForeColor = System.Drawing.Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                ReadOnly = true
            };
            panel.Controls.Add(txtEmail);

            y += spacing;

            // Phone
            var lblPhone = new Label
            {
                Text = "Phone:",
                Location = new System.Drawing.Point(20, y),
                Size = new System.Drawing.Size(120, labelHeight),
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White
            };
            panel.Controls.Add(lblPhone);

            var txtPhone = new TextBox
            {
                Text = _selectedSupplier?.Phone ?? "",
                Location = new System.Drawing.Point(150, y),
                Size = new System.Drawing.Size(200, textHeight),
                BackColor = System.Drawing.Color.FromArgb(51, 65, 85),
                ForeColor = System.Drawing.Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                ReadOnly = true
            };
            panel.Controls.Add(txtPhone);

            y += spacing;

            // Address
            var lblAddress = new Label
            {
                Text = "Address:",
                Location = new System.Drawing.Point(20, y),
                Size = new System.Drawing.Size(120, labelHeight),
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White
            };
            panel.Controls.Add(lblAddress);

            var txtAddress = new TextBox
            {
                Text = _selectedSupplier?.FullAddress ?? "",
                Location = new System.Drawing.Point(150, y),
                Size = new System.Drawing.Size(200, textHeight),
                BackColor = System.Drawing.Color.FromArgb(51, 65, 85),
                ForeColor = System.Drawing.Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                ReadOnly = true
            };
            panel.Controls.Add(txtAddress);

            y += spacing;

            // Business Number
            var lblBusinessNumber = new Label
            {
                Text = "Business Number:",
                Location = new System.Drawing.Point(20, y),
                Size = new System.Drawing.Size(120, labelHeight),
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White
            };
            panel.Controls.Add(lblBusinessNumber);

            var txtBusinessNumber = new TextBox
            {
                Text = _selectedSupplier?.BusinessNumber ?? "",
                Location = new System.Drawing.Point(150, y),
                Size = new System.Drawing.Size(200, textHeight),
                BackColor = System.Drawing.Color.FromArgb(51, 65, 85),
                ForeColor = System.Drawing.Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                ReadOnly = true
            };
            panel.Controls.Add(txtBusinessNumber);

            y += spacing;

            // Notes
            var lblNotes = new Label
            {
                Text = "Notes:",
                Location = new System.Drawing.Point(20, y),
                Size = new System.Drawing.Size(120, labelHeight),
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White
            };
            panel.Controls.Add(lblNotes);

            var txtNotes = new TextBox
            {
                Text = _selectedSupplier?.Notes ?? "",
                Location = new System.Drawing.Point(150, y),
                Size = new System.Drawing.Size(200, 60),
                BackColor = System.Drawing.Color.FromArgb(51, 65, 85),
                ForeColor = System.Drawing.Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                ReadOnly = true,
                Multiline = true
            };
            panel.Controls.Add(txtNotes);

            return panel;
        }

        private Control CreateProductsContent()
        {
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = System.Drawing.Color.FromArgb(30, 41, 59),
                Padding = new Padding(20)
            };

            var dgvProducts = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59),
                BorderStyle = BorderStyle.None,
                GridColor = System.Drawing.Color.FromArgb(51, 65, 85),
                Font = new System.Drawing.Font("Segoe UI", 9F),
                ForeColor = System.Drawing.Color.White,
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = System.Drawing.Color.FromArgb(51, 65, 85),
                    ForeColor = System.Drawing.Color.White,
                    Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
                },
                RowsDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = System.Drawing.Color.FromArgb(30, 41, 59),
                    ForeColor = System.Drawing.Color.White
                },
                AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = System.Drawing.Color.FromArgb(51, 65, 85),
                    ForeColor = System.Drawing.Color.White
                }
            };

            // Load products data
            LoadSupplierProducts(dgvProducts);

            panel.Controls.Add(dgvProducts);
            return panel;
        }

        private async void LoadSupplierProducts(DataGridView dgv)
        {
            if (_selectedSupplier == null) return;

            try
            {
                var products = await _supplierService.GetSupplierProductsAsync(_selectedSupplier.Id);
                dgv.DataSource = products;

                if (dgv.Columns.Count > 0)
                {
                    dgv.Columns["Id"].Visible = false;
                    dgv.Columns["Name"].HeaderText = "Product Name";
                    dgv.Columns["SKU"].HeaderText = "SKU";
                    dgv.Columns["UnitCost"].HeaderText = "Last Purchase Price";
                    dgv.Columns["UnitPrice"].HeaderText = "Selling Price";
                    dgv.Columns["CurrentStock"].HeaderText = "Current Stock";
                    dgv.Columns["ReorderLevel"].HeaderText = "Reorder Level";
                    dgv.Columns["Category"].HeaderText = "Category";
                    dgv.Columns["MOQ"].HeaderText = "MOQ";
                    dgv.Columns["NeedsReorder"].HeaderText = "Needs Reorder";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading supplier products: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Control CreatePurchaseOrdersContent()
        {
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = System.Drawing.Color.FromArgb(30, 41, 59),
                Padding = new Padding(20)
            };

            var dgvOrders = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59),
                BorderStyle = BorderStyle.None,
                GridColor = System.Drawing.Color.FromArgb(51, 65, 85),
                Font = new System.Drawing.Font("Segoe UI", 9F),
                ForeColor = System.Drawing.Color.White,
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = System.Drawing.Color.FromArgb(51, 65, 85),
                    ForeColor = System.Drawing.Color.White,
                    Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
                },
                RowsDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = System.Drawing.Color.FromArgb(30, 41, 59),
                    ForeColor = System.Drawing.Color.White
                },
                AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = System.Drawing.Color.FromArgb(51, 65, 85),
                    ForeColor = System.Drawing.Color.White
                }
            };

            // Load purchase orders data
            LoadSupplierPurchaseOrders(dgvOrders);

            panel.Controls.Add(dgvOrders);
            return panel;
        }

        private async void LoadSupplierPurchaseOrders(DataGridView dgv)
        {
            if (_selectedSupplier == null) return;

            try
            {
                var orders = await _supplierService.GetSupplierPurchaseOrdersAsync(_selectedSupplier.Id);
                var orderData = orders.Select(po => new
                {
                    po.Id,
                    po.PONumber,
                    OrderDate = po.OrderDate.ToString("MM/dd/yyyy"),
                    ExpectedDelivery = po.ExpectedDeliveryDate?.ToString("MM/dd/yyyy") ?? "TBD",
                    ActualDelivery = po.ActualDeliveryDate?.ToString("MM/dd/yyyy") ?? "Pending",
                    po.TotalAmount,
                    po.Status,
                    ItemsCount = po.Items.Count,
                    po.Notes
                }).ToList();

                dgv.DataSource = orderData;

                if (dgv.Columns.Count > 0)
                {
                    dgv.Columns["Id"].Visible = false;
                    dgv.Columns["PONumber"].HeaderText = "PO Number";
                    dgv.Columns["OrderDate"].HeaderText = "Order Date";
                    dgv.Columns["ExpectedDelivery"].HeaderText = "Expected Delivery";
                    dgv.Columns["ActualDelivery"].HeaderText = "Actual Delivery";
                    dgv.Columns["TotalAmount"].HeaderText = "Total Amount";
                    dgv.Columns["Status"].HeaderText = "Status";
                    dgv.Columns["ItemsCount"].HeaderText = "Items Count";
                    dgv.Columns["Notes"].HeaderText = "Notes";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading purchase orders: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Control CreatePerformanceContent()
        {
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = System.Drawing.Color.FromArgb(30, 41, 59),
                Padding = new Padding(20)
            };

            var y = 20;
            var labelHeight = 25;
            var valueHeight = 30;
            var spacing = 50;

            if (_selectedSupplier != null)
            {
                // On-Time Delivery
                var lblOnTime = new Label
                {
                    Text = "On-Time Delivery:",
                    Location = new System.Drawing.Point(20, y),
                    Size = new System.Drawing.Size(150, labelHeight),
                    Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.White
                };
                panel.Controls.Add(lblOnTime);

                var lblOnTimeValue = new Label
                {
                    Text = $"{_selectedSupplier.OnTimeDeliveryPercentage:F1}%",
                    Location = new System.Drawing.Point(180, y),
                    Size = new System.Drawing.Size(100, valueHeight),
                    Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.FromArgb(34, 197, 94)
                };
                panel.Controls.Add(lblOnTimeValue);

                y += spacing;

                // Average Lead Time
                var lblLeadTime = new Label
                {
                    Text = "Average Lead Time:",
                    Location = new System.Drawing.Point(20, y),
                    Size = new System.Drawing.Size(150, labelHeight),
                    Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.White
                };
                panel.Controls.Add(lblLeadTime);

                var lblLeadTimeValue = new Label
                {
                    Text = $"{_selectedSupplier.AverageLeadTimeDays:F1} days",
                    Location = new System.Drawing.Point(180, y),
                    Size = new System.Drawing.Size(100, valueHeight),
                    Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.FromArgb(59, 130, 246)
                };
                panel.Controls.Add(lblLeadTimeValue);

                y += spacing;

                // Return Rate
                var lblReturnRate = new Label
                {
                    Text = "Return Rate:",
                    Location = new System.Drawing.Point(20, y),
                    Size = new System.Drawing.Size(150, labelHeight),
                    Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.White
                };
                panel.Controls.Add(lblReturnRate);

                var lblReturnRateValue = new Label
                {
                    Text = $"{_selectedSupplier.ReturnRatePercentage:F1}%",
                    Location = new System.Drawing.Point(180, y),
                    Size = new System.Drawing.Size(100, valueHeight),
                    Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.FromArgb(239, 68, 68)
                };
                panel.Controls.Add(lblReturnRateValue);

                y += spacing;

                // Total Orders
                var lblTotalOrders = new Label
                {
                    Text = "Total Orders:",
                    Location = new System.Drawing.Point(20, y),
                    Size = new System.Drawing.Size(150, labelHeight),
                    Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.White
                };
                panel.Controls.Add(lblTotalOrders);

                var lblTotalOrdersValue = new Label
                {
                    Text = _selectedSupplier.TotalOrders.ToString(),
                    Location = new System.Drawing.Point(180, y),
                    Size = new System.Drawing.Size(100, valueHeight),
                    Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.FromArgb(168, 85, 247)
                };
                panel.Controls.Add(lblTotalOrdersValue);

                y += spacing;

                // Total Order Value
                var lblTotalValue = new Label
                {
                    Text = "Total Order Value:",
                    Location = new System.Drawing.Point(20, y),
                    Size = new System.Drawing.Size(150, labelHeight),
                    Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.White
                };
                panel.Controls.Add(lblTotalValue);

                var lblTotalValueValue = new Label
                {
                    Text = _selectedSupplier.TotalOrderValue.ToString("C"),
                    Location = new System.Drawing.Point(180, y),
                    Size = new System.Drawing.Size(150, valueHeight),
                    Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.FromArgb(245, 158, 11)
                };
                panel.Controls.Add(lblTotalValueValue);
            }

            return panel;
        }




        private void btnCloseDrawer_Click(object sender, EventArgs e)
        {
            panelSupplierDrawer.Visible = false;
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

