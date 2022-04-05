using System;

namespace MountainRun
{
    class MountainRun
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double SecondsForMeters = double.Parse(Console.ReadLine());

            double slows = (Math.Floor(distance / 50) * 30);

            double totalTime = (distance * SecondsForMeters) + slows;

            if (totalTime < record)
            {
                Console.WriteLine($" Yes! The new record is {totalTime:f2} seconds.");
            }
            else
                Console.WriteLine($"No! He was {Math.Abs(record - totalTime):f2} seconds slower.");


        }
    }
}
