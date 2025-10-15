using System;
using System.Windows.Forms;
using InventoryManagement.Data;
using InventoryManagement.Forms;

namespace InventoryManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (var db = new AppDbContext())
            {
                DbInitializer.EnsureSeed(db);
            }

            Application.Run(new MainForm());
        }
    }
}
