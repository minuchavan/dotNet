using System;

namespace AmazonApp
{
    abstract class Customer: Person
    {
        public int CustomerId { get; set; }
        public Customer() 
        {
            Console.WriteLine("Customer Class constructor called.");
        }

        public override string changeAddress(string old, string newAdd)
        {
            return String.Format($"Customer {Name} has changed his/her address from {old} to {newAdd}.!");
        }
    }
}
