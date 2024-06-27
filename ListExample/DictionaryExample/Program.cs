using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> employees= new Dictionary<int,string>();
            employees.Add(1, "Minal Chavan");
            employees.Add(2, "Nikita Bhamre");
            employees.Add(3, "Neha Shinde");
            employees.Add(4, "Archana Shete");
            employees.Add(5, "Priya Wagh");
            employees.Add(6, "Shruti Cdac");

            foreach (int key in employees.Keys)
            {
                Console.WriteLine($"Employee Id : {key} :: Employee Name : {employees[key]}");
            }
            Console.ReadKey();

        }
    }
}
