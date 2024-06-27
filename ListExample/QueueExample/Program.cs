using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Console.WriteLine("Queue data : ");
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);   
            queue.Enqueue(5);
         
            foreach (int no in queue)
            {
                Console.WriteLine(no);
            }
          
            Console.WriteLine("after Dequeue :");
           
            queue.Dequeue();
            foreach (int no in queue)
            {
                Console.WriteLine(no);
            }

            Console.ReadKey();
        }
    }
}
