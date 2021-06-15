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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        categoriesDAL cdal = new categoriesDAL();
        productsBLL p = new productsBLL();
        productsDAL pdal = new productsDAL();
        userDAL udal = new userDAL();

        private void frmProducts_Load(object sender, EventArgs e)
        {
            //Створення таблиці даних для зберігання категорій з бази даних
            DataTable categoriesDT = cdal.Select();
            //Вкажіть джерело даних для ComboBox категорії
            cmbCategory.DataSource = categoriesDT;
            //Вкажіть учаснику і члену значення для ComboBox
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            //Завантажте всі продукти в режим перегляду даних
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Отримайте всі значення від форми продукту
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;
            //Отримання імені користувача входу в систему
            String loggedUsr = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUsr);

            p.added_by = usr.id;

            //Створіть логічну змінну, щоб перевірити, чи продукт успішно додано
            bool success = pdal.Insert(p);
            //Якщо продукт успішно доданий, значення успіху буде дійсним, інакше воно буде хибним
            if (success == true)
            {
                //Продукт вставлений успішно
                MessageBox.Show("Продукт додано успішно!");
                //Виклик методу очищення
                Clear();
                //Оновити режим перегляду даних
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                //Не вдалося додати новий продукт
                MessageBox.Show("Не вдалося додати новий продукт!");
            }
        }

        public void Clear()
        {
            txtProductID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtRate.Text = "";
            txtSearch.Text = "";
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Створіть цілу змінну, щоб дізнатися, який продукт натиснуто
            int rowIndex = e.RowIndex;
            //Відобразити значення на відповідні текстові вікна
            txtProductID.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtRate.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Отримайте значення від інтерфейсу користувача або продукту
            p.id = int.Parse(txtProductID.Text);
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.added_date = DateTime.Now;
            //Отримання імені користувача, який увійшов до системи для додавання
            String loggedUsr = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUsr);

            p.added_by = usr.id;

            //Створіть логічну змінну, щоб перевірити, чи є продукт оновленим чи ні
            bool success = pdal.Update(p);
            //Якщо продукт успішно оновлюється, тоді значення успіху буде дійсним, інакше воно буде хибним
            if (success == true)
            {
                //Оновлення продукту успішно
                MessageBox.Show("Продукт успішно оновлено!");
                Clear();
                //Оновити файл даних
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                //Не вдалося оновити продукт
                MessageBox.Show("Не вдалося оновити продукт!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Отримайте ідентифікатор продукту, який потрібно видалити
            p.id = int.Parse(txtProductID.Text);

            //Створіть Bool Variable, щоб перевірити, чи продукт видалено чи ні
            bool success = pdal.Delete(p);

            //Якщо продукт видаляється успішно, то значення успіху буде вірним, інакше воно буде хибним
            if (success == true)
            {
                //Продукт успішно видалено
                MessageBox.Show("Продукт успішно видалено!");
                Clear();
                //Оновити файл datagridview 
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                //Не вдалося видалити продукт
                MessageBox.Show("Не вдалося видалити продукт!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Отримати ключові слова з форми
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                //Пошук продуктів
                DataTable dt = pdal.Search(keywords);
                dgvProducts.DataSource = dt;
            }
            else
            {
                //відобразити всі продукти
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
        }
    }
}
