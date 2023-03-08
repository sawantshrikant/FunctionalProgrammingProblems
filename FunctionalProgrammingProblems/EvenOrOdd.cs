using System;

namespace FunctionalProgrammingProblems
{
    public class EvenOrOdd
    {
        public void CheckEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is even", num);
            }
            else
            {
                Console.WriteLine("{0} is odd", num);
            }
        }
    }
}
