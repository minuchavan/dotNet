﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOpearationbyUSING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Group011\\Desktop\\DotNet\\dotNet\\message.txt";
            using (StreamWriter sw = new StreamWriter(path,true))
            {
                sw.WriteLine("Welcome To India ");
                sw.WriteLine("Welcome To Maharashtra ");
                sw.Close();
            }
            using (StreamReader sr = new StreamReader(path))
            {
               // Console.WriteLine(sr.ReadToEnd());
              
                while (sr.Peek() != -1)
                {
                   // Console.WriteLine(sr.ReadLine());
                   // Console.WriteLine(sr.Read());     ASCII VALUE PRINT
                    Console.WriteLine(Convert.ToChar(sr.Read()));
                }
                sr.Close();
                Console.ReadKey();
            }
         
        }
    }
}
