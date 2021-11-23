using System;

namespace ExcursionSale
{
    class ExcursionSale
    {
        static void Main(string[] args)
        {
            int numberSea = int.Parse(Console.ReadLine());
            int numberMountain = int.Parse(Console.ReadLine());

            double profit = 0.0;
            bool noNumber = false;

            string typeExcursion = Console.ReadLine();

            while (typeExcursion != "Stop")
            {
                if (typeExcursion == "sea")
                {
                    if (numberSea > 0)
                    {
                        profit += 680;
                        numberSea--;
                    }
                }
                else if (typeExcursion == "mountain")
                {
                    if (numberMountain > 0)
                    {
                        profit += 499;
                        numberMountain--;
                    }
                }

                if (numberSea == 0 && numberMountain == 0)
                {
                    noNumber = true;
                    break;
                }

                typeExcursion = Console.ReadLine();
            }

            if (noNumber)
            {
                Console.WriteLine(" Good job! Everything is sold.");
            }

            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
