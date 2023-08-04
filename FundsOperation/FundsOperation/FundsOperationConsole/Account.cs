using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsOperationConsole
{
    internal class Account
    {
        public string ID { get; set; }
        public double Balance { get; set; }

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

    }
}
