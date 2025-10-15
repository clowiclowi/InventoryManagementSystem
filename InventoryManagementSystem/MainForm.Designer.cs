using System.Windows.Forms;

namespace InventoryManagement.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Text = "Inventory Dashboard";

            var menu = new MenuStrip();
            var products = new ToolStripMenuItem("Products");
            var stock = new ToolStripMenuItem("Stock");
            var sales = new ToolStripMenuItem("Sales");
            var reports = new ToolStripMenuItem("Reports");
            menu.Items.AddRange(new[] { products, stock, sales, reports });
            MainMenuStrip = menu;
            Controls.Add(menu);

            Controls.Add(new Label
            {
                Text = "Dashboard",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            });
        }
    }
}
