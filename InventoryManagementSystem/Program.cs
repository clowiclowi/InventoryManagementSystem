using System;
using System.Windows.Forms;
using InventoryManagement.Data;

namespace InventoryManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();

            using (var db = new AppDbContext())
            {
                // Force database recreation to ensure correct schema
                await db.Database.EnsureDeletedAsync();
                await db.Database.EnsureCreatedAsync();
                await DbInitializer.EnsureSeedAsync(db);
            }

            Application.Run(new MainForm());
        }
    }
}
