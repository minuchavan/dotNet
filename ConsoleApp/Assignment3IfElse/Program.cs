using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Welcome !! {name} {age} to Adventure Center !! ");
            try
            {
                if (age < 80)
                {
                    Console.WriteLine($"{name}! Your ride is ready..");
                }
                else
                {
                    Console.WriteLine($"{name} sorry you cannot do this activity");
                }
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("ex.Message");
               
            }
        }
    }
}
