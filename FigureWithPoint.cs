using System;

namespace FigureWithPoint
{
    class FigureWithPoint
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool fig1 = x >= 4 && x <= 10 && y <= 3 && y >= -5;
            bool fig2 = x >= 2 && x <= 12 && y <= 1 && y >= -3;

            if (fig1 || fig2)
            {
                Console.WriteLine("in");
            }
            else
                Console.WriteLine("out");






            //if (x >= 4 && x <= 10 && y <= 3 && y >= -5 || x >= 2 && x <= 12 && y <= 1 && y >= -3)
            //{
            //    Console.WriteLine("in");
            //}
            //else
            //    Console.WriteLine("out");

        }
    }
}
