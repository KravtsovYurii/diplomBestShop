using BestShop.Class;
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
    public partial class frmZvit : Form
    {
        public frmZvit()
        {
            InitializeComponent();
        }

        transactionDAL tdal = new transactionDAL();

        private void frmZvit_Load(object sender, EventArgs e)
        {
            DataTable dt = tdal.DisplayAllTransactions();
            dataGridView1.DataSource = dt;
        }
    }
}
