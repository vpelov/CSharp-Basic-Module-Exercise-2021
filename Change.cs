using System;

namespace Change
{
    class Change
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double uans = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double bitcoinToEuro = (double)bitcoins * 1168 / 1.95;
            double uanToEuro = uans * 0.15 * 1.76 / 1.95;
            double total = (bitcoinToEuro + uanToEuro) - ((bitcoinToEuro + uanToEuro) * tax / 100);
            Console.WriteLine($"{total:f2}");
        }
    }
}
