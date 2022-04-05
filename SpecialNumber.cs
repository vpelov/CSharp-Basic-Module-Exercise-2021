using System;

namespace SpecialNumber
{
    class SpecialNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i < 9999; i++)
            {
                int a = i % 10;
                if (a != 0 && n % a == 0)
                {
                    int b = (i / 10) % 10;
                    if (b != 0 && n % b == 0)
                    {
                        int c = (i / 100) % 10;
                        if (c != 0 && n % c == 0)
                        {
                            int d = (i / 1000) % 10;
                            if (d != 0 && n % d == 0)
                            {
                                Console.Write($"{i} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
