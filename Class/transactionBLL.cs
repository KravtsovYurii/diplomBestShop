using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestShop.Class
{
    class transactionBLL
    {
        public int id { get; set; }
        public int dea_id { get; set; }
        public decimal grandTotal { get; set; }
        public DateTime transaction_date { get; set; }
        public decimal discount { get; set; }
        public int added_by { get; set; }
        public DataTable transactionDetails { get; set; }
    }
}
