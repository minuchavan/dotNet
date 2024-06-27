using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2) Write a program to accept 5 marks from the user and calculate their average using Console Application.


namespace Assignment2Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "Enter Number of Subjects : ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Subject Marks  : ");
                int m=int.Parse(Console.ReadLine());
                sum += m;
            }
            int avg=sum/n;
            Console.WriteLine($"Average of Given Marks  is -> {avg} ");
            Console.ReadKey();
           
            
        }
    }
}
