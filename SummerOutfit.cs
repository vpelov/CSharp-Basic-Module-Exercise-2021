using System;

namespace SummerOutfit
{
    class SummerOutfit
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine().ToLower();

            string shoes = " ";
            string outfit = " ";

            switch (dayTime)
            {
                case "morning":
                    if (degree >= 10 && degree <= 18)
                    {
                        shoes = "Sneakers";
                        outfit = "Sweatshirt";
                    }
                    else if (degree > 18 && degree <= 24)
                    {
                        shoes = "Moccasins";
                        outfit = "Shirt";
                    }
                    else if (degree >= 25)
                    {
                        shoes = "Sandals";
                        outfit = "T-Shirt";
                    }
                    break;
                case "afternoon":
                    if (degree >= 10 && degree <= 18)
                    {
                        shoes = "Moccasins";
                        outfit = "Shirt";
                    }
                    else if (degree > 18 && degree <= 24)
                    {
                        shoes = "Sandals";
                        outfit = "T-Shirt";
                    }
                    else if (degree >= 25)
                    {
                        shoes = "Barefoot";
                        outfit = "Swim Suit";
                    }
                    break;
                case "evening":
                    if (degree >= 10 && degree <= 18)
                    {
                        shoes = "Moccasins";
                        outfit = "Shirt";
                    }
                    else if (degree > 18 && degree <= 24)
                    {
                        shoes = "Moccasins";
                        outfit = "Shirt";
                    }
                    else if (degree >= 25)
                    {
                        shoes = "Moccasins";
                        outfit = "Shirt";
                    }
                    break;
            }

            Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");

        }
    }
}
