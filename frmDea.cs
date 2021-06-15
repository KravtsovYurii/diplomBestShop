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
    public partial class frmDea : Form
    {
        public frmDea()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        deaBLL d = new deaBLL();
        deaDAL dDal = new deaDAL();
        userDAL uDal = new userDAL();

        private void frmDea_Load(object sender, EventArgs e)
        {
            DataTable dt = dDal.Select();
            dgvDea.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.name = txtName.Text;
            d.email = txtEmail.Text;
            d.contact = txtContact.Text;
            d.address = txtAddress.Text;
            d.added_date = DateTime.Now;

            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = uDal.GetIDFromUsername(loggedUsr);
            d.added_by = usr.id;

            bool success = dDal.Insert(d);

            if (success == true)
            {
                MessageBox.Show("Додано успішно!");
                Clear();

                DataTable dt = dDal.Select();
                dgvDea.DataSource = dt;
            }
            else
            {

            }
        }
        public void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtSearch.Text = "";
        }

        private void dgvDea_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtID.Text = dgvDea.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvDea.Rows[rowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvDea.Rows[rowIndex].Cells[2].Value.ToString();
            txtContact.Text = dgvDea.Rows[rowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgvDea.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d.id = int.Parse(txtID.Text);
            d.name = txtName.Text;
            d.email = txtEmail.Text;
            d.contact = txtContact.Text;
            d.address = txtAddress.Text;
            d.added_date = DateTime.Now;

            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = uDal.GetIDFromUsername(loggedUsr);
            d.added_by = usr.id;

            bool success = dDal.Update(d);

            if (success == true)
            {
                MessageBox.Show("Данні оновлено!");
                Clear();
                DataTable dt = dDal.Select();
                dgvDea.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Не вдалося оновити данні");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            d.id = int.Parse(txtID.Text);

            bool success = dDal.Delete(d);

            if (success == true)
            {
                MessageBox.Show("Видалено успішно!");
                Clear();
                DataTable dt = dDal.Select();
                dgvDea.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Не вдалося видалити!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword != null)
            {
                DataTable dt = dDal.Search(keyword);
                dgvDea.DataSource = dt;
            }
            else
            {
                DataTable dt = dDal.Select();
                dgvDea.DataSource = dt;
            }
        }
    }
}
