using System;
namespace ApplicationDev.week_03
{
    public class OddEven
    {
        public static void checkOddEven(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is even");
            }
            else
            {
                Console.WriteLine($"{a} is odd");
            }
        }
    }
}

