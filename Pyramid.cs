using System;

namespace Pyramid
{
    class Pyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            bool right = false; 

            for (int i = 1; i <= n; i++)
            {
               
                for (int j = 1; j <= i; j++)
                {
                    if (number > n)
                    {
                        right = true;
                        break;
                    }
                    Console.Write(number + " ");
                    number++;
                }
                if (right)
                {
                    break;
                }
                Console.WriteLine();
            }
            

        }
    }
}
