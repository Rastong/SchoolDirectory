using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDirectory
{
    class Person
    {
        // Properties
        private string Name;
        private string Address;

        // Constructor
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public Person() 
        {
            Name = "John Doe";
            Address = "N/A";
        }

        // Methods
        public override string ToString()
        {
            return $"Person : Name : {Name} , Address : {Address}";
        }

    }
}
