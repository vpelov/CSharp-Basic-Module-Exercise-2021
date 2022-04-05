using System;

namespace BestPlayer
{
    class BestPlayer
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int numberGoals = 0;

            string nameWinner = "";
            int goalsWinner = 0;
            bool fin = true;


            while (playerName != "END")
            {
                numberGoals = int.Parse(Console.ReadLine());
                if (numberGoals > goalsWinner)
                {
                    goalsWinner = numberGoals;
                    nameWinner = playerName;
                }
                if (numberGoals >= 10)
                {
                    Console.WriteLine($"{nameWinner} is the best player!");
                    Console.WriteLine($"He has scored {numberGoals} goals and made a hat-trick !!!");
                    fin = false;
                    break;
                }
                playerName = Console.ReadLine();
            }
            if (fin)
            {
                if (goalsWinner >= 3)
                {
                Console.WriteLine($"{nameWinner} is the best player!");
                Console.WriteLine($"He has scored {goalsWinner} goals and made a hat-trick !!!");
                }
                else
                {
                    Console.WriteLine($"{nameWinner} is the best player!");
                    Console.WriteLine($"He has scored {goalsWinner} goals.");
                }
            }




        }
    }
}
