using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;
        private readonly IRepository<Product> _productRepository;

        public ProductService(AppDbContext context, IRepository<Product> productRepository)
        {
            _context = context;
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .ToListAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            return await _productRepository.AddAsync(product);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }

        // get low stock products using polymorphic method
        public async Task<List<Product>> GetLowStockProductsAsync()
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .ToListAsync();
            
            return products
                .Where(p => p.NeedsReorder()) // uses polymorphic method on client side
                .OrderBy(p => p.CurrentStock)
                .ThenBy(p => p.Name)
                .ToList();
        }

        // search products by name or SKU
        public async Task<List<Product>> SearchProductsAsync(string searchTerm)
        {
            return await _context.Products
                .Where(p => p.Name.Contains(searchTerm) || p.SKU.Contains(searchTerm))
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .ToListAsync();
        }

        // get products by category
        public async Task<List<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            return await _context.Products
                .Where(p => p.CategoryId == categoryId)
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .ToListAsync();
        }

        // get total inventory value using polymorphic method
        public async Task<decimal> GetTotalInventoryValueAsync()
        {
            var products = await _context.Products.ToListAsync();
            return products.Sum(p => p.CalculateValue()); // Uses polymorphic method on client side
        }
    }
}

