using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Services
{
    public class ReportService
    {
        private readonly AppDbContext _context;

        public ReportService(AppDbContext context)
        {
            _context = context;
        }

        public class SalesReportData
        {
            public decimal TotalSales { get; set; }
            public int TransactionCount { get; set; }
            public decimal AverageTransactionValue { get; set; }
            public List<dynamic> TopProducts { get; set; } = new();
            public List<dynamic> DailySales { get; set; } = new();
        }

        public class InventoryReportData
        {
            public decimal TotalInventoryValue { get; set; }
            public int TotalProducts { get; set; }
            public int LowStockCount { get; set; }
            public List<Product> LowStockProducts { get; set; } = new();
            public Dictionary<string, decimal> InventoryByCategory { get; set; } = new();
        }

        public async Task<SalesReportData> GenerateSalesReportAsync(DateTime startDate, DateTime endDate)
        {
            var sales = await _context.Sales
                .Where(s => s.SaleDate >= startDate && s.SaleDate <= endDate)
                .ToListAsync();

            var saleItems = await _context.SaleItems
                .Include(si => si.Product)
                .Include(si => si.Sale)
                .Where(si => si.Sale.SaleDate >= startDate && si.Sale.SaleDate <= endDate)
                .ToListAsync();

            var topProducts = saleItems
                .GroupBy(si => si.ProductId)
                .Select(g => new
                {
                    ProductName = g.First().Product.Name,
                    TotalQuantity = g.Sum(si => si.Quantity),
                    TotalRevenue = g.Sum(si => si.Quantity * si.UnitPrice)
                })
                .OrderByDescending(x => x.TotalRevenue)
                .Take(10)
                .ToList();

            var dailySales = sales
                .GroupBy(s => s.SaleDate.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    TotalSales = g.Sum(s => s.TotalAmount),
                    TransactionCount = g.Count()
                })
                .OrderByDescending(x => x.Date)
                .ToList();

            return new SalesReportData
            {
                TotalSales = sales.Sum(s => s.TotalAmount),
                TransactionCount = sales.Count,
                AverageTransactionValue = sales.Count > 0 ? sales.Average(s => s.TotalAmount) : 0,
                TopProducts = topProducts.Cast<object>().ToList(),
                DailySales = dailySales.Cast<object>().ToList()
            };
        }

        public async Task<InventoryReportData> GenerateInventoryReportAsync()
        {
            var allProducts = await _context.Products
                .Include(p => p.Category)
                .ToListAsync();

            var lowStockProducts = allProducts
                .Where(p => p.NeedsReorder()) // Uses polymorphic method on client side
                .OrderBy(p => p.CurrentStock)
                .ToList();

            var inventoryByCategory = allProducts
                .GroupBy(p => p.Category.Name)
                .ToDictionary(
                    g => g.Key,
                    g => g.Sum(p => p.CalculateValue()) // Uses polymorphic method on client side
                );

            return new InventoryReportData
            {
                TotalInventoryValue = allProducts.Sum(p => p.CalculateValue()), // Uses polymorphic method on client side
                TotalProducts = allProducts.Count,
                LowStockCount = lowStockProducts.Count,
                LowStockProducts = lowStockProducts,
                InventoryByCategory = inventoryByCategory
            };
        }

        // CSV Export functionality
        public async Task ExportProductsToCsvAsync(string filename)
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .ToListAsync();

            using var writer = new StreamWriter(filename);
            await writer.WriteLineAsync("Name,SKU,Category,Supplier,Stock,Price,Cost,Value,NeedsReorder");
            
            foreach (var product in products)
            {
                await writer.WriteLineAsync($"{product.Name},{product.SKU},{product.Category.Name}," +
                    $"{product.Supplier.Name},{product.CurrentStock},{product.UnitPrice}," +
                    $"{product.UnitCost},{product.CalculateValue()},{product.NeedsReorder()}");
            }
        }

        public async Task ExportSalesToCsvAsync(string filename, DateTime startDate, DateTime endDate)
        {
            var sales = await _context.Sales
                .Where(s => s.SaleDate >= startDate && s.SaleDate <= endDate)
                .Include(s => s.SaleItems)
                .ThenInclude(si => si.Product)
                .ToListAsync();

            using var writer = new StreamWriter(filename);
            await writer.WriteLineAsync("SaleDate,SaleId,CustomerName,PaymentMethod,TotalAmount,ProductName,Quantity,UnitPrice,TotalPrice");
            
            foreach (var sale in sales)
            {
                foreach (var item in sale.SaleItems)
                {
                    await writer.WriteLineAsync($"{sale.SaleDate:yyyy-MM-dd},{sale.Id},{sale.CustomerName}," +
                        $"{sale.PaymentMethod},{sale.TotalAmount},{item.Product.Name},{item.Quantity}," +
                        $"{item.UnitPrice},{item.Quantity * item.UnitPrice}");
                }
            }
        }
    }
}
