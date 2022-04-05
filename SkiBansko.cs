using System;

namespace SkiBansko
{
    class SkiBansko
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine().ToLower();
            string grade = Console.ReadLine().ToLower();

            double priceRoomForOnePerson = 18;
            double priceApartment = 25;
            double pricePresidentApartment = 35;

            double price = 0;
            double totalPrice = 0;

            switch (roomType)
            {
                case "room for one person":
                    price = priceRoomForOnePerson * (day - 1);
                    break;

                case "apartment":
                    if (day < 10)
                    {
                        price = priceApartment * (day - 1) * 0.7;
                    }
                    else if (day >= 10 && day <=15)
                    {
                        price = priceApartment * (day - 1) * 0.65;
                    }
                    else if (day > 15)
                    {
                        price = priceApartment * (day - 1) * 0.5;
                    }
                    break;
                case "president apartment":
                    if (day < 10)
                    {
                        price = pricePresidentApartment * (day - 1) * 0.9;
                    }
                    else if (day >= 10 && day <= 15)
                    {
                        price = pricePresidentApartment * (day - 1) * 0.85;
                    }
                    else if (day > 15)
                    {
                        price = pricePresidentApartment * (day - 1) * 0.8;
                    }
                    break;
            }

            if (grade == "positive")
            {
                totalPrice = price * 1.25;
            }
            else if (grade == "negative")
            {
                totalPrice = price * 0.9;
            }

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
