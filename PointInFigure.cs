using System;

namespace PointInFigure
{
    class PointInFigure
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert h= ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Plese insert x= ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Plese insert y= ");
            int y = int.Parse(Console.ReadLine());


            if (x == 0 && y <= 0 && y <= 3*h || x == 3*h && y <= 0 && y <= h 
                || y == h && x >= 2*h && x <= 3*h || x == 2*h && y >= h && y <= 4*h 
                || y == 4*h && x >= h && x <= 2*h || x == h && y >= h && y <= 4*h 
                || y == h && x >= 0 && x <= h || x == 0 && y >= 0 && y <= h)
            {
                Console.WriteLine("Your points on border!");
            }
            else if (x > 0 && x < 3*h && y > 0 && y < 1 || x > h && x < 2*h && y > 0 && y < 4*h)
            {
                Console.WriteLine("Your point is inside!");
            }
            else
            {
                Console.WriteLine("Your point is outside!");
            }




                        
        }
    }
}
