using System;
namespace ApplicationDev.week_03
{
    public class SwapValue
    {
        public static void swapValue(int a, int b)
        {
            Console.WriteLine("Before swap");
            Console.WriteLine($"a = {a} and b = {b}");

            int c = 0;

            c = a;
            a = b;
            b = c;

            Console.WriteLine("After swap");
            Console.WriteLine($"a = {a} and b = {b}");
        }
    }
}

