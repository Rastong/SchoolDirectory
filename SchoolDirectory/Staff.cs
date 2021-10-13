using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDirectory
{
    class Staff : Person
    {
        // Properties
        private string School;
        private double Salary;

        // Constructor
        public Staff(string name, string address, string school, double salary): base(name, address)
        {
            School = school;
            Salary = salary;
        }

        public Staff() : base()
        {
            School = "Unassigned";
            Salary = 0;
        }

        // Methods
        public override string ToString()
        {
            return base.ToString() + $", Staff : School : {School} , Salary : ${Salary}.";
        }

    }
}
