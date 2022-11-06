using System;
namespace ApplicationDev.week_02
{
    public class ControlStatement
    {
        public void IfElse()
        {
            Console.WriteLine("Enter the 1st number: ");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number: ");
            var b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine($"{a} is greater than {b}");
            else if (a == b)
                Console.WriteLine($"{a} is equal to {b}");
            else
                Console.WriteLine($"{a} is less than {b}");

        }

        public void Switch()
        {
            Console.WriteLine("Enter 1 for apple: ");
            Console.WriteLine("Enter 2 for orange: ");
            Console.WriteLine("Enter 3 for mango: ");
            Console.WriteLine("Enter 4 for guava: ");
            Console.WriteLine("Enter 5 for pineapple: ");
            Console.WriteLine("Enter 6 for grapes: ");
            Console.WriteLine("Enter 7 for strawberry: ");
            Console.WriteLine("Enter 8 for lemon: ");
            Console.WriteLine("Enter 9 for banana: ");

            var a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("You selected apple.");
                    break;
                case 2:
                    Console.WriteLine("You selected orange.");
                    break;
                case 3:
                    Console.WriteLine("You selected mango.");
                    break;
                case 4:
                    Console.WriteLine("You selected guava.");
                    break;
                case 5:
                    Console.WriteLine("You selected pineapple.");
                    break;
                case 6:
                    Console.WriteLine("You selected grapes.");
                    break;
                case 7:
                    Console.WriteLine("You selected strawberry.");
                    break;
                case 8:
                    Console.WriteLine("You selected lemon.");
                    break;
                case 9:
                    Console.WriteLine("You selected banana.");
                    break;
                default:
                    Console.WriteLine("You entered invalid number.");
                    break;
            }
        }

        public void WhileLoop()
        {
            Console.WriteLine("Enter a number for loop: ");

            var num = Convert.ToInt32(Console.ReadLine());

            while (num < 10)
            {
                Console.WriteLine(num);
                num++;
            }
        }

        public void DoWhileLoop()
        {
            string password = "dorjee";
            var input = "";

            do
            {
                Console.WriteLine("Enter the password: ");
                input = Console.ReadLine();
            } while (password != input);

            //goto Apple;
            //Banana: Console.WriteLine("How are you?");
            //Apple: Console.WriteLine($"Welcome {password}");
            //goto Banana;
        }

        public void ForLoop()
        {
            string[] fruits = { "apple", "banana", "orange" };

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }

        public void ForEachLoop()
        {
            string[] fruits = { "apple", "banana", "orange" };

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}

