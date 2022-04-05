using System;

namespace NewHouse
{
    class NewHouse
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());

            double roses = 5.00;
            double dahlias = 3.80;
            double tulips = 2.80;
            double narcissus = 3.00;
            double gladiolus = 2.50;

            double total = 0;

            switch (flowers)
            {
                case "Roses":               //"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
                    if (numFlowers > 80)
                    {
                        total = 0.9 * roses * numFlowers;
                    }
                    else
                        total = roses * numFlowers;
                    break;
                case "Dahlias":
                    if (numFlowers > 90)
                    {
                        total = 0.85 * dahlias * numFlowers;
                    }
                    else
                        total = dahlias * numFlowers;
                    break;
                case "Tulips":
                    if (numFlowers > 80)
                    {
                        total = 0.85 * tulips * numFlowers;
                    }
                    else
                        total = tulips * numFlowers;
                    break;
                case "Narcissus":
                    if (numFlowers < 120)
                    {
                        total = 1.15 * narcissus * numFlowers;
                    }
                    else
                        total = narcissus * numFlowers;
                    break;
                case "Gladiolus":
                    if (numFlowers < 80)
                    {
                        total = 1.20 * gladiolus * numFlowers;
                    }
                    else
                        total = gladiolus * numFlowers;
                    break;           
            }

            if (budjet >= total)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flowers} and {budjet - total:f2} leva left.");
            }
            else if (budjet < total)
            {
                Console.WriteLine($"Not enough money, you need {total - budjet:f2} leva more.");
            }
        }
    }
}
