using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author.details();
            Console.WriteLine("Author Name:"+Author.name);
            Console.WriteLine("Author Language:"+Author.technology);
            Console.WriteLine("Author Articles till now "+Author.T_no);
            Console.ReadKey();
        }
    }
}
