using System;
using System.Collections.Generic;

namespace SchoolDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>()
            {
                new student("Charlie", "24 Hickory St. " , "Math", 2 , 2400),
                new Staff("Jake", "69 Blob St.", "Washington High", 67000),
                new student("Susie", "590 Forever St. " , "Engish", 2 , 2400),
                new Staff("Josh", "314 Pie Rd", "Lincoln Elementary", 58000),
                new student("Amaya", "420 High Rd" , "Botony", 2 , 2400),
                new Staff("Ethan", "66 Route Ave", "Raston Middle", 74000),
                new student("George", "11 No Idea Park" , "Math", 2 , 2400),
                new Staff("Josie","210488 Long Rd", "Georgia Tech", 123000),
                new student(),
                new Staff()
            };

            bool AddPerson = Validator.Validator.AddPerson();
            if (AddPerson)
            {
                Person result = StudentOrStaff();
                People.Add(result);
            }
            
            foreach(Person x in People)
            {
                Console.WriteLine(x.ToString());
            }
        }
        public static Person StudentOrStaff()
        {
            Person result = new Person();
            while (true)
            {
                Console.WriteLine("Would you like to add a student or staff? student/staff");
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "student")
                {
                    student person = AddStudent();
                    result = person;
                    break;
                }
                else if (choice == "staff")
                {
                    Staff person = AddStaff();
                    result = person;
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid choice.");
                }
                
            }
            return result;
        }

        public static student AddStudent()
        {
            string name = Validator.Validator.GetName();
            string address =Validator.Validator.GetAddress();
            string program = Validator.Validator.GetProgram();
            int year = Validator.Validator.GetNumberYear();
            double fee = Validator.Validator.GetNumber();
            student person = new student(name, address, program, year, fee);
            return person;
        }

        public static Staff AddStaff()
        {
            string name = Validator.Validator.GetName();
            string address = Validator.Validator.GetAddress();
            string school = Validator.Validator.GetSchool();
            Double salary = Validator.Validator.GetNumberSalary();
            Staff person = new Staff(name, address, school, salary);
            return person;

        }
    }
}
