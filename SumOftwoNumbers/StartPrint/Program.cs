﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Number Of Lines : ");
            int n=int.Parse( Console.ReadLine() );
            for(int i=0; i<n;i++) {
                Console.WriteLine( " * ");
                Console.ReadLine();
        }
    }
}
