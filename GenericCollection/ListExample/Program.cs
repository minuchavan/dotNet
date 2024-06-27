using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //find out the count according to city 
          /*  var finalResult = from customer in GetAllCustomers()
                              group customer by customer.City into k
                              select new { City = k.Key, Count = k.Count() };*/

            //Object Initializer
            //Customer customer=new Customer() { CustomerId= 1 };
            /* foreach (Customer customer in GetAllCustomers())
             {
                 Console.WriteLine($"Customer {customer.ContactName} lives in city {customer.City}!");

             }
             Console.ReadKey();*/

            List<Result> finalResult = new List<Result>();
            foreach (Customer customer in GetAllCustomers())
            {
                Result result = finalResult.Find(delegate (Result res) { return res.City == customer.City; });
                if (result != null)
                {
                    result.Count++;
                }
                else
                {
                    finalResult.Add(new Result() { City = customer.City, Count = 1 });
                }
                //Console.WriteLine($"Customer {customer.ContactName} lives in city {customer.City}!");
            }
            foreach (var r in finalResult)
            {
                Console.WriteLine($"In city {r.City} there is/are {r.Count} number of customers!");
            }
            Console.ReadKey();


        }
        private static List<Customer> GetAllCustomers()
        {
            return new List<Customer>()
            {
                new Customer(){ CustomerId=100,ContactName="Alisha C.",City="Mumbai" },
                new Customer(){ CustomerId=101,ContactName="Manisha K.",City="Mumbai" },
                new Customer(){ CustomerId=102,ContactName="Pravinkumar R. D.",City="Pune" },
                new Customer(){ CustomerId=103,ContactName="Manish Kaushik",City="Bangalore" },
            };
        }
    }
}
