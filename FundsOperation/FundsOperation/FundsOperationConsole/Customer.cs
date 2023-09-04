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
        public string ID { get; set; }

        public bool validatePIN(string pin)
        {
            if (pin == ID.Substring(3,3))
            { return true; }

            else { return false; }
        }

        public override string ToString()
        {
            return "Name: " + Name + "   ID: " + ID;
        }
    }
}
