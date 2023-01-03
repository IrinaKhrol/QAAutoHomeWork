using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
     class Address
    {
        public string City;
        public string Street;
        public int NumberHome;
        public int NumberFlat;


        public Address(string city, string street, int numberHome, int numberFlat)
        {
            City = city;
            Street = street;
            NumberHome = numberHome;
            NumberFlat = numberFlat;
    }   }
}
