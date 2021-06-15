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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();}

        categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();
        userDAL udal = new userDAL();

        private void button1_Click(object sender, EventArgs e)
        {
            //Get the values from Category From
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            //Getting ID in Added by field
            string loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            //Passing the id of Logged in User in added by field
            c.added_by = usr.id;

            //Creating Boolean Method To insert data into database
            bool success = dal.Insert(c);

            //If the category is inserted successfully then the value of the success will be true else it will be false
            if (success == true)
            {
                //NewCategory Inserted Successfully
                MessageBox.Show("Нова категорія введена успішно!");
                Clear();
                //Refresh Data Grid View
                DataTable dt = dal.Select();
                dgvCategory.DataSource = dt;
            }
            else
            {
                //Failed to Insert New Category
                MessageBox.Show("Не вдалося додати нову категорію!");
            }
        }

        public void Clear()
        {
            txtCategoryID.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtSearch.Text = "";
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            //Here write the code to display all categories in data grid view
            DataTable dt = dal.Select();
            dgvCategory.DataSource = dt;
        }

        private void dgvCategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Finding the Row Index of the Row Cliked on Data Grid View
            int RowIndex = e.RowIndex;
            txtCategoryID.Text = dgvCategory.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategory.Rows[RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategory.Rows[RowIndex].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Get the Values from the Category form
            c.id = int.Parse(txtCategoryID.Text);
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;
            //Getting ID in Added by field
            string loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            //Passing the id of Logged in User in added by field
            c.added_by = usr.id;

            //Creating Boolean variable to update categories and check
            bool success = dal.Update(c);
            //If the category is update successfully then the value of success will be true else it will be false
            if (success == true)
            {
                //Category update Successfully
                MessageBox.Show("Оновлення категорії успішно!");
                Clear();
                //Refresh Data Grid View
                DataTable dt = dal.Select();
                dgvCategory.DataSource = dt;
            }
            else
            {
                //Failed to Update Category
                MessageBox.Show("Не вдалося оновити категорію!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get to ID of the Category Whith we want to Delete
            c.id = int.Parse(txtCategoryID.Text);

            //Creating Boolean Variable to Delete the Category
            bool success = dal.Delete(c);

            //If the Category id Deleted Suceessfully then the value of success will be true else it will be false
            if (success == true)
            {
                //Category Deleted Successfully
                MessageBox.Show("Категорія успішно видалена!");
                Clear();
                //Refreshing Data Grid View
                DataTable dt = dal.Select();
                dgvCategory.DataSource = dt;
            }
            else
            {
                //Failed to Delete Category
                MessageBox.Show("Не вдалося видалити категорію!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Отримати ключові слова
            string keywords = txtSearch.Text;

            //Фільтруйте категорії за ключовими словами
            if (keywords != null)
            {
                //Використовуйте Метод Search для відображення категорій
                DataTable dt = dal.Search(keywords);
                dgvCategory.DataSource = dt;
            }
            else
            {
                //Використовуйте метод Select для відображення всіх категорій
                DataTable dt = dal.Select();
                dgvCategory.DataSource = dt;
            }
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
