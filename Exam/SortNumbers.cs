using System;

namespace SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                int n = int.MinValue;
                if (n < num1)
                {
                    n = num1;
                }
                if (n < num2)
                {
                    n = num2;
                }
                if (n < num3)
                {
                    n = num3;
                }

                Console.WriteLine(n);

                if (n == num1)                              
                {
                    num1 = int.MinValue;
                    continue;
                    
                }
                if (n == num2)
                {
                    num2 = int.MinValue;
                    continue;
                }
                if (n == num3)
                {
                    num3 = int.MinValue;
                    continue;
                }
            }

        }
    }
}
