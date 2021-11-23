using System;

namespace Equipment
{
    class Equipment
    {
        static void Main(string[] args)
        {
            double Tax = double.Parse(Console.ReadLine());

            double Sneakers = Tax * 0.6;
            double Clothes = Sneakers * 0.8;
            double Ball = Clothes * 0.25;
            double Accessories = Ball * 0.2;
            
            double Costs = Tax + Sneakers + Clothes + Ball + Accessories;
            Console.WriteLine(Costs);
        }
    }
}
