using System;
using FunctionalProgrammingProblems;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to FunctionalProgrammingProblems!");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Choose an option to execute\n1.Flip coin\n2.Leap Year\n3.Power Of Two\n4.Harmonic Number\n5.Factors\n6.Compute Quotient and Remainder\n7.Swap Two Numbers\n8.Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flip = new FlipCoin();
                    Console.WriteLine("Enter num of flips");
                    int num = Convert.ToInt32(Console.ReadLine());
                    flip.Flip(num);
                    break;
                case 2:
                    LeapYear leapYear = new LeapYear();
                    Console.WriteLine("Enter year (yyyy): ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    leapYear.CheckLeapYear(year);
                    break;
                case 3:
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    Console.WriteLine("Enter value of N: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    powerOfTwo.PrintPowerOfTwo(n);
                    break;
                case 4:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    Console.WriteLine("Enter value of N: ");
                    int hn = Convert.ToInt32(Console.ReadLine());
                    harmonicNumber.PrintHarmonicNumber(hn);
                    break;
                case 5:
                    Factors factors = new Factors();
                    Console.WriteLine("Enter a number: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    factors.PrimeFactors(number);
                    break;
                case 6:
                    ComputeQuotient computeQuotient = new ComputeQuotient();
                    Console.WriteLine("Enter dividend: ");
                    int dividend = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter divisor: ");
                    int divisor = Convert.ToInt32(Console.ReadLine());
                    computeQuotient.ComputeQuotientAndRemainder(dividend, divisor);
                    break;
                case 7:
                    Console.WriteLine("Enter two numbers to be swapped: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    int y = Convert.ToInt32(Console.ReadLine());
                    SwapTwoNumbers swap = new SwapTwoNumbers();
                    swap.SwapNumbers(ref x, ref y);
                    Console.WriteLine("After swapping: x = " + x + ", y = " + y);
                    break;
                case 8:
                    flag = false;
                    break;
            }
        }
    }
}
