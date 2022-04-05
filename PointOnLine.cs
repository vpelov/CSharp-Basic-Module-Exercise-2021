using System;

namespace PointOnLine
{
    class PointOnLine
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second= int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());


            if (first < second)
            {

                if (point >= first && point <= second)
                {
                    Console.WriteLine("in");
                }
                else
                {
                    Console.WriteLine("out");
                }
            }
            else  //second < first
            {
                if (point <= first && point >= second)
                {
                    Console.WriteLine("in");
                }
                else
                {
                    Console.WriteLine("out");
                }
            }

            int a = Math.Abs(point - first);
            int b = Math.Abs(point - second);

            if (a < b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
