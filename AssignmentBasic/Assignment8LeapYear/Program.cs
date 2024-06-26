using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*8) Write a program to find LEAP year by using – 
a.If – Else and logical operators.
b. Conditional operator.
c. Note – A Leap year is divisible by 4 and is not divisible by 100 but it could be divisible by 400.*/


namespace Assignment8LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year To find Out It is LeapYear Or Not : ");
            int year=int.Parse(Console.ReadLine());
            if ((year % 4==0 ) && (year %100 !=0 ))
            {
                Console.WriteLine(" Year is Leap Year " + year);
            }
            else if (year%400 ==0)
            {
                Console.WriteLine("Year is Leap Year : " + year);
            }
            else
            {
                Console.WriteLine("not leap year ");
            }
            Console.ReadKey();  
        }
    }
}
