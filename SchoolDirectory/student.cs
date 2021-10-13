using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDirectory
{
    class student : Person
    {
        // Properties
        private string Program;
        private int Year;
        private double Fee;

        // Constructor
        public student(string name, string address, string program, int year, double fee): base (name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public student(): base()
        {
            Program = "Unassigned";
            Year = 0;
            Fee = 0;
        }

        // Methods
        public override string ToString()
        {
            return base.ToString() + $", Student : Program : {Program} , Year : {Year} , Fee : ${Fee}.";
        }

    }
}
