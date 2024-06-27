using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCount
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }

        public Customer()
        { }
        public Customer(int id, String name, String city)
        {
            CustomerID = id;
            CustomerName = name;
            City = city;
        }

        public void display() 
        {
            Console.WriteLine($"{CustomerID}--{CustomerName}--{City}");
        }

        public static Dictionary<String,int> CountCities(LinkedList<Customer> list)
        {
            Dictionary<String,int> map = new Dictionary<String,int>();
            foreach (Customer c in list)
            {
                if (map.ContainsKey(c.City))
                {
                    map[c.City]++;
                }
                else
                {
                    map[c.City] = 1;
                }
            }
            return map;
        }
    }
}
