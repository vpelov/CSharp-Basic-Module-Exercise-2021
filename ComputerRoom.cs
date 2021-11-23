using System;

namespace ComputerRoom
{
    class ComputerRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int allHoursUses = int.Parse(Console.ReadLine());
            int numberPeople = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            double pricePerHour = 0.0;

            switch (month)
            {
                case "march":
                case "april":
                case "may":
                    if (dayTime == "day")
                    {
                        pricePerHour = 10.50;
                        if (numberPeople >= 4)
                        {
                            pricePerHour *= 0.9;
                        }
                        if (allHoursUses >= 5)
                        {
                            pricePerHour *= 0.5;
                        }
                    }
                    else if (dayTime == "night")
                    {
                        pricePerHour = 8.40;
                        if(numberPeople >= 4)
                        {
                            pricePerHour *= 0.9;
                        }
                        if (allHoursUses >= 5)
                        {
                            pricePerHour *= 0.5;
                        }
                    }
                    break;
                case "june":
                case "july":
                case "august":
                    if (dayTime == "day")
                    {
                        pricePerHour = 12.60;
                        if (numberPeople >= 4)
                        {
                            pricePerHour *= 0.9;
                        }
                        if (allHoursUses >= 5)
                        {
                            pricePerHour *= 0.5;
                        }
                    }
                    else if (dayTime == "night")
                    {
                        pricePerHour = 10.20;
                        if (numberPeople >= 4)
                        {
                            pricePerHour *= 0.9;
                        }
                        if (allHoursUses >= 5)
                        {
                            pricePerHour *= 0.5;
                        }

                    }
                        break;
            }

            Console.WriteLine($"Price per person for one hour: {pricePerHour:f2}");
            Console.WriteLine($"Total cost of the visit: {numberPeople * pricePerHour * allHoursUses:f2}");




        }
    }
}
