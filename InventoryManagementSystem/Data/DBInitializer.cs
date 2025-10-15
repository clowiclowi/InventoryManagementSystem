using System.Linq;
using InventoryManagement.Models;

namespace InventoryManagement.Data
{
    public static class DbInitializer
    {
        public static void EnsureSeed(AppDbContext db)
        {
            db.Database.EnsureCreated();

            if (db.Products.Any()) return; // already seeded

            db.Products.AddRange(
                new PhysicalProduct
                {
                    Name = "USB-C Cable",
                    SKU = "CAB-001",
                    UnitPrice = 12.99m,
                    UnitCost = 5m,
                    CurrentStock = 50,
                    ReorderLevel = 10
                },
                new PerishableProduct
                {
                    Name = "Milk 2L",
                    SKU = "FOOD-MLK",
                    UnitPrice = 3.50m,
                    UnitCost = 2m,
                    CurrentStock = 20,
                    ReorderLevel = 8,
                    ExpiryDate = System.DateTime.Today.AddDays(5)
                }
            );

            db.SaveChanges();
        }
    }
}
