using System;

namespace Point_i_rectangle
{
    class PointRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert point 1 x = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert point 1 y = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert point 2 x = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert point 2 y = ");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert point x = ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert point y = ");
            int y = int.Parse(Console.ReadLine());

            if (x1 >= x2 || y1 >= y2)
            {
                Console.WriteLine("ERROR");
            }
            else if (x > x1 && x < x2 && y <y2 && y > y1)
            {
                Console.WriteLine("Point x,y is inside");
            }
            else if (x == x1 && y > y1 && y < y2 || x == x2 && y < y2 && y > y1 || y == y2 && x > x1 && x < x2 || y == y1 && x > x1 && x < x2)
            {
                Console.WriteLine("Point x,y is border");
            }
            else
            {
                Console.WriteLine("Point x,y is outside");
            }

        }
    }
}
