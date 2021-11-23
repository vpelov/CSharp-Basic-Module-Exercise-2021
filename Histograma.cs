using System;

namespace Histograma
{
    class Histograma
    {
        static void Main(string[] args)
        {
            Console.Write("insert n = ");
            int n = int.Parse(Console.ReadLine());

            int p1 = 0;       // 0-200
            int p2 = 0;       // 200-400
            int p3 = 0;       // 400-600
            int p4 = 0;       // 600-800
            int p5 = 0;       // 800-1000

            for (int i = 0; i < n; i++)
            {
                Console.Write("insert number: ");
                int a = int.Parse(Console.ReadLine());

                if (a > 0 && a < 200)
                {
                    p1++;
                }
                else if (a >= 200 && a < 400)
                {
                    p2++;
                }
                else if (a >= 400 && a < 600)
                {
                    p3++;
                }
                else if (a >= 600 && a < 800)
                {
                    p4++;
                }
                else if (a >= 800)
                {
                    p5++;
                }
            }

           double p1percentage = (double) p1 / n * 100;
           double p2percentage = (double) p2 / n * 100;
           double p3percentage = (double) p3 / n * 100;
           double p4percentage = (double) p4 / n * 100;
           double p5percentage = (double) p5 / n * 100;
           
           Console.WriteLine($"{p1percentage:f2}");
           Console.WriteLine($"{p2percentage:f2}");
           Console.WriteLine($"{p3percentage:f2}");
           Console.WriteLine($"{p4percentage:f2}");
           Console.WriteLine($"{p5percentage:f2}");


            Console.WriteLine("{0:f2}, {1}, {2},", p1, p2, p3); 
            //Console.WriteLine(p2);
            //Console.WriteLine(p3);
            //Console.WriteLine(p4);
            //Console.WriteLine(p5);
            //Console.WriteLine(n);




        }
    }
}
