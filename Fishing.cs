using System;

namespace Fishing
{
    class Fishing
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            int numFishMan = int.Parse(Console.ReadLine());

            const double boatPriceSpring = 3000;
            const double boatPriceSummer = 4200;
            const double boatPriceAutumn = 4200;
            const double boatPriceWinter = 2600;

            double total = 0.0;

            switch (season)
            {
                case "spring":
                    if (numFishMan <= 6)
                    {
                        total = boatPriceSpring * 0.9;
                    }
                    else if (numFishMan > 6 && numFishMan <= 11)
                    {
                        total = boatPriceSpring * 0.85;
                    }
                    else if (numFishMan >= 12)
                    {
                        total = boatPriceSpring * 0.75;
                    }
                    break;
                case "summer":
                    if (numFishMan <= 6)
                    {
                        total = boatPriceSummer * 0.9;
                    }
                    else if (numFishMan > 6 && numFishMan <= 11)
                    {
                        total = boatPriceSummer * 0.85;
                    }
                    else if (numFishMan >= 12)
                    {
                        total = boatPriceSummer * 0.75;
                    }
                    break;
                case "autumn":
                    if (numFishMan <= 6)
                    {
                        total = boatPriceAutumn * 0.9;
                    }
                    else if (numFishMan > 6 && numFishMan <= 11)
                    {
                        total = boatPriceAutumn * 0.85;
                    }
                    else if (numFishMan >= 12)
                    {
                        total = boatPriceAutumn * 0.75;
                    }
                    break;
                case "winter":
                    if (numFishMan <= 6)
                    {
                        total = boatPriceWinter * 0.9;
                    }
                    else if (numFishMan > 6 && numFishMan <= 11)
                    {
                        total = boatPriceWinter * 0.85;
                    }
                    else if (numFishMan >= 12)
                    {
                        total = boatPriceWinter * 0.75;
                    }
                    break;                
            }

            if (numFishMan % 2 == 0 && season != "autumn")
            {
                total *= 0.95;
            }

            if (total <= budjet)
            {
                Console.WriteLine($"Yes! You have {budjet - total:f2} leva left.");
            }
            else if (total > budjet)
            {
                Console.WriteLine($"Not enough money! You need {total - budjet:f2} leva.");
            }
        }
    }
}
