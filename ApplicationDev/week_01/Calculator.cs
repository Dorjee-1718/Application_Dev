using System;
namespace ApplicationDev.week_01
{
    public class Calculator
    {
        public static int Addition(int a, int b)
        {
            var sum = a + b;
            return sum;
        
        }

        public static int Subtraction(int a, int b)
        {
            var difference = a - b;
            return difference;
        }

        public static int Multiplication(int a, int b)
        {
            var multiplication = a * b;
            return multiplication;
        }

        public static int Division(int a, int b)
        {
            var division = a / b;
            return division;
        }
        public static void Calculation()
        {

            int num1 = 0;
            int num2 = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine("\n");
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("Enter 1 for addition: ");
            Console.WriteLine("Enter 2 for subtraction: ");
            Console.WriteLine("Enter 3 for multilpcation: ");
            Console.WriteLine("Enter 4 for division: ");
            Console.Write("Your option? ");

            var a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    Console.WriteLine($"Sum of {num1} and {num2} = {Calculator.Addition(num1, num2)}");
                    break;
                case "2":
                    Console.WriteLine($"Difference of {num1} and {num2} = {Calculator.Subtraction(num1, num2)}");
                    break;
                case "3":
                    Console.WriteLine($"Multiplication of {num1} and {num2} = {Calculator.Multiplication(num1, num2)}");
                    break;
                case "4":
                    Console.WriteLine($"Division of {num1} and {num2} = {Calculator.Division(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

            Console.WriteLine("Press 'Y' key if you want to use the calculator again:");
            Console.WriteLine("Press any other key if you want to exit:");

            if (Console.ReadKey().Key == ConsoleKey.Y)
                Calculation();

            /*
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
            */

        }

    }

}

