using System;

namespace RowsAndDigits
{
    class AreaTriangle
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            int a = x2 - x3;
            int ha = y1 - y2;

            double area = (double)(a * ha) / 2;

            Console.WriteLine(Math.Abs(area));

        }
    }
}
