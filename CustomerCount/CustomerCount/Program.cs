using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Customer> list = new LinkedList<Customer>();
            list.AddLast(new Customer(101,"abhi","Pune"));
            list.AddLast(new Customer(102, "Raj", "Delhi"));
            list.AddLast(new Customer(103, "Rahul", "Mumbai"));
            list.AddLast(new Customer(104, "Muku", "Mumbai"));
            list.AddLast(new Customer(105, "Piyush", "Pune"));
            list.AddLast(new Customer(106, "Sunny", "jaipur"));
            list.AddLast(new Customer(107, "Rohit", "Jaipur"));
            list.AddLast(new Customer(108, "Shishu", "Jaipur"));

            foreach (Customer customer in list)
            {
                customer.display();
            }

            Dictionary<String,int> map = Customer.CountCities(list);

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.ReadKey();
        }

        
    }
}
