using System.IO;

namespace MyClasses
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public Person(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                Person? p = obj as Person;
                return (FirstName == p.FirstName) && (LastName == p.LastName) && (Address.Equals(p.Address));
            }
        }
}   }
