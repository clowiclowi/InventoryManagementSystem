using System.Linq;
using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Data
{
    public static class DbInitializer
    {
        public static async Task EnsureSeedAsync(AppDbContext db)
        {
            await db.Database.EnsureCreatedAsync();

            if (await db.Products.AnyAsync()) return; // already seeded

            // Create sample categories
            var categories = new List<Category>
            {
                new Category { Name = "Electronics", Description = "Electronic devices and accessories" },
                new Category { Name = "Clothing", Description = "Apparel and fashion items" },
                new Category { Name = "Books", Description = "Books and educational materials" },
                new Category { Name = "Food & Beverages", Description = "Food items and drinks" },
                new Category { Name = "Home & Garden", Description = "Home improvement and garden supplies" }
            };

            await db.Categories.AddRangeAsync(categories);
            await db.SaveChangesAsync();

            // Create sample suppliers
            var suppliers = new List<Supplier>
            {
                new Supplier 
                { 
                    Name = "TechSupply Inc", 
                    ContactPerson = "John Smith", 
                    Email = "john@techsupply.com", 
                    Phone = "555-0101",
                    Address = "123 Tech Street, Tech City, TC 12345"
                },
                new Supplier 
                { 
                    Name = "Fashion Forward", 
                    ContactPerson = "Sarah Johnson", 
                    Email = "sarah@fashionforward.com", 
                    Phone = "555-0102",
                    Address = "456 Fashion Ave, Style City, SC 67890"
                },
                new Supplier 
                { 
                    Name = "BookWorld Distributors", 
                    ContactPerson = "Mike Davis", 
                    Email = "mike@bookworld.com", 
                    Phone = "555-0103",
                    Address = "789 Book Lane, Library City, LC 11111"
                },
                new Supplier 
                { 
                    Name = "Fresh Foods Co", 
                    ContactPerson = "Lisa Brown", 
                    Email = "lisa@freshfoods.com", 
                    Phone = "555-0104",
                    Address = "321 Farm Road, Agriculture City, AC 22222"
                },
                new Supplier 
                { 
                    Name = "Home Depot Supply", 
                    ContactPerson = "Tom Wilson", 
                    Email = "tom@homedepot.com", 
                    Phone = "555-0105",
                    Address = "654 Tool Street, Hardware City, HC 33333"
                }
            };

            await db.Suppliers.AddRangeAsync(suppliers);
            await db.SaveChangesAsync();

            // Create sample products
            var products = new List<Product>
            {
                new PhysicalProduct
                {
                    Name = "Wireless Mouse",
                    SKU = "WM001",
                    UnitPrice = 25.99m,
                    UnitCost = 12.50m,
                    CurrentStock = 50,
                    ReorderLevel = 10,
                    CategoryId = categories[0].Id,
                    SupplierId = suppliers[0].Id,
                    Barcode = "123456789012"
                },
                new PhysicalProduct
                {
                    Name = "USB Keyboard",
                    SKU = "KB001",
                    UnitPrice = 45.00m,
                    UnitCost = 22.00m,
                    CurrentStock = 30,
                    ReorderLevel = 5,
                    CategoryId = categories[0].Id,
                    SupplierId = suppliers[0].Id,
                    Barcode = "123456789013"
                },
                new PhysicalProduct
                {
                    Name = "Cotton T-Shirt",
                    SKU = "TS001",
                    UnitPrice = 19.99m,
                    UnitCost = 8.50m,
                    CurrentStock = 100,
                    ReorderLevel = 20,
                    CategoryId = categories[1].Id,
                    SupplierId = suppliers[1].Id,
                    WeightKg = 0.2m
                },
                new PhysicalProduct
                {
                    Name = "Denim Jeans",
                    SKU = "DJ001",
                    UnitPrice = 59.99m,
                    UnitCost = 25.00m,
                    CurrentStock = 5, // Low stock
                    ReorderLevel = 15,
                    CategoryId = categories[1].Id,
                    SupplierId = suppliers[1].Id,
                    WeightKg = 0.8m
                },
                new PhysicalProduct
                {
                    Name = "Programming Book",
                    SKU = "PB001",
                    UnitPrice = 49.99m,
                    UnitCost = 20.00m,
                    CurrentStock = 25,
                    ReorderLevel = 5,
                    CategoryId = categories[2].Id,
                    SupplierId = suppliers[2].Id
                },
                new PerishableProduct
                {
                    Name = "Fresh Apples",
                    SKU = "FA001",
                    UnitPrice = 3.99m,
                    UnitCost = 1.50m,
                    CurrentStock = 8, // Low stock
                    ReorderLevel = 20,
                    CategoryId = categories[3].Id,
                    SupplierId = suppliers[3].Id,
                    ExpiryDate = DateTime.Today.AddDays(7)
                },
                new PerishableProduct
                {
                    Name = "Organic Milk",
                    SKU = "OM001",
                    UnitPrice = 4.99m,
                    UnitCost = 2.00m,
                    CurrentStock = 12,
                    ReorderLevel = 10,
                    CategoryId = categories[3].Id,
                    SupplierId = suppliers[3].Id,
                    ExpiryDate = DateTime.Today.AddDays(3) // Expiring soon
                },
                new PhysicalProduct
                {
                    Name = "Garden Hose",
                    SKU = "GH001",
                    UnitPrice = 39.99m,
                    UnitCost = 18.00m,
                    CurrentStock = 15,
                    ReorderLevel = 5,
                    CategoryId = categories[4].Id,
                    SupplierId = suppliers[4].Id,
                    WeightKg = 2.5m
                },
                new PhysicalProduct
                {
                    Name = "Power Drill",
                    SKU = "PD001",
                    UnitPrice = 89.99m,
                    UnitCost = 45.00m,
                    CurrentStock = 2, // Very low stock
                    ReorderLevel = 8,
                    CategoryId = categories[4].Id,
                    SupplierId = suppliers[4].Id,
                    WeightKg = 1.2m
                },
                new PhysicalProduct
                {
                    Name = "Smartphone Case",
                    SKU = "SC001",
                    UnitPrice = 15.99m,
                    UnitCost = 6.00m,
                    CurrentStock = 75,
                    ReorderLevel = 15,
                    CategoryId = categories[0].Id,
                    SupplierId = suppliers[0].Id
                }
            };

            await db.Products.AddRangeAsync(products);
            await db.SaveChangesAsync();

            // Create some sample stock transactions
            var transactions = new List<StockTransaction>
            {
                new StockTransaction
                {
                    ProductId = products[0].Id,
                    TransactionType = "IN",
                    Quantity = 50,
                    Reason = "Initial stock",
                    TransactionDate = DateTime.Now.AddDays(-30),
                    CreatedBy = "system"
                },
                new StockTransaction
                {
                    ProductId = products[3].Id,
                    TransactionType = "OUT",
                    Quantity = 10,
                    Reason = "Sale",
                    TransactionDate = DateTime.Now.AddDays(-5),
                    CreatedBy = "system"
                },
                new StockTransaction
                {
                    ProductId = products[5].Id,
                    TransactionType = "IN",
                    Quantity = 20,
                    Reason = "Restock",
                    TransactionDate = DateTime.Now.AddDays(-2),
                    CreatedBy = "system"
                }
            };

            await db.StockTransactions.AddRangeAsync(transactions);
            await db.SaveChangesAsync();

            // Create some sample sales
            var sales = new List<Sale>
            {
                new Sale
                {
                    CustomerName = "John Customer",
                    PaymentMethod = "Credit Card",
                    Notes = "Regular customer",
                    SaleDate = DateTime.Now.AddDays(-3),
                    TotalAmount = 45.00m
                },
                new Sale
                {
                    CustomerName = "Jane Customer",
                    PaymentMethod = "Cash",
                    Notes = "Walk-in customer",
                    SaleDate = DateTime.Now.AddDays(-1),
                    TotalAmount = 25.99m
                },
                new Sale
                {
                    CustomerName = "Bob Customer",
                    PaymentMethod = "Debit Card",
                    Notes = "Bulk purchase",
                    SaleDate = DateTime.Today,
                    TotalAmount = 89.99m
                }
            };

            await db.Sales.AddRangeAsync(sales);
            await db.SaveChangesAsync();

            // Create sample sale items
            var saleItems = new List<SaleItem>
            {
                new SaleItem
                {
                    SaleId = sales[0].Id,
                    ProductId = products[1].Id,
                    Quantity = 1,
                    UnitPrice = 45.00m
                },
                new SaleItem
                {
                    SaleId = sales[1].Id,
                    ProductId = products[0].Id,
                    Quantity = 1,
                    UnitPrice = 25.99m
                },
                new SaleItem
                {
                    SaleId = sales[2].Id,
                    ProductId = products[8].Id,
                    Quantity = 1,
                    UnitPrice = 89.99m
                }
            };

            await db.SaleItems.AddRangeAsync(saleItems);
            await db.SaveChangesAsync();
        }
    }
}
