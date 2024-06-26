using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//3) Write a program to accept 5 marks from the user and calculate their sum using Console Application.

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Subjects : ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Subject Marks  : ");
                int m = int.Parse(Console.ReadLine());
                sum += m;
            }
            Console.WriteLine($"Sum of Marks  : {sum}");
            Console.ReadKey();
        }
    }
}
