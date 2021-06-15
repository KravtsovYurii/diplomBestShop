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
    class productsDAL
    {
        //Creating STATIC String Method for DB Connection
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select method for Product Module
        public DataTable Select()
        {
            //Create Sql Connection to connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            //DataTable to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //Writing the Query to Select all the products from database
                String sql = "SELECT * FROM tbl_products";

                //Creating SQL Command to Execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //SQL Data Adapter to hold the value from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Database Connection
                conn.Open();

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
        #region Method to Insert Product in database
        public bool Insert(productsBLL p)
        {
            //Creating Boolean Variable and set its default value to false
            bool isSuccess = false;

            //Sql Connection for Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Sql Query to insert product into database
                String sql = "INSERT INTO tbl_products (name, category, description, rate, qty, added_date, added_by) VALUES (@name, @category, @description, @rate, @qty, @added_date, @added_by)";

                //Creating SQL Command to pass the values
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the values through parameters
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

                //Opening the Database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //If the query is executed successfully then the value of rows will be greater then 0 else it will be less then 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
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
        #region Method to Update Product in Database
        public bool Update(productsBLL p)
        {
            //Create a boolean variable and set its initial value to false
            bool isSuccess = false;

            //Create SQL Connection for Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Update in database
                String sql = "UPDATE tbl_products SET name=@name, category=@category, description=@description, rate=@rate, qty=@qty, added_date=@added_date, added_by=@added_by WHERE id=@id";

                //Create SQL Command to pass the value to query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the values using parameters and cmd
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);

                //Open the Database Connection
                conn.Open();

                //Create Int Variable to check if the query is execute successfully or not
                int rows = cmd.ExecuteNonQuery();

                //If the query is executed successfully then the value of rows will be greater then 0 else it will be less then zero
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
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
        #region Method to Delete Product from Database
        public bool Delete(productsBLL p)
        {
            //Create Boolean Variable and Set its default value to false
            bool isSuccess = false;

            //SQL Connection for DB Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Write Queary Product from Database
                String sql = "DELETE FROM tbl_products WHERE id=@id";

                //Sql Command to Pass the Value
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the values using cmd
                cmd.Parameters.AddWithValue("@id", p.id);

                //Open Database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //If the query is executed successfully then the value of rows will be greated then 0 else it will be less then 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
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
        #region Search Method for Product Module
        public DataTable Search(string keywords)
        {
            //SQL Connection for DB Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            //Creating datatable o hold value from database
            DataTable dt = new DataTable();

            try
            {
                //SQL Query to search product 
                string sql = "SELECT * FROM tbl_products WHERE name LIKE '%" + keywords + "%' OR category LIKE '%" + keywords + "%'";
                //SQL Command to execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //SQL Data Adapter to hold the data from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Database Connection 
                conn.Open();

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
        #region Method to Search Product in Transaction Module
        public productsBLL GetProductsForTransaction(string keyword)
        {
            productsBLL p = new productsBLL();

            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT name, rate, qty FROM tbl_products WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    p.name = dt.Rows[0]["name"].ToString();
                    p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    p.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
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

            return p;
        }
        #endregion
        #region Method to get Product id Based on Product Name
        public productsBLL GetProductIDFromName(string ProductName)
        {
            productsBLL p = new productsBLL();

            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id FROM tbl_products WHERE name='" + ProductName + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    p.id = int.Parse(dt.Rows[0]["id"].ToString());
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

            return p;
        }
        #endregion
        #region Method to get current quantity from the Database based on Product ID
        public decimal GetProductQty(int ProductID)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            decimal qty = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT qty FROM tbl_products WHERE id = " + ProductID;

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    qty = decimal.Parse(dt.Rows[0]["qty"].ToString());

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

            return qty;
        }
        #endregion
        #region Method to Update quantity
        public bool UpdateQuantity(int ProductID, decimal Qty)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_products SET qty=@qty WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@qty", Qty);
                cmd.Parameters.AddWithValue("@id", ProductID);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
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

            return success;
        }
        #endregion 
        #region Method to Increase Product
        public bool IncreaseProduct(int ProductID, decimal IncreaseQty)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                decimal currentQty = GetProductQty(ProductID);

                decimal NewQty = currentQty + IncreaseQty;

                success = UpdateQuantity(ProductID, NewQty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return success;
        }
        #endregion
        #region Method to Decrease Product
        public bool DecreaseProduct(int ProductID, decimal Qty)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                decimal currentQty = GetProductQty(ProductID);

                decimal NewQty = currentQty - Qty;

                success = UpdateQuantity(ProductID, NewQty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }
        #endregion
        #region Display Products based on Categories
        public DataTable DisplayProductsByCategory(string category)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_products WHERE category='" + category + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

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
