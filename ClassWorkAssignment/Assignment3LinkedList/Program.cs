using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> list = new LinkedList<String>();
            list.AddLast("anant");
            list.AddLast("ambani");
            list.AddLast("rahul");
            list.AddLast("nikita");
            list.AddLast("minal");
            list.AddFirst("kunal");

            Console.WriteLine( "The list is:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
