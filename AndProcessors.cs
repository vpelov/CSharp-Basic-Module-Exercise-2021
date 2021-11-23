using System;

namespace AndProcessors
{
    class AndProcessors
    {
        static void Main(string[] args)
        {
            int numberProcessors = int.Parse(Console.ReadLine());
            int numberEmployееs = int.Parse(Console.ReadLine());
            int numberWorkDay = int.Parse(Console.ReadLine());

            double timeWork = (numberWorkDay * 8 * numberEmployееs);
            double allProducedProcessors = Math.Floor(timeWork / 3);
            double priceAllProcessors = allProducedProcessors * 110.10;

            if (numberProcessors <= allProducedProcessors)
            {
                Console.WriteLine($"Profit: -> {(allProducedProcessors - numberProcessors) * 110.10:f2} BGN");
            }
            else
                Console.WriteLine($"Losses: -> {(numberProcessors - allProducedProcessors) * 110.10:f2} BGN");
        }
    }
}
