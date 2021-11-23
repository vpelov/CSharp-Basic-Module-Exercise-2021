using System;

namespace Sekonds
{
    class Program
    {
        static void Main(string[] args)
        {

            int first = int.Parse(Console.ReadLine());
            int sekond = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int minutes = (first + sekond + third) / 60;
            int sekonds = (first + sekond + third) % 60;

            if (sekonds < 10)
            {
                Console.WriteLine($"{minutes}:0{sekonds}");            
            }
            else
            {
                Console.WriteLine($"{minutes}:{sekonds}");
            }

        }
    }
}
