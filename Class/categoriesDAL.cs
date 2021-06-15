using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestShop.Class
{
    class categoriesDAL
    {
        //Статичний метод рядка з'єднання з базою даних 
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Method
        public DataTable Select()
        {
            //Створення підключення до бази даних
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //Запис SQL Query, щоб отримати всі дані з бази даних
                string sql = "SELECT * FROM tbl_categories";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Відкриває підключення до бази даних
                conn.Open();
                //Додавання значення від адаптера до таблиці даних dt
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion
        #region Insert New Category
        public bool Insert(categoriesBLL c)
        {
            //Створення логічної змінної та встановити його значення за замовчуванням на помилку
            bool isSucces = false;

            //Підключення до бази даних
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Написати запит на додавання нової категорії
                string sql = "INSERT INTO tbl_categories (title, description, added_date, added_by) VALUES (@title, @description, @added_date, @added_by)";

                //Створення команди SQL для передачі значень у нашому запиті
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Передавати значення через параметр
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);


                //Відкрита база даних
                conn.Open();

                //Створення змінної int для виконання запиту
                int rows = cmd.ExecuteNonQuery();

                //Якщо запит виконано успішно, його значення буде більше 0, інакше воно буде менше 0

                if (rows > 0)
                {
                    //Запит виконано успішно
                    isSucces = true;
                }
                else
                {
                    //Не вдалося виконати запит
                    isSucces = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Закриття підключення бази даних
                conn.Close();
            }

            return isSucces;
        }
        #endregion
        #region Update Method
        public bool Update(categoriesBLL c)
        {
            //Створення логічної змінної та встановити його значення за замовчуванням на false
            bool isSuccess = false;

            //Створення SQL з'єднання
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Запит на оновлення категорії
                string sql = "UPDATE tbl_categories SET title=@title, description=@description, added_date=@added_date, added_by=@added_by WHERE id=@id";

                //Команда SQL для передачі значення у запиті sql 
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Передача значення за допомогою cmd
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@id", c.id);

                //Відкрите підключення до бази даних
                conn.Open();

                //Створити змінну Int для виконання запиту
                int rows = cmd.ExecuteNonQuery();

                //Якщо запит буде успішно виконано, значення буде більше нуля
                if (rows > 0)
                {
                    //Запит виконано успішно
                    isSuccess = true;
                }
                else
                {
                    //Не вдалося виконати запит
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Delete Category Method
        public bool Delete(categoriesBLL c)
        {
            //Створення логічної змінної і встановіть його значення на false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL запит на видалення з бази даних
                string sql = "DELETE FROM tbl_categories WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                //Передавання значення за допомогою cmd
                cmd.Parameters.AddWithValue("@id", c.id);

                //Відкрийте SqlConnection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //Якщо Запит виконано успішно, то значення рядків буде більшим, ніж нульове, воно буде менше 0
                if (rows > 0)
                {
                    //Запит виконано успішно
                    isSuccess = true;
                }
                else
                {
                    //Не вдалося виконати запит
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Method for Search Funtionality
        public DataTable Search(string keywords)
        {
            //SQL підключення для підключення до бази даних
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Створення таблиці даних для тимчасового зберігання даних з бази даних
            DataTable dt = new DataTable();

            try
            {
                //SQL запит на пошук категорій з бази даних
                String sql = "SELECT * FROM tbl_categories WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%'";
                //Створення команди SQL для виконання запиту
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Отримання даних з бази даних
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Відкрите підключення до бази даних
                conn.Open();
                //Передавання значень з адаптера в таблицю даних dt
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion
    }
}
