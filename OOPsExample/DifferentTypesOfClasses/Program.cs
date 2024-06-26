using DifferentTypesOfClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTypesOfClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Customer customer = new Customer();       //cONCRETE CLASS MAIN METHOD   //person=Abstract class 
         /*  PrimeCustomer customer = new PrimeCustomer();   //SEALED CLASS 
            customer.CustomerId = 100;
            customer.ContactName = "Test";
            customer.Address = "mooncity";
            customer.City = "pune";
            customer.fees = 1200;
            Console.WriteLine(customer.ChangeAddress(customer.Address,"suncity"));
            Console.ReadKey();*/


            //PARTIAL CLASS MAIN METHOD     
            BasicMath basicMath = new BasicMath();
            Console.WriteLine("addition of 2 number is : "+basicMath.Addition(10, 20) );
            Console.WriteLine("substraction of 2 number is : " + basicMath.Substraction(100, 20));
            Console.WriteLine("multiplication of 2 number is : " + basicMath.Multiplication(100, 20));
             Console.ReadKey();

            //ANONYMOUS CLASS 
          //  var CustomerOrderClass = new { };

            var CustomerOrderClass = new {CustomerId=1200, ContactName="Alisha B",City="Pune",OrderId=23900,OrderDate=DateTime.Now};


        }
    }
}
