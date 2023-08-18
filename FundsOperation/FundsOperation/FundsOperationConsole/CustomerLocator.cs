using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsOperationConsole
{
    internal class CustomerLocator
    {
        public List<Customer> customers;

        //Читаем список пользователей из базы
        public void readCustomers(string path)
        {
            if (File.Exists(path))
            {

                Console.WriteLine("Открываем файл");
                FileStream fs = new(path, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new(fs);

                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split(',');
                    Console.WriteLine(row);

                    Customer customer = new();
                    customer.Name = columns[0];
                    customer.PIN = columns[1];
                    customers.Add(customer);

                    customers.Add(new Customer() { Name = columns[0], PIN = columns[1] });

                }
            }
        }

        //Находим по имени
        public Customer? findByName(string name)
        {
            return customers.Find(x => x.Name == name);
        }
    }
}
