using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsOperationConsole
{
    internal class CustomerLocator
    {
        public List<Customer> customers = new();
        public string Path { get; init; }
        private StreamReader textIn;

        public CustomerLocator(string path)
        {
            if (File.Exists(path))
            {
                //Console.WriteLine("Открываем файл");
                FileStream fs = new(path, FileMode.Open, FileAccess.Read);
                textIn = new(fs);
                Path = path;
            }

        }

        //Читаем список пользователей из базы
        public void readCustomers()
        {
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(',');
              //  Console.WriteLine(row);

                Customer customer = new();
                customer.ID = columns[0];
                customer.Name = columns[1];
                customers.Add(customer);

            }

        }

        public Customer? findByID(string id)
        {
            return customers.Find(x => x.ID == id);
        }
    }

}
