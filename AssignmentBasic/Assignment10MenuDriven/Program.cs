using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//10) Using a switch case write a menu driven program to perform basic calculations of two user entered numbers.

namespace Assignment10MenuDriven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number1 ");
            double num1 =double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Number2 ");
            double num2 = double.Parse(Console.ReadLine());

            int ch;
            do
            {
                Console.WriteLine( "Basic Math Operations : ");
                Console.WriteLine( " 1. Addition ");
                Console.WriteLine(" 2 . Subtraction ");
                Console.WriteLine(" 3 . Multiplication ");
                Console.WriteLine(" 4 . Division ");
                Console.WriteLine(" 5 . Modulus ");
                Console.WriteLine(" 6 . Exit ");
                Console.WriteLine(" Enter Your Choice : ");
                ch=int.Parse(Console.ReadLine());


                switch (ch)
                {
                         case 1:
                              double add= num1 + num2;
                              Console.WriteLine( $"The Addition Of {num1} and {num2} is  :-> {add}");
                              break;

                        case 2:
                            double sub = num1 - num2;
                            Console.WriteLine($"The Subtraction Of {num1} and {num2} is  :-> {sub}");
                        break;

                        case 3:
                            double mul = num1 * num2;
                           Console.WriteLine($"The Multiplication Of {num1} and {num2} is  :-> {mul}");
                             break;

                        case 4:

                            double div = num1 / num2;
                            Console.WriteLine($"The Division Of {num1} and {num2} is  :-> {div}");
                            break;

                        case 5:
                            double mod= num1 % num2;
                            Console.WriteLine($"The Modulus  Of {num1} and {num2} is  :-> {mod}");
                            break;

                        case 6:
                           Console.WriteLine("Exit !!!");
                           break;

                    default:
                        Console.WriteLine("Invalid Choice...Please Enter valid Choice between 1 to 6 ");
                        break;
                }


            } while (ch!=6);
            Console.ReadKey();
        }
    }
}
