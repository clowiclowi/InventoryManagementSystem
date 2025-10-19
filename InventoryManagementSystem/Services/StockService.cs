using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Services
{
    public class StockService
    {
        private readonly AppDbContext _context;
        private readonly IRepository<StockTransaction> _transactionRepository;

        public StockService(AppDbContext context, IRepository<StockTransaction> transactionRepository)
        {
            _context = context;
            _transactionRepository = transactionRepository;
        }

        public async Task ProcessStockInAsync(int productId, int quantity, string reason = "Stock In")
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
                throw new ArgumentException("Product not found");

            // Update stock
            product.CurrentStock += quantity;

            // Create transaction record
            var transaction = new StockTransaction
            {
                ProductId = productId,
                TransactionType = "IN",
                Quantity = quantity,
                Reason = reason,
                TransactionDate = DateTime.Now,
                CreatedBy = "system"
            };

            await _transactionRepository.AddAsync(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task ProcessStockOutAsync(int productId, int quantity, string reason = "Stock Out")
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
                throw new ArgumentException("Product not found");

            if (product.CurrentStock < quantity)
                throw new InvalidOperationException("Insufficient stock");

            // Update stock
            product.CurrentStock -= quantity;

            // Create transaction record
            var transaction = new StockTransaction
            {
                ProductId = productId,
                TransactionType = "OUT",
                Quantity = quantity,
                Reason = reason,
                TransactionDate = DateTime.Now,
                CreatedBy = "system"
            };

            await _transactionRepository.AddAsync(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task ProcessStockAdjustmentAsync(int productId, int newQuantity, string reason = "Stock Adjustment")
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
                throw new ArgumentException("Product not found");

            var difference = newQuantity - product.CurrentStock;
            product.CurrentStock = newQuantity;

            // Create transaction record
            var transaction = new StockTransaction
            {
                ProductId = productId,
                TransactionType = "ADJUSTMENT",
                Quantity = difference,
                Reason = reason,
                TransactionDate = DateTime.Now,
                CreatedBy = "system"
            };

            await _transactionRepository.AddAsync(transaction);
            await _context.SaveChangesAsync();
        }

        // LINQ Query 1: Get recent stock transactions
        public async Task<List<StockTransaction>> GetRecentTransactionsAsync(int days = 30)
        {
            var startDate = DateTime.Now.AddDays(-days);
            return await _context.StockTransactions
                .Where(t => t.TransactionDate >= startDate)
                .Include(t => t.Product)
                .OrderByDescending(t => t.TransactionDate)
                .ToListAsync();
        }

        // LINQ Query 2: Get stock movement summary by product
        public async Task<List<object>> GetStockMovementSummaryAsync(int days = 30)
        {
            var startDate = DateTime.Now.AddDays(-days);
            var result = await _context.StockTransactions
                .Where(t => t.TransactionDate >= startDate)
                .GroupBy(t => t.ProductId)
                .Select(g => new
                {
                    ProductId = g.Key,
                    ProductName = g.First().Product.Name,
                    TotalIn = g.Where(t => t.TransactionType == "IN").Sum(t => t.Quantity),
                    TotalOut = g.Where(t => t.TransactionType == "OUT").Sum(t => t.Quantity),
                    NetMovement = g.Where(t => t.TransactionType == "IN").Sum(t => t.Quantity) - 
                                  g.Where(t => t.TransactionType == "OUT").Sum(t => t.Quantity)
                })
                .OrderByDescending(x => x.NetMovement)
                .ToListAsync();
            
            return result.Cast<object>().ToList();
        }

        // LINQ Query 3: Get low stock alerts with transaction history
        public async Task<List<Product>> GetLowStockProductsWithHistoryAsync()
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .ToListAsync();
            
            return products
                .Where(p => p.NeedsReorder()) // Uses polymorphic method on client side
                .OrderBy(p => p.CurrentStock)
                .ToList();
        }
    }
}
