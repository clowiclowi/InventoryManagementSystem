using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace InventoryManagement.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();
        public DbSet<PhysicalProduct> PhysicalProducts => Set<PhysicalProduct>();
        public DbSet<PerishableProduct> PerishableProducts => Set<PerishableProduct>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=inventory.db");

        protected override void OnModelCreating(ModelBuilder b)
        {
            b.Entity<Product>().HasDiscriminator<string>("ProductType")
                .HasValue<PhysicalProduct>("physical")
                .HasValue<PerishableProduct>("perishable");
        }
    }
}
