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


    }
}

