using System;

namespace RoomPainting
{
    class RoomPainping
    {
        static void Main(string[] args)
        {
            int numberPaintBox = int.Parse(Console.ReadLine());
            int wallpaperRols = int.Parse(Console.ReadLine());
            double priceGloves = double.Parse(Console.ReadLine());
            double priceBrush = double.Parse(Console.ReadLine());

            double allPricePaintBox = numberPaintBox * 21.50;
            double allPriceWallpaperRols = wallpaperRols * 5.20;
            double allPriceGloves = Math.Ceiling(wallpaperRols * 0.35) * priceGloves;
            double allPriceBrush = Math.Floor(numberPaintBox * 0.48) * priceBrush;

            double delivery = (allPricePaintBox + allPriceWallpaperRols + allPriceGloves + allPriceBrush) / 15;

            Console.WriteLine($"This delivery will cost { delivery:f2} lv.");

        }
    }
}
