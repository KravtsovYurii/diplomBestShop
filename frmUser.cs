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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        private void btnSing_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Getting Data From UI
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;

            u.added_date = DateTime.Now;

            //Getting Username of the logged in user
            string loggedUser = frmLogin.loggedIn;
            userBLL usr = dal.GetIDFromUsername(loggedUser);

            u.added_by = usr.id;

            //Inserting Data into Database
            bool success = dal.Insert(u);
            //If the data is successfull iserted then the value of success will be true else is will be false
            if (success == true)
            {
                //Data Successfull Inserted
                MessageBox.Show("Користувач успішно створений!");
                clear();
            }
            else
            {
                //Failed to insert data
                MessageBox.Show("Не вдалося додати нового користувача!");
            }
        }

        private void clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
        }
    }
}
