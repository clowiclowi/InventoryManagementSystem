using InventoryManagement.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace InventoryManagement.Tests
{
    public class BasicTests
    {
        [Test]
        public void CalculateValue_Works()
        {
            var p = new PhysicalProduct { UnitPrice = 5m, CurrentStock = 10, Name = "Test", SKU = "T1" };
            Assert.AreEqual(50m, p.CalculateValue());
        }

        [Test]
        public void NeedsReorder_TrueWhenBelowLevel()
        {
            var p = new PhysicalProduct { CurrentStock = 5, ReorderLevel = 10, Name = "Test", SKU = "T2" };
            Assert.IsTrue(p.NeedsReorder());
        }
    }
}
