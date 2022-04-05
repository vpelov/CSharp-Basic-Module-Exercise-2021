using System;

namespace BallsGame
{
    class BallsGame
    {
        static void Main(string[] args)
        {
            int numbersBaals = int.Parse(Console.ReadLine().ToLower());
            string color = Console.ReadLine();

            double totalPoints = 0.0;
            int redCount = 0;
            int orangeCount = 0;
            int yellowCount = 0;
            int whiteCount = 0;
            int otherCount = 0;
            int blackCount = 0;

            for (int i = 0; i < numbersBaals; i++)
            {
                switch (color)
                {
                    case "red":
                        totalPoints += 5;
                        redCount++;
                        break;
                    case "orange":
                        totalPoints += 10;
                        orangeCount++;
                        break;
                    case "yellow":
                        totalPoints += 15;
                        yellowCount++;
                        break;
                    case "white":
                        totalPoints += 20;
                        whiteCount++;
                        break;
                    case "black":
                        totalPoints = Math.Floor(totalPoints / 2);
                        blackCount++;
                        break;
                    default:
                        otherCount++;
                        break;
                }
                color = Console.ReadLine();
            }

            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Red balls: {redCount}");
            Console.WriteLine($"Orange balls: {orangeCount}");
            Console.WriteLine($"Yellow balls: {yellowCount}");
            Console.WriteLine($"White balls: {whiteCount}");
            Console.WriteLine($"Other colors picked: {otherCount}");
            Console.WriteLine($"Divides from black balls: {blackCount}");

        }
    }
}

