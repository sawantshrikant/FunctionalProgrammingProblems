using System;

namespace FunctionalProgrammingProblems
{
    public class ComputeQuotient
    {
        public void ComputeQuotientAndRemainder(int dividend, int divisor)
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
