using System;

namespace ExcursionCalculator
{
    class ExcursionCalculator
    {
        static void Main(string[] args)
        {

            int numberPeople = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double total = 0.0;

            switch (season)
            {
                case "spring":
                    if (numberPeople <= 5)
                    {
                        total = numberPeople * 50;
                    }
                    else
                        total = numberPeople * 48;
                    break;
                case "summer":
                    if (numberPeople <= 5)
                    {
                        total = numberPeople * 48.50;
                    }
                    else
                        total = numberPeople * 45;
                    break;
                case "autumn":
                    if (numberPeople <= 5)
                    {
                        total = numberPeople * 60;
                    }
                    else
                        total = numberPeople * 49.5;
                    break;
                case "winter":
                    if (numberPeople <= 5)
                    {
                        total = numberPeople * 86;
                    }
                    else
                        total = numberPeople * 85;
                    break;
            }

            if (season == "summer")
            {
                Console.WriteLine($"{total * 0.85:f2} leva.");
            }
            else if (season == "winter")
            {
                Console.WriteLine($"{total * 1.08:f2} leva.");
            }
            else
                Console.WriteLine($"{total:f2} leva.");



        }
    }
}
