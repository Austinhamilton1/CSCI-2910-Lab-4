using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_2910_Lab_4
{
    public class Person : IComparable
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public Address Address { get; init; }

        public Person(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public int CompareTo(object? obj)
        {
            //cast the object as a Person and then compare their last names
            Person other = obj as Person;
            return this.LastName.CompareTo(other.LastName);
        }

        public override string ToString()
        {
            return $"{FirstName}|{LastName}|{Address.ToString()}";
        }
    }
}
