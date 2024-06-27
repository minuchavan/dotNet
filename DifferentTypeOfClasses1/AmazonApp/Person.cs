using System;

namespace AmazonApp
{
    abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public Person() { }

        public Person(int id,String name,String city,string add) 
        {
            Id=id; Name=name; City=city;
            Address = add;
        }

        public abstract String changeAddress(String old, String newAdd);
       
    }
}
