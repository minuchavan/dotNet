using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* DisposePattern disposePattern = new DisposePattern();    explicitly called dispose method
            disposePattern.Dispose();*/

            using(DisposePattern pattern=new DisposePattern())
            {
                Console.WriteLine("enter");
            }
        
        }
       
    }
}
