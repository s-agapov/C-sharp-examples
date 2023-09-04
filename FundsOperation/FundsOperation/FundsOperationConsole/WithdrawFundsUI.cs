using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsOperationConsole
{
    internal class WithdrawFundsUI
    {
        public WithDrawFundsWorkflow workflow = new();
        public string card = "";
        public string? PIN;

        public void enterCard()
        {
            Console.WriteLine("Enter card number:");

            string? card_number = Console.ReadLine();
            if (card_number != null & card_number.Length != 6)
            {
                Console.WriteLine("Неверные данные карты:");
            }
            else
            {
                card = card_number;
            }
        }

        public bool enterPIN()
        {
            Console.WriteLine("Enter PIN:");
            PIN = Console.ReadLine();
            bool valid = false;
            if (PIN != null)
            {
                valid = workflow.ValidatePin(card, PIN);
            }
            return valid;
        }

        public void selectAccount()
        {
            Console.Write("Select account: ");
            string ch = Console.ReadLine();
            int n_acc = Convert.ToInt16(ch);
            workflow.selectAccount(n_acc);

            Console.WriteLine("Account selected: " + workflow.account);   
        } 
  
        public double enterAmount()
        {   

            Console.Write("Enter amount to withdraw: ");
            double res = workflow.enterAmount();
            return res;
        }

        public void displayAccounts()
        {   
       
            foreach (var item in workflow.accounts.Select((value, ind) => (ind, value)))
            {
                Console.WriteLine($"{item.ind}: {item.value}");
            }
        }
    }
}
