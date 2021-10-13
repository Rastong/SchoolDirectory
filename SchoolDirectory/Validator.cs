using System;
using System.Collections.Generic;
using System.Text;

namespace Validator
{
    class Validator
    {
        //
        public static double GetNumber()
        {
            double result = 0;

            while(true)
            {
                try
                {
                    Console.WriteLine("Please enter the fee of the student");
                    result = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was not a number. Try again.");
                }
            }

            return result;
        }

        public static double GetNumber(int min)
        {
            double result = 0;
            while (true)
            {
                
                result = GetNumber();
                if(result < min)
                {
                    Console.WriteLine($"That value is too low, please enter a number above {min}.");
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        public static bool getContinue()
        {
            bool result = true;

            while(true)
            {
                Console.WriteLine("Would you like to keep running the program? y/n");
                string choice = Console.ReadLine().ToLower().Trim();
                if(choice == "y" || choice == "yes")
                {
                    result = true;
                    break;
                }
                else if (choice == "n" || choice == "no")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid choice.");
                }
            }

            return result;
        }

        public static bool getContinue(string message)
        {
            bool result = true;

            while (true)
            {
                Console.WriteLine($"{message} y/n");
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y" || choice == "yes")
                {
                    result = true;
                    break;
                }
                else if (choice == "n" || choice == "no")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid choice.");
                }
            }

            return result;
        }

        public static int getRandom(int x)
        {
            Random rando = new Random();
            return rando.Next(1, x);
        }

        public static int getRandom(int min,int x)
        {
            Random rando = new Random();
            return rando.Next(min, x);
        }

        public static bool isAbove(int value, int min)
        {
            if (value > min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isAboveOrEqual(int value, int min)
        {
            if (value >= min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isEqual(int x, int y)
        {
            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GetNumberYear()
        {
            int result = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the year of the student.");
                    result = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was not a number. Try again.");
                }
            }

            return result;
        }

        public static double GetNumberYear(int min)
        {
            double result = 0;
            while (true)
            {

                result = GetNumberYear();
                if (result < min)
                {
                    Console.WriteLine($"That value is too low, please enter a number above {min}.");
                }
                else
                {
                    break;
                }
            }

            return result;
        }
        public static double GetNumberSalary()
        {
            double result = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the salary of the staff.");
                    result = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was not a number. Try again.");
                }
            }

            return result;
        }

        public static double GetNumberSalary(int min)
        {
            double result = 0;
            while (true)
            {

                result = GetNumberSalary();
                if (result < min)
                {
                    Console.WriteLine($"That value is too low, please enter a number above {min}.");
                }
                else
                {
                    break;
                }
            }

            return result;
        }
        
        public static bool AddPerson()
        {
            bool result = true;

            while (true)
            {
                Console.WriteLine("Would you like to add a student of staff? y/n");
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y" || choice == "yes")
                {
                    result = true;
                    break;
                }
                else if (choice == "n" || choice == "no")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid choice.");
                }
            }

            return result;
        }
        

        public static string GetName()
        {
            Console.WriteLine("What is the name of the person?");
            string input = Console.ReadLine();
            return input;
        }
        public static string GetAddress()
        {
            Console.WriteLine("What is the address of the person?");
            string input = Console.ReadLine();
            return input;
        }
        public static string GetProgram()
        {
            Console.WriteLine("What is the program of the person?");
            string input = Console.ReadLine();
            return input;
        }
        public static string GetSchool()
        {
            Console.WriteLine("What is the school of the person?");
            string input = Console.ReadLine();
            return input;
        }
    }
}
