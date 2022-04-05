using System;

namespace AddLuggage
{
    class AddLuggage
    {
        static void Main(string[] args)
        {
            double priceLuggage = double.Parse(Console.ReadLine());
            double kilogramsLuggage = double.Parse(Console.ReadLine());
            int dayToTravel = int.Parse(Console.ReadLine());
            int numberLuggage = int.Parse(Console.ReadLine());

            double total = 0.0;

            if (dayToTravel > 30)
            {
                if (kilogramsLuggage < 10)
                {
                    total = priceLuggage * 0.2 * 1.1 * numberLuggage;
                }
                else if (kilogramsLuggage >= 10 && kilogramsLuggage <= 20)
                {
                    total = priceLuggage * 0.5 * 1.1 * numberLuggage;
                }
                else if (kilogramsLuggage > 20)
                {
                    total = priceLuggage * 1.1 * numberLuggage;
                }
            }
            else if (dayToTravel >= 7 && dayToTravel <= 30)
            {
                if (kilogramsLuggage < 10)
                {
                    total = priceLuggage * 0.2 * 1.15 * numberLuggage;
                }
                else if (kilogramsLuggage >= 10 && kilogramsLuggage <= 20)
                {
                    total = priceLuggage * 0.5 * 1.15 * numberLuggage;
                }
                else if (kilogramsLuggage > 20)
                {
                    total = priceLuggage * 1.15 * numberLuggage;
                }
            }
            else if (dayToTravel < 7)
            {
                if (kilogramsLuggage < 10)
                {
                    total = priceLuggage * 0.2 * 1.4 * numberLuggage;
                }
                else if (kilogramsLuggage >= 10 && kilogramsLuggage <= 20)
                {
                    total = priceLuggage * 0.5 * 1.4 * numberLuggage;
                }
                else if (kilogramsLuggage > 20)
                {
                    total = priceLuggage * 1.4 * numberLuggage;
                }
            }

            Console.WriteLine($" The total price of bags is: {total:f2} lv. ");

        }
    }
}
