using System;

namespace FunctionalProgrammingProblems
{
    public class SwapTwoNumbers
    {
        public void SwapNumbers(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
