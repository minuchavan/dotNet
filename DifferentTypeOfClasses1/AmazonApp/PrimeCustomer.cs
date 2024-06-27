using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonApp
{
    sealed class PrimeCustomer: Customer
    {
        public PrimeCustomer()
        {
            Console.WriteLine("Prime customer class Default Constructor called.");
        }
        public decimal fees { get; set; } = 1400;
    }
}
