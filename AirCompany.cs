using System;

namespace AirCompany
{
    class AirCompany
    {
        static void Main(string[] args)
        {
            string nameCompany = Console.ReadLine();
            int numberTikets = int.Parse(Console.ReadLine());
            int numberChildTikets = int.Parse(Console.ReadLine());
            double priceAdultTikets = double.Parse(Console.ReadLine());
            double priceServiceTax = double.Parse(Console.ReadLine());

            double total = (numberTikets * priceAdultTikets) + (numberTikets * priceServiceTax) + (numberChildTikets * priceAdultTikets * 0.3) + (numberChildTikets * priceServiceTax);

            double profit = total * 0.2;
            Console.WriteLine($"The profit of your agency from {nameCompany} tickets is {profit:f2} lv.");




        }
    }
}
