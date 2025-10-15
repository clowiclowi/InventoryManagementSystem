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

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = "system";

        public abstract decimal CalculateValue();
        public virtual bool NeedsReorder() => CurrentStock <= ReorderLevel;

        public virtual string GenerateReport() =>
            $"{Name} ({SKU}) | Stock: {CurrentStock} | Price: {UnitPrice:C}";
    }
    // Testing comment for commit
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
}
