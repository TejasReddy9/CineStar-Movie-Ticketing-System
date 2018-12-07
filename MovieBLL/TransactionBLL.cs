using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieEntity;
using MovieException;
using MovieDAL;
using System.Text.RegularExpressions;

namespace MovieBLL
{
    public class TransactionBLL
    {
        public static bool ValidatePaymentDetails(Transaction transactionDetails)
        {
            bool IsValid = true;
            StringBuilder sb = new StringBuilder();
            if (transactionDetails.BankDetails.Length != 16 && !Regex.IsMatch(transactionDetails.BankDetails, @"^\d{16}$"))
            {
                IsValid = false;
                sb.Append(Environment.NewLine + "Invalid Card Details");
            }
            if(transactionDetails.Amount == 0)
            {
                IsValid = false;
                sb.Append(Environment.NewLine + "Amount can't be Zero.");
            }
            if(transactionDetails.ModeOfPayment == string.Empty)
            {
                IsValid = false;
                sb.Append(Environment.NewLine + "Select Mode Of Payment.");
            }
            if(transactionDetails.TransactionID < 0)
            {
                IsValid = false;
                sb.Append(Environment.NewLine + "Invalid Transaction ID");
            }
            if (transactionDetails.ViewerID < 0)
            {
                IsValid = false;
                sb.Append(Environment.NewLine + "Invalid Viewer ID");
            }
            if (IsValid == false)
                throw new MovieException.MTSException(sb.ToString());
            return IsValid;
        }

        public static bool MakePaymentBLL(int Mode, Transaction transactionDetails)
        {
            bool PaymentAccepted = false;
            try
            {
                if (Mode==1 && ValidatePaymentDetails(transactionDetails))
                {
                    PaymentAccepted = MovieDAL.TransactionDAL.MakePaymentDAL(Mode, transactionDetails);
                }
                if(Mode==0)
                {
                    PaymentAccepted = MovieDAL.TransactionDAL.MakePaymentDAL(Mode, transactionDetails);

                }
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return PaymentAccepted;
        }


        public static List<Transaction> GetTransactionHistoryBLL()
        {
            List<Transaction> transactionList = null;
            try
            {
                transactionList = MovieDAL.TransactionDAL.GetTransactionHistoryDAL();
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return transactionList;
        }
    }
}
