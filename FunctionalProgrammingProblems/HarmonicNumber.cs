using System;

namespace FunctionalProgrammingProblems
{
    public class HarmonicNumber
    {
        public void PrintHarmonicNumber(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("N cannot be 0.");
                return;
            }

            double harmonic = 0.0;
            string series = "1";
            for (int i = 2; i <= n; i++)
            {
                series += $" + 1/{i}";
                harmonic += 1.0 / i;
            }
            harmonic += 1.0;

            Console.WriteLine($"The {n}th harmonic number is: {harmonic}\nSeries: {series} = {harmonic:F3}");
        }
    }
}
