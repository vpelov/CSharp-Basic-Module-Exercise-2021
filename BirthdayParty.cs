using System;

namespace BirthdayParty
{
    class BirthdayParty
    {
        static void Main(string[] args)
        {
            double rentHall = double.Parse(Console.ReadLine());

            double cake = rentHall * 0.2;
            double drinks = cake * 0.55;
            double clown = rentHall / 3;

            double totalPrice = rentHall + (cake) + (drinks) + (clown);

            Console.WriteLine(totalPrice);
        }
    }
}
