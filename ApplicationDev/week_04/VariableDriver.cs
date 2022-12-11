using System;
namespace ApplicationDev.week_04
{
    public class VariableDriver
    {
        public static void Display()
        {
            VariableEncap v1 = new VariableEncap();

            Console.WriteLine($"My name is {v1.Name}");
            Console.WriteLine($"My name is {v1.Age}");
        }
    }
}

