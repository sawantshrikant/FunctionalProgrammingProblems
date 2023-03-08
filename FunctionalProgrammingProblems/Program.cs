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
            Console.WriteLine("Choose an option to execute\n1.Flip coin\n2.Leap Year\n3.Power Of Two\n4.Exit");
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
                    flag = false;
                    break;
            }
        }
    }
}
