using System;

namespace AmazonApp
{
    internal class Supplier : Person
    {
        public int SupplierId { get; set; }
        public override string changeAddress(string old, string newAdd)
        {
            throw new NotImplementedException();
        }
    }
}
