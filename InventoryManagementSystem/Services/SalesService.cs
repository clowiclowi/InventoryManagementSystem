using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Services
{
    public class SalesService
    {
        private readonly AppDbContext _context;
        private readonly IRepository<Sale> _saleRepository;
        private readonly IRepository<SaleItem> _saleItemRepository;
        private readonly StockService _stockService;

        public SalesService(AppDbContext context, IRepository<Sale> saleRepository, 
            IRepository<SaleItem> saleItemRepository, StockService stockService)
        {
            _context = context;
            _saleRepository = saleRepository;
            _saleItemRepository = saleItemRepository;
            _stockService = stockService;
        }

        public async Task<Sale> ProcessSaleAsync(Sale sale, List<SaleItem> saleItems)
        {
            // Validate stock availability
            foreach (var item in saleItems)
            {
                var product = await _context.Products.FindAsync(item.ProductId);
                if (product == null)
                    throw new ArgumentException($"Product with ID {item.ProductId} not found");

                if (product.CurrentStock < item.Quantity)
                    throw new InvalidOperationException($"Insufficient stock for {product.Name}. Available: {product.CurrentStock}, Required: {item.Quantity}");
            }

            // Calculate total
            sale.TotalAmount = saleItems.Sum(item => item.TotalPrice);
            sale.SaleDate = DateTime.Now;

            // Save sale
            await _saleRepository.AddAsync(sale);

            // Save sale items and update stock
            foreach (var item in saleItems)
            {
                item.SaleId = sale.Id;
                await _saleItemRepository.AddAsync(item);

                // Update stock
                await _stockService.ProcessStockOutAsync(item.ProductId, item.Quantity, $"Sale #{sale.Id}");
            }

            return sale;
        }

        public async Task<List<Sale>> GetSalesByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _context.Sales
                .Where(s => s.SaleDate >= startDate && s.SaleDate <= endDate)
                .Include(s => s.SaleItems)
                .ThenInclude(si => si.Product)
                .OrderByDescending(s => s.SaleDate)
                .ToListAsync();
        }

        public async Task<List<object>> GetTopSellingProductsAsync(int days = 30, int topCount = 10)
        {
            var startDate = DateTime.Now.AddDays(-days);
            var result = await _context.SaleItems
                .Where(si => si.Sale.SaleDate >= startDate)
                .GroupBy(si => si.ProductId)
                .Select(g => new
                {
                    ProductId = g.Key,
                    ProductName = g.First().Product.Name,
                    TotalQuantity = g.Sum(si => si.Quantity),
                    TotalRevenue = g.Sum(si => si.Quantity * si.UnitPrice),
                    AveragePrice = g.Average(si => si.UnitPrice)
                })
                .OrderByDescending(x => x.TotalRevenue)
                .Take(topCount)
                .ToListAsync();
            
            return result.Cast<object>().ToList();
        }

        public async Task<List<object>> GetDailySalesSummaryAsync(int days = 30)
        {
            var startDate = DateTime.Now.AddDays(-days);
            var result = await _context.Sales
                .Where(s => s.SaleDate >= startDate)
                .GroupBy(s => s.SaleDate.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    TotalSales = g.Sum(s => s.TotalAmount),
                    TransactionCount = g.Count(),
                    AverageTransactionValue = g.Average(s => s.TotalAmount)
                })
                .OrderByDescending(x => x.Date)
                .ToListAsync();
            
            return result.Cast<object>().ToList();
        }

        public async Task<List<object>> GetSalesByPaymentMethodAsync(int days = 30)
        {
            var startDate = DateTime.Now.AddDays(-days);
            var result = await _context.Sales
                .Where(s => s.SaleDate >= startDate)
                .GroupBy(s => s.PaymentMethod)
                .Select(g => new
                {
                    PaymentMethod = g.Key,
                    TotalSales = g.Sum(s => s.TotalAmount),
                    TransactionCount = g.Count(),
                    AverageTransactionValue = g.Average(s => s.TotalAmount)
                })
                .OrderByDescending(x => x.TotalSales)
                .ToListAsync();
            
            return result.Cast<object>().ToList();
        }

        public async Task<decimal> GetTotalSalesAsync(DateTime startDate, DateTime endDate)
        {
            var sales = await _context.Sales
                .Where(s => s.SaleDate >= startDate && s.SaleDate <= endDate)
                .ToListAsync();
            
            return sales.Sum(s => s.TotalAmount); 
        }

        public async Task<int> GetTransactionCountAsync(DateTime startDate, DateTime endDate)
        {
            return await _context.Sales
                .Where(s => s.SaleDate >= startDate && s.SaleDate <= endDate)
                .CountAsync();
        }
    }
}
