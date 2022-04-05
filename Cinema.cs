using System;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string cinemaType = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double total = 0;

            if (cinemaType == "premiere")
            {
                total = rows * columns * 12;
                Console.WriteLine("{0:f2} leva", total);
            }
            else if (cinemaType == "normal")
            {
                total = rows * columns * 7.50;
                Console.WriteLine("{0:f2} leva", total);
            }
            else if (cinemaType == "discount")
            {
                total = rows * columns * 5;
                Console.WriteLine("{0:f2} leva", total);
            }

        }
    }
}
