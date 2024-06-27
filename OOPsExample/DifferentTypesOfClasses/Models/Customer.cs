using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTypesOfClasses.Models
{
    internal class Customer : Person
    {
        public Customer() {
            Console.WriteLine("Customer class constructor executed");
        }
        public int CustomerId { get; set; }

        public override string ChangeAddress(string oldAddress, string newAddress)
        {
            return string.Format($"Customer {ContactName} has been changed from {oldAddress} to {newAddress}");
        }
    }
}
