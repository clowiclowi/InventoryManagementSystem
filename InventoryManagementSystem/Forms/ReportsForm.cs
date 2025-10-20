using InventoryManagement.Services;
using InventoryManagement.Models;
using InventoryManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem
{
    public partial class ReportsForm : Form
    {
        private readonly ReportService _reportService;
        private readonly AppDbContext _context;

        public ReportsForm(ReportService reportService)
        {
            InitializeComponent();
            _reportService = reportService;
            _context = new AppDbContext();
            LoadReportTypes();
        }

        private void LoadReportTypes()
        {
            cmbReportType.Items.AddRange(new object[]
            {
                "Sales Report",
                "Inventory Report",
                "Low Stock Report"
            });
            cmbReportType.SelectedIndex = 0;

            // Set default dates to today for daily sales report
            SetTodayAsDefault();
        }

        private void SetTodayAsDefault()
        {
            var today = DateTime.Today;
            dtpStartDate.Value = today;
            dtpEndDate.Value = today;
        }

        private async void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmbReportType.SelectedIndex)
                {
                    case 0: // Sales Report
                        await GenerateSalesReport();
                        break;
                    case 1: // Inventory Report
                        await GenerateInventoryReport();
                        break;
                    case 2: // Low Stock Report
                        await GenerateLowStockReport();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GenerateSalesReport()
        {
            var startDate = dtpStartDate.Value.Date;
            var endDate = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1); // End of day

            var report = await _reportService.GenerateSalesReportAsync(startDate, endDate);

            // Check if it's a single day report
            bool isSingleDay = startDate.Date == endDate.Date;
            string dateRangeText = isSingleDay ?
                $"Today ({startDate:MM/dd/yyyy})" :
                $"{startDate:MM/dd/yyyy} - {endDate:MM/dd/yyyy}";

            lblSummary.Text = $"Sales Report - {dateRangeText}\n" +
                              $"Total Sales: ${report.TotalSales:N2}\n" +
                              $"Transactions: {report.TransactionCount}\n" +
                              $"Average Transaction: ${report.AverageTransactionValue:N2}";

            // Show top products for the period
            dgvResults.DataSource = report.TopProducts;

            // If it's today and no sales, show a helpful message
            if (isSingleDay && report.TransactionCount == 0)
            {
                MessageBox.Show("No sales recorded for today yet.\n\n" +
                               "Sales will appear here once transactions are completed.",
                               "No Sales Today", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task GenerateInventoryReport()
        {
            var report = await _reportService.GenerateInventoryReportAsync();

            lblSummary.Text = $"Inventory Report\n" +
                              $"Total Value: ${report.TotalInventoryValue:N2}\n" +
                              $"Total Products: {report.TotalProducts}\n" +
                              $"Low Stock Items: {report.LowStockCount}";

            dgvResults.DataSource = report.LowStockProducts.Select(p => new
            {
                p.Name,
                p.SKU,
                Category = p.Category?.Name ?? "N/A",
                p.CurrentStock,
                p.ReorderLevel,
                Value = p.CalculateValue(),
                NeedsReorder = p.NeedsReorder()
            }).ToList();
        }

        private async Task GenerateLowStockReport()
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .ToListAsync();

            var lowStockProducts = products
                .Where(p => p.NeedsReorder()) // Uses polymorphic method on client side
                .OrderBy(p => p.CurrentStock)
                .ToList();

            lblSummary.Text = $"Low Stock Report\n" +
                              $"Items needing reorder: {lowStockProducts.Count}\n" +
                              $"Total value at risk: ${lowStockProducts.Sum(p => p.CalculateValue()):N2}";

            dgvResults.DataSource = lowStockProducts.Select(p => new
            {
                p.Name,
                p.SKU,
                Category = p.Category?.Name ?? "N/A",
                Supplier = p.Supplier?.Name ?? "N/A",
                p.CurrentStock,
                p.ReorderLevel,
                Value = p.CalculateValue(),
                DaysUntilReorder = p.CurrentStock <= 0 ? "OUT OF STOCK" :
                    $"{(p.ReorderLevel - p.CurrentStock)} units short"
            }).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable/disable date controls based on report type
            bool needsDateRange = cmbReportType.SelectedIndex == 0; // Sales Report
            dtpStartDate.Enabled = needsDateRange;
            dtpEndDate.Enabled = needsDateRange;
            lblStartDate.Enabled = needsDateRange;
            lblEndDate.Enabled = needsDateRange;

            // Show/hide Today button for sales reports
            btnToday.Visible = needsDateRange;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            SetTodayAsDefault();
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

        private void panelResults_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
