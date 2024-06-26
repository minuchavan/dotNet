using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6) Accept a character from a user and print its ASCII value using Console Application.

namespace Assignment6Ascii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter a character  : ");
            char c= char.Parse(Console.ReadLine());
            int ascii= c;
            Console.WriteLine( "Ascii value of character  "+ascii );
            Console.ReadKey();
        }
    }
}
