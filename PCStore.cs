using System;

namespace PCStore
{
    class PCStore
    {
        static void Main(string[] args)
        {
            double priceProcesor = double.Parse(Console.ReadLine());
            double priceVideoCard = double.Parse(Console.ReadLine());
            double priceRAM = double.Parse(Console.ReadLine());
            int numberRam = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            priceProcesor = priceProcesor * 1.57;
            priceProcesor = priceProcesor - (priceProcesor * discount);
            priceVideoCard = priceVideoCard * 1.57;
            priceVideoCard = priceVideoCard - (priceVideoCard * discount);
            priceRAM = priceRAM * 1.57 * numberRam;

            double total = priceProcesor + priceVideoCard + priceRAM;

            Console.WriteLine($"Money needed - {total:f2} leva.");
        }
    }
}
