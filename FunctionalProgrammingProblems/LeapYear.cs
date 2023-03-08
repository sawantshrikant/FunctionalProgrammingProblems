using System;

namespace FunctionalProgrammingProblems
{
    public class LeapYear
    {
        public void CheckLeapYear(int year)
        {
            if (year.ToString().Length != 4)
            {
                Console.WriteLine("Please enter a 4 digit year.");
                return;
            }

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }
    }
}
