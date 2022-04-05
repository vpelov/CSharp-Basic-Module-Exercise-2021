using System;

namespace Aquarium
{
    class Aqurium
    {
        static void Main(string[] args)
        {
            double Lenght = double.Parse(Console.ReadLine());
            double Widht = double.Parse(Console.ReadLine());
            double Hight = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double TotalVolume = (Lenght * Widht * Hight) / 1000;
            double Sand = (percentage / 100) * TotalVolume;
            double NewVolume = TotalVolume - Sand;
            Console.WriteLine(NewVolume);
        }
    }
}
