﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOftwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            Console.WriteLine( "Enter Number 1 : ");
            /*int num=int.parse(Console.ReadLine());*/
             num1=Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine( "Enter Number 2 : ");
             num2=Convert.ToInt32( Console.ReadLine() );
            sum=num1 + num2;
            Console.WriteLine("the sum is  :"+sum);
            Console.ReadLine();


        }
    }
}
