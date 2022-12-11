using System;
namespace ApplicationDev.week_03
{
    public class FindElementInArray
    {
        public static void findElemnt(string a)
        {
            string[] arr = {"dog", "cat", "duck", "cow", "elephant"};

            Boolean found = false;
            string input = a.ToLower();
            for (int i = 0; i < arr.Length; i++)
            {
                if (input.Equals(arr[i]))
                {
                    found = true;
                }
            }

            if (found == true)
            {
                Console.WriteLine($"{a} was found.");
            }
            else
            {
                Console.WriteLine($"{a} was not found.");
            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}

