using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  int[,] data = new int[2, 2]
              {
                  { 1,100},
                  { 2,200}
              };

              for (int i = 0; i < 2; i++)
              {
                  for (int j = 0; j < 2; j++)
                  {
                      Console.Write($"{data[i, j]}\t");
                  }
                  Console.WriteLine(" ");
              }
              Console.ReadKey();  */

            string[,] data = new string[3, 2]
            {
                {"Minal" , "Chavan" },
                { "Nikita","Bhamre"},
                { "Sanket ","Tushar"}
            };
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write($"{data[i, j]}\t");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
