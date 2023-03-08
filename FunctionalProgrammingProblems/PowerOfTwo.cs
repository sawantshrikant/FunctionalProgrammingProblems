using System;

namespace FunctionalProgrammingProblems
{
    public class PowerOfTwo
    {
        public void PrintPowerOfTwo(int n)
        {
            if (n >= 0 && n < 31)
            {
                for (int i = 0; i <= n; i++)
                {
                    int powerOfTwo = (int)Math.Pow(2, i);
                    Console.WriteLine("2^" + i + " = " + powerOfTwo);
                }
            }
            else
            {
                Console.WriteLine("N should be between 0 and 31");
            }
        }
    }
}
