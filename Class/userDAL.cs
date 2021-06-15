using System;
using BestShop.Class;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BestShop.Class
{
    class userDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Data from Database
        public DataTable Select()
        {
            //Static Method to connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //To hold the data from database
            DataTable dt = new DataTable();
            try
            {
                //SQL Query to Get Data From Database
                String sql = "SELECT * FROM tbl_users";
                //For Executing Command    
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Database Connection Open
                conn.Open();
                //Fill Data in our DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Throw Message if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Closing Connection
                conn.Close();
            }
            //Return the value in DataTable
            return dt;
        }
        #endregion
        #region Insert Data in Database
        public bool Insert(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "INSERT INTO tbl_users (first_name, last_name, username, password, contact, address, gender, added_date, added_by) VALUES (@first_name, @last_name, @username, @password, @contact, @address, @gender, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //If the query is executed Successfull then the value to rows will be greater then 0 else it will be less then 0
                if (rows > 0)
                {
                    //Query Sucessfull
                    isSuccess = true;
                }
                else
                {
                    //Query Failed
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
        #region Getting User ID from Username
        public userBLL GetIDFromUsername(string username)
        {
            userBLL u = new userBLL();
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id FROM tbl_users WHERE username='" + username + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    u.id = int.Parse(dt.Rows[0]["id"].ToString());
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
            return u;
        }
        #endregion
    }
}