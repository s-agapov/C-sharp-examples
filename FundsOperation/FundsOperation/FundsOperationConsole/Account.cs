using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsOperationConsole
{
    internal class Account
    {

        public string CustomerID { get; set; } = "";
        public string AccountID { get; set; } = "";
        public double Balance { get; set; }
        public Account()
        {

        }

        public Account(string customerID, string accountID)
        {
            CustomerID = customerID;
            AccountID  = accountID;
        }

        public bool isAmountAvailable(double withdraw_sum)
        {
            if (withdraw_sum <= Balance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool withdraw(double withdraw_sum)
        {
            if (withdraw_sum <= Balance)
            {
                Balance -= withdraw_sum;
                return true;
            } else
            {
                return false;
            }

        }

        public override string ToString()
        {
            return "Customer ID:" + CustomerID + ", Account ID: " + AccountID + "  Balance: " + Balance;
        }

    }
}
