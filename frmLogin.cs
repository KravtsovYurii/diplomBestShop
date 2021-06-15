using System;
using BestShop.Class;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        public static string loggedIn;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            user.Show();
            this.Hide();
        }

        private void btnSing_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();

            //Перевірка реєстраційних даних
            bool sucess = dal.loginCheck(l);
            if (sucess == true)
            {
                //Вхід успішно
                loggedIn = l.username;
                frmHome home = new frmHome();
                home.Show();
            }
            else
            {
                //Помилка логіну
                MessageBox.Show("Помилка логіну або пароля! Cпробуйте ще раз.");
            }
        }
    }
}
