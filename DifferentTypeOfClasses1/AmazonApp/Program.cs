using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //  Customer customer = new Customer();       //cONCRETE CLASS MAIN METHOD   //person=Abstract class 
              WholeSaleSupplier customer = new Supplier();   //SEALED CLASS 
               customer.CustomerId = 100;
               customer.Name = "Test";
               customer.Address = "mooncity";
               customer.City = "pune";
               customer.fees = 1200;
               Console.WriteLine(customer.changeAddress(customer.Address,"suncity"));
               Console.ReadKey();


        }
    }
}
