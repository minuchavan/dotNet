using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable employees= new Hashtable();
            employees.Add(1000, "T");
            employees.Add(2000, "U");
            employees.Add(3000, "S");
            employees.Add(4000, "H");
            employees.Add(1000, "A");
            employees.Add(1000, "R");
            foreach (Hashtable employee in employees)
            {

            }

        }
    }
}
