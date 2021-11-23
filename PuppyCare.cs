using System;

namespace PuppyCare
{
    class PuppyCare
    {
        static void Main(string[] args)
        {
            int Food = int.Parse(Console.ReadLine());
            string eatFood = Console.ReadLine();

            int eatAllFood = 0;

            while (eatFood != "Adopted")
            {
                int eat = int.Parse(eatFood);
                eatAllFood += eat;

                eatFood = Console.ReadLine();
            }

            if (Food * 1000 >= eatAllFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {(Food * 1000) - eatAllFood} grams.");
            }
            else
                Console.WriteLine($"Food is not enough. You need {eatAllFood - (Food * 1000)} grams more.");            
            
        }
    }
}
