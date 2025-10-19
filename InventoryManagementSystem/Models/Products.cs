using System;

namespace InventoryManagement.Models
{
    public interface IReportable
    {
        string GenerateReport();
    }

    public interface IAuditable
    {
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
    }

    public abstract class Product : IReportable, IAuditable
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string SKU { get; set; } = "";
        public decimal UnitPrice { get; set; }
        public decimal UnitCost { get; set; }
        public int CurrentStock { get; set; }
        public int ReorderLevel { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = "system";

        public virtual Category Category { get; set; } = null!;
        public virtual Supplier Supplier { get; set; } = null!;

        public abstract decimal CalculateValue();
        public virtual bool NeedsReorder() => CurrentStock <= ReorderLevel;

        public virtual string GenerateReport() =>
            $"{Name} ({SKU}) | Stock: {CurrentStock} | Price: {UnitPrice:C}";
    }
    // Testing commit
    public class PhysicalProduct : Product
    {
        public string? Barcode { get; set; }
        public decimal? WeightKg { get; set; }
        public override decimal CalculateValue() => CurrentStock * UnitPrice;
    }

    public class PerishableProduct : PhysicalProduct
    {
        public DateTime? ExpiryDate { get; set; }
        public override bool NeedsReorder()
        {
            bool expiringSoon = ExpiryDate.HasValue && ExpiryDate.Value <= DateTime.Today.AddDays(7);
            return base.NeedsReorder() || expiringSoon;
        }
    }

    public class Category : IReportable, IAuditable
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = "system";

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

        public string GenerateReport() => $"Category: {Name} - {Description}";
    }

    public class Supplier : IReportable, IAuditable
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string ContactPerson { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public string Country { get; set; } = "";
        public string BusinessNumber { get; set; } = ""; // Tax ID, VAT, etc.
        public string Website { get; set; } = "";
        public string Notes { get; set; } = "";
        
        // Business Terms
        public int LeadTimeDays { get; set; } = 7; // Default 7 days
        public string PaymentTerms { get; set; } = "Net 30"; // Net 30, Net 15, COD, etc.
        public decimal? CreditLimit { get; set; }
        public string Currency { get; set; } = "USD";
        
        // Status and Performance
        public bool IsActive { get; set; } = true;
        public decimal OnTimeDeliveryPercentage { get; set; } = 100.0m;
        public decimal AverageLeadTimeDays { get; set; } = 7.0m;
        public decimal ReturnRatePercentage { get; set; } = 0.0m;
        public int TotalOrders { get; set; } = 0;
        public decimal TotalOrderValue { get; set; } = 0.0m;
        
        // Audit Fields
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = "system";
        public DateTime? LastOrderDate { get; set; }
        public DateTime? LastContactDate { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

        public string GenerateReport() => $"Supplier: {Name} - Contact: {ContactPerson} ({Email}) - Status: {(IsActive ? "Active" : "Inactive")}";
        
        public int LinkedSKUsCount => Products?.Count ?? 0;
        public string FullAddress => $"{Address}, {City}, {State} {PostalCode}, {Country}".TrimEnd(',', ' ');
    }

    public class PurchaseOrder
    {
        public int Id { get; set; }
        public string PONumber { get; set; } = "";
        public int SupplierId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime? ActualDeliveryDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, Shipped, Delivered, Cancelled
        public string Notes { get; set; } = "";
        public string CreatedBy { get; set; } = "system";
        
        public virtual Supplier Supplier { get; set; } = null!;
        public virtual ICollection<PurchaseOrderItem> Items { get; set; } = new List<PurchaseOrderItem>();
    }

    public class PurchaseOrderItem
    {
        public int Id { get; set; }
        public int PurchaseOrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalCost => Quantity * UnitCost;
        public int? ReceivedQuantity { get; set; }
        public DateTime? ReceivedDate { get; set; }
        
        public virtual PurchaseOrder PurchaseOrder { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }

    public class StockTransaction
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string TransactionType { get; set; } = ""; // "IN", "OUT", "ADJUSTMENT"
        public int Quantity { get; set; }
        public string Reason { get; set; } = "";
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = "system";

        public virtual Product Product { get; set; } = null!;
    }

    public class Sale
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public string CustomerName { get; set; } = "";
        public string PaymentMethod { get; set; } = "";
        public string Notes { get; set; } = "";

        public virtual ICollection<SaleItem> SaleItems { get; set; } = new List<SaleItem>();
    }

    public class SaleItem
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice => Quantity * UnitPrice;

        public virtual Sale Sale { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
