using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Services
{
    public class SupplierService
    {
        private readonly AppDbContext _context;
        private readonly Repository<Supplier> _supplierRepo;

        public SupplierService(AppDbContext context, Repository<Supplier> supplierRepo)
        {
            _context = context;
            _supplierRepo = supplierRepo;
        }

        public async Task<List<Supplier>> GetAllSuppliersAsync()
        {
            return await _context.Suppliers
                .Include(s => s.Products)
                .Include(s => s.PurchaseOrders)
                .OrderBy(s => s.Name)
                .ToListAsync();
        }

        public async Task<List<Supplier>> GetActiveSuppliersAsync()
        {
            return await _context.Suppliers
                .Include(s => s.Products)
                .Where(s => s.IsActive)
                .OrderBy(s => s.Name)
                .ToListAsync();
        }

        public async Task<Supplier?> GetSupplierByIdAsync(int id)
        {
            return await _context.Suppliers
                .Include(s => s.Products)
                .Include(s => s.PurchaseOrders)
                    .ThenInclude(po => po.Items)
                        .ThenInclude(poi => poi.Product)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<Supplier>> SearchSuppliersAsync(string searchTerm)
        {
            var term = searchTerm.ToLower();
            return await _context.Suppliers
                .Include(s => s.Products)
                .Where(s => s.Name.ToLower().Contains(term) ||
                           s.ContactPerson.ToLower().Contains(term) ||
                           s.Email.ToLower().Contains(term) ||
                           s.Phone.Contains(term) ||
                           s.City.ToLower().Contains(term) ||
                           s.Country.ToLower().Contains(term))
                .OrderBy(s => s.Name)
                .ToListAsync();
        }

        public async Task<List<Supplier>> GetSuppliersByLocationAsync(string location)
        {
            var loc = location.ToLower();
            return await _context.Suppliers
                .Include(s => s.Products)
                .Where(s => s.City.ToLower().Contains(loc) ||
                           s.State.ToLower().Contains(loc) ||
                           s.Country.ToLower().Contains(loc))
                .OrderBy(s => s.Name)
                .ToListAsync();
        }

        public async Task<List<Supplier>> GetSuppliersByCategoryAsync(int categoryId)
        {
            return await _context.Suppliers
                .Include(s => s.Products)
                .Where(s => s.Products.Any(p => p.CategoryId == categoryId))
                .OrderBy(s => s.Name)
                .ToListAsync();
        }

        public async Task<Supplier> AddSupplierAsync(Supplier supplier)
        {
            supplier.CreatedDate = DateTime.Now;
            supplier.CreatedBy = "system";
            return await _supplierRepo.AddAsync(supplier);
        }

        public async Task<Supplier> UpdateSupplierAsync(Supplier supplier)
        {
            await _supplierRepo.UpdateAsync(supplier);
            return supplier;
        }

        public async Task DeleteSupplierAsync(int id)
        {
            await _supplierRepo.DeleteAsync(id);
        }

        public async Task<List<object>> GetSupplierPerformanceMetricsAsync()
        {
            var suppliers = await _context.Suppliers
                .Include(s => s.PurchaseOrders)
                .ToListAsync();

            return suppliers.Select(s => new
            {
                s.Id,
                s.Name,
                s.OnTimeDeliveryPercentage,
                s.AverageLeadTimeDays,
                s.ReturnRatePercentage,
                s.TotalOrders,
                s.TotalOrderValue,
                LastOrderDate = s.LastOrderDate?.ToString("MM/dd/yyyy") ?? "Never",
                PerformanceScore = CalculatePerformanceScore(s)
            }).Cast<object>().ToList();
        }

        private decimal CalculatePerformanceScore(Supplier supplier)
        {
            // Simple performance scoring algorithm
            decimal score = 0;
            
            // On-time delivery (40% weight)
            score += (supplier.OnTimeDeliveryPercentage / 100) * 40;
            
            // Lead time performance (30% weight) - shorter is better
            decimal leadTimeScore = Math.Max(0, 30 - (supplier.AverageLeadTimeDays - 7) * 2);
            score += leadTimeScore;
            
            // Return rate (20% weight) - lower is better
            decimal returnScore = Math.Max(0, 20 - supplier.ReturnRatePercentage);
            score += returnScore;
            
            // Order volume (10% weight) - more orders is better
            decimal volumeScore = Math.Min(10, supplier.TotalOrders * 0.1m);
            score += volumeScore;
            
            return Math.Round(score, 1);
        }

        public async Task<List<object>> GetSupplierSummaryAsync()
        {
            var suppliers = await GetAllSuppliersAsync();
            
            return suppliers.Select(s => new
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
            }).Cast<object>().ToList();
        }

        public async Task<List<PurchaseOrder>> GetSupplierPurchaseOrdersAsync(int supplierId)
        {
            return await _context.PurchaseOrders
                .Include(po => po.Items)
                    .ThenInclude(poi => poi.Product)
                .Where(po => po.SupplierId == supplierId)
                .OrderByDescending(po => po.OrderDate)
                .ToListAsync();
        }

        public async Task<List<object>> GetSupplierProductsAsync(int supplierId)
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Where(p => p.SupplierId == supplierId)
                .ToListAsync();

            return products.Select(p => new
            {
                p.Id,
                p.Name,
                p.SKU,
                p.UnitCost,
                p.UnitPrice,
                p.CurrentStock,
                p.ReorderLevel,
                Category = p.Category?.Name ?? "N/A",
                LastPurchasePrice = p.UnitCost, // This would come from purchase history
                MOQ = 1, // Minimum Order Quantity - would be stored in supplier-product relationship
                NeedsReorder = p.NeedsReorder()
            }).Cast<object>().ToList();
        }
    }
}

