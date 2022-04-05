using System;

namespace Digits
{
    class DigitsGame
    {
        static void Main(string[] args)
        {           

            int x = int.Parse(Console.ReadLine());

            int n = (x / 100) + (x / 10) % 10;
            int m = (x / 100) + (x % 100) % 10;

            int num = x;

            for (int i = 0; i < n; i++)
            {
                for (int p = 0; p < m; p++)
                {

                    if (num % 5 == 0)
                    {
                        num = num - (x / 100);
                        Console.Write($"{num} ");
                    }
                    else if (num % 3 == 0)
                    {
                        num = num - ((x / 10) % 10);
                        Console.Write($"{num} ");
                    }
                    else 
                    {
                        num = num + (x % 10);
                        Console.Write($"{num} ");

                    }

                }


                Console.WriteLine();
            }

        }
    }
}
