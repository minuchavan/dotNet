using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5) Write a program to swap two variables using a third variable by Console Application.

namespace Assignment5Swaping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Num1 : ");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Num2 : ");
            int num2 = int.Parse(Console.ReadLine());
            int temp;

            Console.WriteLine( $" Given Number is {num1}  {num2} ");
            temp = num1;
            num1= num2;
            num2 = temp;
            Console.WriteLine(" ");
            Console.WriteLine($" Swapping of Number {num1} {num2}");
            Console.ReadKey();

        }
    }
}
