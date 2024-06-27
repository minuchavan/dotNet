using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTypesOfClasses.Models
{
    sealed class PrimeCustomer:Customer
    {
        public PrimeCustomer()
        {
            Console.WriteLine( "Prime Customer Class Constructor Executed !!!");
        }

        public decimal fees { get; set; } = 1400;


    }
}
