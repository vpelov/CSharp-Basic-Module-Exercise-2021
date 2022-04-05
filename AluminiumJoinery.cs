using System;

namespace AluminiumJoinery
{
    class AluminiumJoinery
    {
        static void Main(string[] args)
        {
            int numberjoinery = int.Parse(Console.ReadLine());
            string typeJoinery = Console.ReadLine();
            string delivery = Console.ReadLine();

            double total = 0.0;
            bool go = true;

            if (numberjoinery < 10)
            {
                Console.WriteLine("Invalid order");
                go = false;
            }
            else
            {
                switch (typeJoinery)
                {
                    case "90X130":
                        if (numberjoinery >= 30 && numberjoinery <= 60)
                        {
                            total = numberjoinery * 110 * 0.95;
                        }
                        else if (numberjoinery > 60)
                        {
                            total = numberjoinery * 110 * 0.92;
                        }
                        break;
                    case "100X150":
                        if (numberjoinery >= 40 && numberjoinery <= 80)
                        {
                            total = numberjoinery * 140 * 0.94;
                        }
                        else if (numberjoinery > 80)
                        {
                            total = numberjoinery * 140 * 0.90;
                        }
                        break;
                    case "130X180":
                        if (numberjoinery >= 20 && numberjoinery <= 50)
                        {
                            total = numberjoinery * 190 * 0.93;
                        }
                        else if (numberjoinery > 50)
                        {
                            total = numberjoinery * 190 * 0.88;
                        }
                        break;
                    case "200X300":
                        if (numberjoinery >= 25 && numberjoinery <= 50)
                        {
                            total = numberjoinery * 250 * 0.91;
                        }
                        else if (numberjoinery > 50)
                        {
                            total = numberjoinery * 250 * 0.86;
                        }
                        break;
                }

            }
            if (go)
            {


                if (delivery == "With delivery")
                {
                    if (numberjoinery > 99)
                    {
                        Console.WriteLine($"{(total + 60) * 0.96:f2} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"{total + 60:f2} BGN");
                    }
                }
                else if (delivery == "Without delivery")
                {
                    if (numberjoinery > 99)
                    {
                        Console.WriteLine($"{total * 0.96:f2} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"{total:f2} BGN");
                    }
                }
            }
        }
    }
}
