using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 9) Write a program to accept the basic salary and total sales amount from a salesperson and calculate commission according to the sales amount. Display the net salary and commission earned.
 Sales Amount in Rs.                   Commission(%) on Sales
5,000 to 7,500                                  3
7,501 to 10,500                                  8
10,501 to 15,000                                11
15,000 to above                                15
 */
namespace Assignment9commisionNetSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Salary : ");
            int Basicsal=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Total sales Amount : ");
            int salesAmount=int.Parse(Console.ReadLine());
            double comm;
            if(salesAmount>=5000 && salesAmount <=7500 )
            {
                 comm= 0.3 * salesAmount;
            }
            else if(salesAmount>=7501 && salesAmount<=10500)
            {
                 comm=0.8 * salesAmount;
            }
            else if (salesAmount >= 10501 && salesAmount <= 15000)
            {
                comm = 1.1 * salesAmount;
            }
            else
            {
                comm=1.5*salesAmount;
            }
            Console.WriteLine("commision Earned  on Given saleAmount is " + comm);
            double netSal= Basicsal + comm;
            Console.WriteLine("Net salary  Is  : "+netSal);

            Console.ReadKey();


        }
    }
}
