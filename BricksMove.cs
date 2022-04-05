using System;

namespace BricksMove
{
    class BricksMove
    {
        static void Main(string[] args)
        {
            int bricks = int.Parse(Console.ReadLine());
            int worker = int.Parse(Console.ReadLine());
            int numBricksByMove = int.Parse(Console.ReadLine());

            if (bricks % (worker * numBricksByMove) == 0)
            {
                int course = bricks / (worker * numBricksByMove);
                Console.WriteLine(course);
            }
            else
            {
                int course = bricks / (worker * numBricksByMove);
                Console.WriteLine(course + 1);               
            }



        }
    }
}
