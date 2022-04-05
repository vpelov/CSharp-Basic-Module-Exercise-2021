using System;

namespace SuitcasesLoading
{
    class SuitcasesLoading
    {
        static void Main(string[] args)
        {
            double maxLoading = double.Parse(Console.ReadLine());
            string volumeSuitcase = Console.ReadLine();
            double totalVolume = 0.0;
            int countBag = 0;

            bool go = true;

            while (volumeSuitcase != "End")
            {
                double curentVolume = double.Parse(volumeSuitcase);
                countBag++;
                if (countBag % 3 == 0)
                {
                    curentVolume = curentVolume * 1.1;
                }
                if (curentVolume > maxLoading - totalVolume)
                {
                    Console.WriteLine("No more space!");
                    countBag--;
                    go = false;
                    break;
                }
                totalVolume += curentVolume;

                volumeSuitcase = Console.ReadLine();
            }

            if (go)
            {
            Console.WriteLine("Congratulations! All suitcases are loaded!");
            }

            Console.WriteLine($"Statistic: {countBag} suitcases loaded.");

        }
    }
}
