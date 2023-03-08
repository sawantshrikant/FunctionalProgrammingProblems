using FunctionalProgrammingProblems;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to FunctionalProgrammingProblems!");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Choose an option to execute\n1.Flip coin\n2.Exit");
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
                    flag = false;
                    break;
            }
        }
    }
}
