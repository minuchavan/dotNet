using System;
using System.Collections.Generic;

namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            Stack<string> BookStack = new Stack<string>();
            Console.WriteLine("stack: the data which is stored in stack is : ");
            
            BookStack.Push("1. Think and Grow Rich");
            BookStack.Push("2. The Power of Positive Thinking");
            BookStack.Push("3. The 7 Habits of Highly Effective People");
            BookStack.Push("4. The 5 AM Club");
            BookStack.Push("5. The Power of Now");
            BookStack.Push("6. Mindset");
            Console.WriteLine(" ");
           
            foreach (string book in BookStack)
            {
                Console.WriteLine( book);
            }
            Console.WriteLine(" ");
            BookStack.Pop();
            Console.WriteLine("After Pop Operation : ");
            Console.WriteLine(" ");
            foreach (string book in BookStack)
            {
                Console.WriteLine(book);
            }
            Console.ReadKey();
        }
    }
}
