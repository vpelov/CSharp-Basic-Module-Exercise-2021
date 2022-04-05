using System;

namespace GoldMine
{
    class GoldMine
    {
        static void Main(string[] args)
        {
            int location = int.Parse(Console.ReadLine());

            for (int i = 0; i < location; i++)
            {
                double allExtraction = 0.0;

                double averageExtraction = double.Parse(Console.ReadLine());
                int dayNumber = int.Parse(Console.ReadLine());
                int x = dayNumber;

                while (x != 0)
                {
                    double extraction = double.Parse(Console.ReadLine());
                    allExtraction += extraction;
                    x--;
                }

                if ((allExtraction / dayNumber) >= averageExtraction)
                {
                    Console.WriteLine($"Good job! Average gold per day: {allExtraction / dayNumber:f2}.");
                }
                else
                    Console.WriteLine($"You need {averageExtraction - (allExtraction / dayNumber):f2} gold.");
            }




        }
    }
}
