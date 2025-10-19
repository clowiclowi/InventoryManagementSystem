using NUnit.Framework;
using InventoryManagement.Models;
using InventoryManagement.Data;
using InventoryManagement.Services;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace InventoryManagement.Tests
{
    [TestFixture]
    public class StockServiceTests
    {
        private AppDbContext _context;
        private StockService _stockService;
        private IRepository<StockTransaction> _transactionRepository;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            
            _context = new AppDbContext();
            _context.Database.EnsureCreated();
            
            _transactionRepository = new Repository<StockTransaction>(_context);
            _stockService = new StockService(_context, _transactionRepository);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }

        [Test]
        public async Task ProcessStockIn_ValidProduct_UpdatesStock()
        {
            // Arrange
            var category = new Category { Name = "Test Category", Description = "Test" };
            var supplier = new Supplier { Name = "Test Supplier", ContactPerson = "John Doe" };
            
            await _context.Categories.AddAsync(category);
            await _context.Suppliers.AddAsync(supplier);
            await _context.SaveChangesAsync();

            var product = new PhysicalProduct
            {
                Name = "Test Product",
                SKU = "TEST001",
                UnitPrice = 10.00m,
                CurrentStock = 50,
                ReorderLevel = 10,
                CategoryId = category.Id,
                SupplierId = supplier.Id
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            // Act
            await _stockService.ProcessStockInAsync(product.Id, 25, "Test stock in");

            // Assert
            var updatedProduct = await _context.Products.FindAsync(product.Id);
            Assert.AreEqual(75, updatedProduct.CurrentStock);

            var transaction = await _context.StockTransactions.FirstAsync();
            Assert.AreEqual("IN", transaction.TransactionType);
            Assert.AreEqual(25, transaction.Quantity);
            Assert.AreEqual("Test stock in", transaction.Reason);
        }

        [Test]
        public async Task ProcessStockOut_ValidProduct_UpdatesStock()
        {
            // Arrange
            var category = new Category { Name = "Test Category", Description = "Test" };
            var supplier = new Supplier { Name = "Test Supplier", ContactPerson = "John Doe" };
            
            await _context.Categories.AddAsync(category);
            await _context.Suppliers.AddAsync(supplier);
            await _context.SaveChangesAsync();

            var product = new PhysicalProduct
            {
                Name = "Test Product",
                SKU = "TEST001",
                UnitPrice = 10.00m,
                CurrentStock = 50,
                ReorderLevel = 10,
                CategoryId = category.Id,
                SupplierId = supplier.Id
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            // Act
            await _stockService.ProcessStockOutAsync(product.Id, 15, "Test stock out");

            // Assert
            var updatedProduct = await _context.Products.FindAsync(product.Id);
            Assert.AreEqual(35, updatedProduct.CurrentStock);

            var transaction = await _context.StockTransactions.FirstAsync();
            Assert.AreEqual("OUT", transaction.TransactionType);
            Assert.AreEqual(15, transaction.Quantity);
            Assert.AreEqual("Test stock out", transaction.Reason);
        }

        [Test]
        public async Task ProcessStockOut_InsufficientStock_ThrowsException()
        {
            // Arrange
            var category = new Category { Name = "Test Category", Description = "Test" };
            var supplier = new Supplier { Name = "Test Supplier", ContactPerson = "John Doe" };
            
            await _context.Categories.AddAsync(category);
            await _context.Suppliers.AddAsync(supplier);
            await _context.SaveChangesAsync();

            var product = new PhysicalProduct
            {
                Name = "Test Product",
                SKU = "TEST001",
                UnitPrice = 10.00m,
                CurrentStock = 10,
                ReorderLevel = 5,
                CategoryId = category.Id,
                SupplierId = supplier.Id
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            // Act & Assert
            var ex = Assert.ThrowsAsync<InvalidOperationException>(
                () => _stockService.ProcessStockOutAsync(product.Id, 15, "Test stock out"));
            
            Assert.AreEqual("Insufficient stock", ex.Message);
        }

        [Test]
        public async Task ProcessStockAdjustment_ValidProduct_UpdatesStock()
        {
            // Arrange
            var category = new Category { Name = "Test Category", Description = "Test" };
            var supplier = new Supplier { Name = "Test Supplier", ContactPerson = "John Doe" };
            
            await _context.Categories.AddAsync(category);
            await _context.Suppliers.AddAsync(supplier);
            await _context.SaveChangesAsync();

            var product = new PhysicalProduct
            {
                Name = "Test Product",
                SKU = "TEST001",
                UnitPrice = 10.00m,
                CurrentStock = 50,
                ReorderLevel = 10,
                CategoryId = category.Id,
                SupplierId = supplier.Id
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            // Act
            await _stockService.ProcessStockAdjustmentAsync(product.Id, 75, "Stock adjustment");

            // Assert
            var updatedProduct = await _context.Products.FindAsync(product.Id);
            Assert.AreEqual(75, updatedProduct.CurrentStock);

            var transaction = await _context.StockTransactions.FirstAsync();
            Assert.AreEqual("ADJUSTMENT", transaction.TransactionType);
            Assert.AreEqual(25, transaction.Quantity); // Difference: 75 - 50 = 25
            Assert.AreEqual("Stock adjustment", transaction.Reason);
        }
    }

    [TestFixture]
    public class SalesServiceTests
    {
        private AppDbContext _context;
        private SalesService _salesService;
        private IRepository<Sale> _saleRepository;
        private IRepository<SaleItem> _saleItemRepository;
        private StockService _stockService;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            
            _context = new AppDbContext();
            _context.Database.EnsureCreated();
            
            _saleRepository = new Repository<Sale>(_context);
            _saleItemRepository = new Repository<SaleItem>(_context);
            var stockRepo = new Repository<StockTransaction>(_context);
            _stockService = new StockService(_context, stockRepo);
            _salesService = new SalesService(_context, _saleRepository, _saleItemRepository, _stockService);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }

        [Test]
        public async Task ProcessSale_ValidSale_ProcessesSuccessfully()
        {
            // Arrange
            var category = new Category { Name = "Test Category", Description = "Test" };
            var supplier = new Supplier { Name = "Test Supplier", ContactPerson = "John Doe" };
            
            await _context.Categories.AddAsync(category);
            await _context.Suppliers.AddAsync(supplier);
            await _context.SaveChangesAsync();

            var product = new PhysicalProduct
            {
                Name = "Test Product",
                SKU = "TEST001",
                UnitPrice = 10.00m,
                UnitCost = 5.00m,
                CurrentStock = 100,
                ReorderLevel = 10,
                CategoryId = category.Id,
                SupplierId = supplier.Id
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            var sale = new Sale
            {
                CustomerName = "Test Customer",
                PaymentMethod = "Cash",
                Notes = "Test sale"
            };

            var saleItems = new List<SaleItem>
            {
                new SaleItem
                {
                    ProductId = product.Id,
                    Quantity = 5,
                    UnitPrice = product.UnitPrice
                }
            };

            // Act
            var result = await _salesService.ProcessSaleAsync(sale, saleItems);

            // Assert
            Assert.IsNotNull(result);
            Assert.Greater(result.Id, 0);
            Assert.AreEqual(50.00m, result.TotalAmount); // 5 * 10.00

            var updatedProduct = await _context.Products.FindAsync(product.Id);
            Assert.AreEqual(95, updatedProduct.CurrentStock); // 100 - 5

            var savedSaleItems = await _context.SaleItems.Where(si => si.SaleId == result.Id).ToListAsync();
            Assert.AreEqual(1, savedSaleItems.Count);
            Assert.AreEqual(5, savedSaleItems[0].Quantity);
        }

        [Test]
        public async Task ProcessSale_InsufficientStock_ThrowsException()
        {
            // Arrange
            var category = new Category { Name = "Test Category", Description = "Test" };
            var supplier = new Supplier { Name = "Test Supplier", ContactPerson = "John Doe" };
            
            await _context.Categories.AddAsync(category);
            await _context.Suppliers.AddAsync(supplier);
            await _context.SaveChangesAsync();

            var product = new PhysicalProduct
            {
                Name = "Test Product",
                SKU = "TEST001",
                UnitPrice = 10.00m,
                CurrentStock = 5,
                ReorderLevel = 10,
                CategoryId = category.Id,
                SupplierId = supplier.Id
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            var sale = new Sale
            {
                CustomerName = "Test Customer",
                PaymentMethod = "Cash"
            };

            var saleItems = new List<SaleItem>
            {
                new SaleItem
                {
                    ProductId = product.Id,
                    Quantity = 10, // More than available stock
                    UnitPrice = product.UnitPrice
                }
            };

            // Act & Assert
            var ex = Assert.ThrowsAsync<InvalidOperationException>(
                () => _salesService.ProcessSaleAsync(sale, saleItems));
            
            Assert.IsTrue(ex.Message.Contains("Insufficient stock"));
        }
    }
}

