using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntity
{
    public class Transaction
    {
        public int ViewerID { get; set; }
        public int TransactionID { get; set; }
        public string BankDetails { get; set; }
        public string ModeOfPayment { get; set; }
        public int Amount { get; set; }
    }
}
