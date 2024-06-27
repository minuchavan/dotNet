using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonApp
{
    sealed class WholeSaleSupplier
    {
        public String Area { get; set; }

        public WholeSaleSupplier()
        {
            Console.WriteLine("WholeSaleSupplier default constructor called.");
        }
    }
}
