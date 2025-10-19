using NUnit.Framework;
using InventoryManagement.Models;
using InventoryManagement.Data;
using InventoryManagement.Services;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace InventoryManagement.Tests
{
    [TestFixture]
    public class ProductTests
    {
        private AppDbContext _context;
        private ProductService _productService;
        private IRepository<Product> _productRepository;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            
            _context = new AppDbContext();
            _context.Database.EnsureCreated();
            
            _productRepository = new Repository<Product>(_context);
            _productService = new ProductService(_context, _productRepository);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }

        [Test]
        public void CalculateValue_PhysicalProduct_ReturnsCorrect()
        {
            // Arrange
            var product = new PhysicalProduct 
            { 
                CurrentStock = 10, 
                UnitPrice = 5.50m 
            };

            // Act
            var result = product.CalculateValue();

            // Assert
            Assert.AreEqual(55.00m, result);
        }

        [Test]
        public void CalculateValue_PerishableProduct_ReturnsCorrect()
        {
            // Arrange
            var product = new PerishableProduct 
            { 
                CurrentStock = 5, 
                UnitPrice = 12.00m 
            };

            // Act
            var result = product.CalculateValue();

            // Assert
            Assert.AreEqual(60.00m, result);
        }

        [Test]
        public void NeedsReorder_BelowLevel_ReturnsTrue()
        {
            // Arrange
            var product = new PhysicalProduct 
            { 
                CurrentStock = 5, 
                ReorderLevel = 10 
            };

            // Act
            var result = product.NeedsReorder();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void NeedsReorder_AboveLevel_ReturnsFalse()
        {
            // Arrange
            var product = new PhysicalProduct 
            { 
                CurrentStock = 15, 
                ReorderLevel = 10 
            };

            // Act
            var result = product.NeedsReorder();

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void NeedsReorder_PerishableProduct_ExpiringSoon_ReturnsTrue()
        {
            // Arrange
            var product = new PerishableProduct 
            { 
                CurrentStock = 15, 
                ReorderLevel = 10,
                ExpiryDate = DateTime.Today.AddDays(3)
            };

            // Act
            var result = product.NeedsReorder();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void GenerateReport_Product_ReturnsFormattedString()
        {
            // Arrange
            var product = new PhysicalProduct 
            { 
                Name = "Test Product",
                SKU = "TEST001",
                CurrentStock = 25,
                UnitPrice = 9.99m
            };

            // Act
            var result = product.GenerateReport();

            // Assert
            Assert.AreEqual("Test Product (TEST001) | Stock: 25 | Price: $9.99", result);
        }

        [Test]
        public async Task AddProduct_ValidData_Succeeds()
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
                ReorderLevel = 20,
                CategoryId = category.Id,
                SupplierId = supplier.Id
            };

            // Act
            var result = await _productService.AddProductAsync(product);

            // Assert
            Assert.IsNotNull(result);
            Assert.Greater(result.Id, 0);
            Assert.AreEqual("Test Product", result.Name);
        }

        [Test]
        public async Task GetLowStockProducts_ReturnsCorrectProducts()
        {
            // Arrange
            var category = new Category { Name = "Test Category", Description = "Test" };
            var supplier = new Supplier { Name = "Test Supplier", ContactPerson = "John Doe" };
            
            await _context.Categories.AddAsync(category);
            await _context.Suppliers.AddAsync(supplier);
            await _context.SaveChangesAsync();

            var lowStockProduct = new PhysicalProduct
            {
                Name = "Low Stock Product",
                SKU = "LOW001",
                UnitPrice = 10.00m,
                CurrentStock = 5,
                ReorderLevel = 10,
                CategoryId = category.Id,
                SupplierId = supplier.Id
            };

            var normalStockProduct = new PhysicalProduct
            {
                Name = "Normal Stock Product",
                SKU = "NORM001",
                UnitPrice = 10.00m,
                CurrentStock = 50,
                ReorderLevel = 10,
                CategoryId = category.Id,
                SupplierId = supplier.Id
            };

            await _context.Products.AddAsync(lowStockProduct);
            await _context.Products.AddAsync(normalStockProduct);
            await _context.SaveChangesAsync();

            // Act
            var result = await _productService.GetLowStockProductsAsync();

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Low Stock Product", result[0].Name);
        }

        [Test]
        public async Task GetTotalInventoryValue_ReturnsCorrectTotal()
        {
            // Arrange
            var category = new Category { Name = "Test Category", Description = "Test" };
            var supplier = new Supplier { Name = "Test Supplier", ContactPerson = "John Doe" };
            
            await _context.Categories.AddAsync(category);
            await _context.Suppliers.AddAsync(supplier);
            await _context.SaveChangesAsync();

            var product1 = new PhysicalProduct
            {
                Name = "Product 1",
                SKU = "P001",
                UnitPrice = 10.00m,
                CurrentStock = 5,
                CategoryId = category.Id,
                SupplierId = supplier.Id
            };

            var product2 = new PhysicalProduct
            {
                Name = "Product 2",
                SKU = "P002",
                UnitPrice = 20.00m,
                CurrentStock = 3,
                CategoryId = category.Id,
                SupplierId = supplier.Id
            };

            await _context.Products.AddAsync(product1);
            await _context.Products.AddAsync(product2);
            await _context.SaveChangesAsync();

            // Act
            var result = await _productService.GetTotalInventoryValueAsync();

            // Assert
            Assert.AreEqual(110.00m, result); // (10*5) + (20*3) = 50 + 60 = 110
        }

        [Test]
        public void IAuditable_Product_HasAuditProperties()
        {
            // Arrange
            var product = new PhysicalProduct();

            // Act & Assert
            Assert.IsInstanceOf<IAuditable>(product);
            Assert.IsNotNull(product.CreatedDate);
            Assert.IsNotNull(product.CreatedBy);
        }

        [Test]
        public void IReportable_Product_ImplementsInterface()
        {
            // Arrange
            var product = new PhysicalProduct();

            // Act & Assert
            Assert.IsInstanceOf<IReportable>(product);
            Assert.IsNotNull(product.GenerateReport());
        }
    }
}

