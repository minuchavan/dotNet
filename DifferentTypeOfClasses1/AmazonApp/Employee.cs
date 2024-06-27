using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonApp
{
    sealed class Employee:Person
    {
        public int EmployeeId { get; set; }

        public Employee()
        {
            Console.WriteLine("Employee class default constructor called.!");
        }

        public override string changeAddress(string old, string newAdd)
        {
            throw new NotImplementedException();
        }
    }
}
