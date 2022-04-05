using System;

namespace SumThreeDigits
{
    class SumThreeDigits
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b == c)
            {
                if (a < b)
                {
                    Console.WriteLine("{0} + {1} = {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{1} + {0} = {2}", a, b, c);
                }
            }
            else if (a + c == b)
            {
                if (a < c)
                {
                    Console.WriteLine("{0} + {2} = {1}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{2} + {0} = {1}", a, b, c);
                }
            }
            else if (c + b == a)
            {
                if (c < b)
                {
                    Console.WriteLine("{2} + {1} = {0}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{1} + {2} = {0}", a, b, c);
                }
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
