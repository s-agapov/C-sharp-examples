using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsOperationConsole
{
    internal class Customer
    {
        public string Name { get; set; }
        public string PIN { get; set; }

        public bool validatePIN(string pin)
        {
            if (pin == PIN) { return true; }

            else { return false; }
        }
    }
}
