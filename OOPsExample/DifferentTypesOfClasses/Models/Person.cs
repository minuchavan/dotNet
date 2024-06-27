﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTypesOfClasses.Models
{
     abstract class Person
    {

        public Person()
        {
            Console.WriteLine( "Abstract Class Constructor Executed!!!!!");
        }
        public int SocialId { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public abstract string ChangeAddress(string oldAddress,string newAddress);




    }
}
