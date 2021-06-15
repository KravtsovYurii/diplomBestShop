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
    class transactionDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Insert Transaction Method 
        public bool Insert_Transaction(transactionBLL t, out int transactionID)
        {
            bool isSuccess = false;
            //Set the out transactionID value to negative 1 i.e. -1
            transactionID = -1;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_transactions (dea_id, grandTotal, transaction_date, discount, added_by) VALUES (@dea_id, @grandTotal, @transaction_date, @discount, @added_by); SELECT @@IDENTITY;";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@dea_id", t.dea_id);
                cmd.Parameters.AddWithValue("@grandTotal", t.grandTotal);
                cmd.Parameters.AddWithValue("@transaction_date", t.transaction_date);
                cmd.Parameters.AddWithValue("@discount", t.discount);
                cmd.Parameters.AddWithValue("@added_by", t.added_by);

                conn.Open();

                object o = cmd.ExecuteScalar();

                if (o != null)
                {
                    transactionID = int.Parse(o.ToString());
                    isSuccess = true;
                }
                else
                {
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
        #region Method to display all the Transaction
        public DataTable DisplayAllTransactions()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_transactions";

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
