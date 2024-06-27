using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var allcustomers=from Customer in GetAllCustomer() select Customer;
            foreach (var customer in allcustomers)
            {
                Console.WriteLine($"customer {customer.ContactName} lives in City {customer.City}");
            }
            Console.ReadKey();
            
        }
        private static List<Customer> GetAllCustomer()
        {
            return new List<Customer>()
            {
                new Customer(){CutomerId=101, ContactName="Minal Chavan" ,City="Nandurbar"},
                new Customer(){CutomerId=102, ContactName="Nikita Bhamre" ,City="Nashik"},
                new Customer(){CutomerId=103, ContactName="Neha Shinde" ,City="Sangli"},
                new Customer(){CutomerId=104, ContactName="Snehal Chavan" ,City="Nandurbar"},
                new Customer(){CutomerId=105, ContactName="Minu bagul " ,City="Sangli"},

            };
        }
    }
}
