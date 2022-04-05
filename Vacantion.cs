using System;

namespace Vacantion
{
    class Vacantion
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string region = "";
            string typeBase = "";
            double discount = 0;

            switch (season)
            {
                case "summer":
                    if (budjet <= 100)
                    {
                        region = "Bulgaria";
                        typeBase = "Camp";
                        discount = 30 / 100.0;
                    }
                    else if (budjet <= 1000)
                    {
                        region = "Balkans";
                        typeBase = "Camp";
                        discount = 40 / 100.0;
                    }
                    else if (budjet > 1000)
                    {
                        region = "Europe";
                        typeBase = "Hotel";
                        discount = 90 / 100.0;
                    }
                    break;
                case "winter":
                    if (budjet <= 100)
                    {
                        region = "Bulgaria";
                        typeBase = "Hotel";
                        discount = 70 / 100.0;
                    }
                    else if (budjet <= 1000)
                    {
                        region = "Balkans";
                        typeBase = "Hotel";
                        discount = 80 / 100.0;
                    }
                    else if (budjet > 1000)
                    {
                        region = "Europe";
                        typeBase = "Hotel";
                        discount = 90 / 100.0;
                    }
                    break;
            }

            double prices = budjet * discount;
            Console.WriteLine($"Somewhere in {region}");
            Console.WriteLine($"{typeBase} - {prices:f2}");




        }
    }
}
