using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();
        public DbSet<PhysicalProduct> PhysicalProducts => Set<PhysicalProduct>();
        public DbSet<PerishableProduct> PerishableProducts => Set<PerishableProduct>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Supplier> Suppliers => Set<Supplier>();
        public DbSet<PurchaseOrder> PurchaseOrders => Set<PurchaseOrder>();
        public DbSet<PurchaseOrderItem> PurchaseOrderItems => Set<PurchaseOrderItem>();
        public DbSet<StockTransaction> StockTransactions => Set<StockTransaction>();
        public DbSet<Sale> Sales => Set<Sale>();
        public DbSet<SaleItem> SaleItems => Set<SaleItem>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=inventory.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Product inheritance
            modelBuilder.Entity<Product>()
                .HasDiscriminator<string>("ProductType")
                .HasValue<PhysicalProduct>("physical")
                .HasValue<PerishableProduct>("perishable");

            // Configure relationships
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Supplier)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockTransaction>()
                .HasOne(st => st.Product)
                .WithMany()
                .HasForeignKey(st => st.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SaleItem>()
                .HasOne(si => si.Sale)
                .WithMany(s => s.SaleItems)
                .HasForeignKey(si => si.SaleId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SaleItem>()
                .HasOne(si => si.Product)
                .WithMany()
                .HasForeignKey(si => si.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            // Purchase Order relationships
            modelBuilder.Entity<PurchaseOrder>()
                .HasOne(po => po.Supplier)
                .WithMany(s => s.PurchaseOrders)
                .HasForeignKey(po => po.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PurchaseOrderItem>()
                .HasOne(poi => poi.PurchaseOrder)
                .WithMany(po => po.Items)
                .HasForeignKey(poi => poi.PurchaseOrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PurchaseOrderItem>()
                .HasOne(poi => poi.Product)
                .WithMany()
                .HasForeignKey(poi => poi.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure indexes for performance
            modelBuilder.Entity<Product>()
                .HasIndex(p => p.SKU)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .HasIndex(p => p.Name);

            modelBuilder.Entity<StockTransaction>()
                .HasIndex(st => st.TransactionDate);

            modelBuilder.Entity<Sale>()
                .HasIndex(s => s.SaleDate);
        }
    }
}
