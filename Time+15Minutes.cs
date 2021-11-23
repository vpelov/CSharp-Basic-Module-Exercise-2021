using System;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int inHours = int.Parse(Console.ReadLine());
            int inMinutes = int.Parse(Console.ReadLine());
            int total = (inHours *60) + inMinutes + 15;

            if (total >= 1440)
            {
                total -= 1440;
            }

            int outHours = total / 60;
            int outMinutes = total % 60;

            if (outMinutes < 10)
            {
                Console.WriteLine($"{outHours}:0{outMinutes}");
            }
            else
            {
                Console.WriteLine($"{outHours}:{outMinutes}");
            }

        }
    }
}
