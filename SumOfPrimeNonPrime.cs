using System;

namespace SumOfPrimeNonPrime
{
    class SumOfPrimeNonPrime
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int prime = 0;
            int nonPrime = 0;

            bool right = true;

            while (num != "stop")
            {

                int number = int.Parse(num);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    num = Console.ReadLine();
                    continue;
                }

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        right = false;
                        break;
                    }
                }
                if (right)
                {
                    prime += number;
                }
                else
                {
                    nonPrime += number;
                }

                num = Console.ReadLine();
                right = true;
            }

            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrime}");

        }
    }
}
