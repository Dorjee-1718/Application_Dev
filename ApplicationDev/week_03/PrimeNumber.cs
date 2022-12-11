using System;
namespace ApplicationDev.week_03
{
    public class PrimeNumber
    {
        public static void checkPrime(int a)
        {
            /*Boolean prime = true;
            int count = 0;
            for( int i = 1; i < a; i++)
            {
                if(a % i == 0)
                {
                    count++;
                    if (count > 0 && i < a)
                    {
                        prime = false;
                        Console.WriteLine($"{a} prime : {prime}");
                    }
                }
            }
            */

            Boolean prime = false;
            for (int i = 2; i < a; i++)
            {
                if (i == a && a % i == 0)
                {
                    prime = true;
                  
                }
                
            }

            Console.WriteLine($"{a} prime : {prime}");


            //Console.Write("Press any key to close the Calculator console app...");
            //Console.ReadKey();
        }
    }
}

