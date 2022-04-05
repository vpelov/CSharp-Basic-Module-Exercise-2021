using System;

namespace Bracelet
{
    class Bracelet
    {
        static void Main(string[] args)
        {
            double moneyTeresa = double.Parse(Console.ReadLine());
            double dayMoneyWinTeresa = double.Parse(Console.ReadLine());
            double costsTeresa = double.Parse(Console.ReadLine());
            double gift = double.Parse(Console.ReadLine());

            double total = (moneyTeresa * 5 + dayMoneyWinTeresa * 5) - costsTeresa;

            if (total >= gift)
            {
                Console.WriteLine($"Profit: {total:f2} BGN, the gift has been purchased.");
            }
            else
                Console.WriteLine($"Insufficient money: {gift - total:f2} BGN.");
        }
    }
}
