using System;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i < 9999; i++)
            {
                if (i / 1000 % 10 == 0 || i / 100 % 10 == 0 || i / 10 % 10 == 0 || i % 10 == 0)
                {
                    continue;
                }
                else if (n % (i % 10) == 0 && n % ((i / 10) % 10) == 0 && n % ((i / 100) % 10) == 0 && n % ((i / 1000) % 10) == 0)
                {
                    Console.Write($"{i} ");
                }
            }

        }
    }
}
