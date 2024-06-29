using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleThreadingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread is running on Thread Id - {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Main Thread Started !!");

            Thread t1 = new Thread(new ThreadStart(job1));
            Thread t2 = new Thread(new ThreadStart(job2));
           t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
            Console.WriteLine("Main Thread Ended !");

        }
        private static void job1()
        {
            Console.WriteLine($"job-1 Thread is Running on thread Id -{Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"job - 1 and Step -{i}");
            }
        }
        private static void job2()
        {
            Console.WriteLine($"job-2 Thread is Running on thread Id -{Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"job - 2 and Step -{i}");
            }
        }
    }
}
