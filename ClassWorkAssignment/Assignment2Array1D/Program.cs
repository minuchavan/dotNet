using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Array1D
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* string[] books = new string[5] { "Book1","Book2","Book3","Book4","Book5"};
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]);
            }
            Console.ReadKey();*/

            int[] arr= new int[5];
            arr[0]=1;
            arr[1]=2;
            arr[2]=3;
            arr[3]=4;
            arr[4]=5;
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
