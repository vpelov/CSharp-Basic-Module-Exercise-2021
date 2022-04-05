using System;

namespace CatsWalk
{
    class CatsWalk
    {
        static void Main(string[] args)
        {
            int minutesWalk = int.Parse(Console.ReadLine());
            int numbersWalk = int.Parse(Console.ReadLine());
            int catCalories = int.Parse(Console.ReadLine());

            double total = (minutesWalk * 5) * numbersWalk;

            if (total >= catCalories / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {total}.");
            }
            else
            Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {total}.");
        }
    }
}
