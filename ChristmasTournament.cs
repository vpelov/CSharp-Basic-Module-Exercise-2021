using System;

namespace ChristmasTournament
{
    class ChristmasTournament
    {
        static void Main(string[] args)
        {
            int dayTournament = int.Parse(Console.ReadLine());

            double totalMoney = 0.0;
            int winCountDay = 0;
            int loseCountDay = 0;

            for (int i = 0; i < dayTournament; i++)
            {
                double money = 0.0;
                int winCount = 0;
                int loseCount = 0;

                string gameName = Console.ReadLine();

                while (gameName != "Finish")
                {
                    string gameResult = Console.ReadLine();
                    if (gameResult == "win")
                    {
                        money += 20;
                        winCount++;
                    }
                    else if (gameResult == "lose")
                    {
                        loseCount++;
                    }
                    gameName = Console.ReadLine();
                }
                if (winCount > loseCount)
                {
                    winCountDay++;
                    totalMoney += money * 1.1;
                }
                else
                {
                    loseCountDay++;
                    totalMoney += money;
                }
            }

            if (winCountDay > loseCountDay)
            {
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney * 1.2:f2}");
            }
            else
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");

        }
    }
}
