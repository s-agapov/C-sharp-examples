using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsOperationConsole
{
    internal class WithDrawFundsWorkflow
    {
        public List<Account> accounts = new();

        public CustomerLocator locator = new("Customers.txt");

        public Customer customer;

        public Account account;

        public bool ValidatePin(string card, string pin)
        {
            locator.readCustomers();
            customer =  locator.findByID(card);
            bool res = customer.validatePIN(pin);
            return res;
        }

        public void getAccounts(string path)
        {

            if (File.Exists(path))
            {

               // Console.WriteLine("Открываем файл");
                FileStream fs = new(path, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new(fs);


                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split(',');
                    //  Console.WriteLine(row);
                    if (columns[0] == customer.ID)
                    {
                        Account account = new();
                        account.CustomerID = columns[0];
                        account.AccountID = columns[1];
                        account.Balance = Convert.ToDouble(columns[2]);
                        accounts.Add(account);
                    }
                }
            }


        }

        public void selectAccount(int n_acc)
        {
            account = accounts[n_acc];
        }

        public double enterAmount()
        {
            double res = 0;
            Console.Write("Enter amount to withdraw: ");
            res = Convert.ToDouble(Console.ReadLine());
            return res;
        }

        public void withdraw(double sum)
        {
            if (account.isAmountAvailable(sum))
            {
                account.withdraw(sum);
            }

        }
    }
}
