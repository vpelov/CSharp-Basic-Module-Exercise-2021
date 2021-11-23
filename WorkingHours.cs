using System;

namespace WorkingHours
{
    class WorkingHours
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            string day = Console.ReadLine().ToLower();

            if (hours >= 10 && hours <= 18)
            {
                switch (day)
                {
                    case "monday":
                    case "tuesday":
                    case "wednesday":
                    case "thursday":
                    case "friday":
                    case "saturday":
                        Console.WriteLine("open");
                        break;
                    case "sunday":
                        Console.WriteLine("closed");
                        break;
                }
            }
            else
            {
                Console.WriteLine("closed");
            }


        }
    }
}
