using System;

namespace FunctionalProgrammingProblems
{
    public class Factors
    {
        public void PrimeFactors(int number)
        {
            Console.WriteLine("Prime factors of " + number + " are: ");

            // Traverse till i*i <= N instead of i <= N for efficiency
            for (int i = 2; i * i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.Write(i + " ");
                    number /= i;
                }
            }

            if (number > 1)
            {
                Console.Write(number);
            }

            Console.WriteLine();
        }
    }
}
