using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


/*7) Write a program to calculate Net Salary of an employee using Basic Salary based on following parameters – 
a.HRA is 20 % of basic salary.
b.DA is 40 % of basic salary.
c.PF is 10 % of Gross salary.
d.Gross Salary is Basic Salary + HRA + DA.
e. Net salary is Gross Salary – PF.
*/

namespace Assignment7Netsalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Basic Salary : ");
            int sal=int.Parse(Console.ReadLine());   //10000
            double HRA = 0.2 * sal;                  //2000
            double DA = 0.4 * sal;                   //4000
            double GrossSalary = sal + DA + HRA;     //16000
            Console.WriteLine("Gross Salary After calculation "+GrossSalary);
            double PF= 0.1 * GrossSalary;   //1600
            double netSal=GrossSalary - PF;  //14400
            Console.WriteLine(  " ");
            Console.WriteLine("Net Salary Is : "+netSal);
            Console.ReadKey();



        }
    }
}
