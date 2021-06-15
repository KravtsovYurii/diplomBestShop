using BestShop.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace BestShop
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        deaDAL dDAL = new deaDAL();
        productsDAL pDAL = new productsDAL();
        userDAL uDAL = new userDAL();
        transactionDAL tDAL = new transactionDAL();
        transactionsDetailDAL tdDAL = new transactionsDetailDAL();

        DataTable transactionDT = new DataTable();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productName = txtSearchProduct.Text;
            decimal Rate = decimal.Parse(txtRate.Text);
            decimal Qty = decimal.Parse(txtQty.Text);

            //Total = RatexQty
            decimal Total = Rate * Qty;

            decimal subTotal = decimal.Parse(txtSubTotal.Text);
            subTotal = subTotal + Total;

            if (productName == "")
            {
                MessageBox.Show("Спочатку виберіть продукт.Спробуйте ще раз!");
            }
            else
            {
                transactionDT.Rows.Add(productName, Rate, Qty, Total);

                dgvAddedProducts.DataSource = transactionDT;

                txtSubTotal.Text = subTotal.ToString();

                txtSearchProduct.Text = "";
                txtNameProduct.Text = "";
                txtInventory.Text = "0";
                txtRate.Text = "0";
                txtQty.Text = "0";
            }
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            transactionDT.Columns.Add("Назва");
            transactionDT.Columns.Add("Ціна");
            transactionDT.Columns.Add("Кількість");
            transactionDT.Columns.Add("Всього");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword == "")
            {
                txtName.Text = "";
                txtEmail.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                return;
            }

            deaBLL dc = dDAL.SearchDealerCustomerForTransaction(keyword);

            txtName.Text = dc.name;
            txtEmail.Text = dc.email;
            txtContact.Text = dc.contact;
            txtAddress.Text = dc.address;
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchProduct.Text;

            if(keyword == "")
            {
                txtNameProduct.Text = "";
                txtInventory.Text = "";
                txtRate.Text = "";
                txtQty.Text = "";
                return;
            }

            productsBLL p = pDAL.GetProductsForTransaction(keyword);

            txtNameProduct.Text = p.name;
            txtInventory.Text = p.qty.ToString();
            txtRate.Text = p.rate.ToString();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            string value = txtDiscount.Text;

            if (value == "")
            {
                MessageBox.Show("Будь ласка, додайте знижку спочатку!");
            }
            else
            {
                decimal subTotal = decimal.Parse(txtSubTotal.Text);
                decimal discount = decimal.Parse(txtDiscount.Text);

                decimal grandTotal = ((100 - discount) / 100) * subTotal;

                txtGrandTotal.Text = grandTotal.ToString();
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            decimal grandTotal = decimal.Parse(txtGrandTotal.Text);
            decimal paidAmount = decimal.Parse(txtPaidAmount.Text);

            decimal returnAmount = paidAmount - grandTotal;

            txtReturnAmount.Text = returnAmount.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            transactionBLL transaction = new transactionBLL();


            string deaCustName = txtName.Text;
            deaBLL dc = dDAL.GetDeaCustIDFromName(deaCustName);

            transaction.dea_id = dc.id;
            transaction.grandTotal = Math.Round(decimal.Parse(txtGrandTotal.Text), 2);
            transaction.transaction_date = DateTime.Now;
            transaction.discount = decimal.Parse(txtDiscount.Text);

            string username = frmLogin.loggedIn;
            userBLL u = uDAL.GetIDFromUsername(username);

            transaction.added_by = u.id;
            transaction.transactionDetails = transactionDT;

            bool success = false;

            using (TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;

                bool w = tDAL.Insert_Transaction(transaction, out transactionID);

                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    transactionDetailBLL transactionDetail = new transactionDetailBLL();

                    string ProductName = transactionDT.Rows[i][0].ToString();
                    productsBLL p = pDAL.GetProductIDFromName(ProductName);

                    transactionDetail.product_id = p.id;
                    transactionDetail.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()), 2);
                    transactionDetail.dea_id = dc.id;
                    transactionDetail.added_date = DateTime.Now;
                    transactionDetail.added_by = u.id;

                   string transactionType = lblTop.Text;

                    bool x = false;
                    
                    if (transactionType == "Продаж")
                    {
                        x = pDAL.IncreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }
                    else if (transactionType == "Продаж")
                    {
                        x = pDAL.DecreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }
                    
                    bool y = tdDAL.InsertTransactionDetail(transactionDetail);
                    success = w && x && y;
                    
                }
                if (success == false)
                {
                    //Transaction Complete
                    scope.Complete();
                    MessageBox.Show("Транзакція виконана успішно!");

                    dgvAddedProducts.DataSource = null;
                    dgvAddedProducts.Rows.Clear();

                    txtSearch.Text = "";
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtContact.Text = "";
                    txtAddress.Text = "";
                    txtSearchProduct.Text = "";
                    txtNameProduct.Text = "";
                    txtInventory.Text = "0";
                    txtRate.Text = "0";
                    txtQty.Text = "0";
                    txtSubTotal.Text = "0";
                    txtDiscount.Text = "0";
                    txtGrandTotal.Text = "0";
                    txtPaidAmount.Text = "0";
                    txtReturnAmount.Text = "0";

                }
                else
                {
                    MessageBox.Show("Транзакція не виконана!");
                }
            }
        }

        private void grbProduct_Enter(object sender, EventArgs e)
        {

        }
    }
}
