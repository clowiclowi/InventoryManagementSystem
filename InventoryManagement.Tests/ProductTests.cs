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

