using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestShop
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        public static string transactionType;

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCategories categories = new frmCategories();
            categories.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmProducts products = new frmProducts();
            products.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmDea dea = new frmDea();
            dea.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // Set value on transaction type static method
            transactionType = "Продаж товару";
            frmSales sales = new frmSales();
            sales.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void переглядСтатистикіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
        }

        private void звітністьПроПродажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZvit zvit = new frmZvit();
            zvit.Show();
        }
    }
}
