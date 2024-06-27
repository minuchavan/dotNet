using System;

namespace AmazonApp
{
    sealed class RetailSupplier : Supplier
    {
        public String Area { get; set; }
        public RetailSupplier()
        {
            Console.WriteLine("RetailSupplier default constructor called.");
        }
    }
}
