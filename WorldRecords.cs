using System;

namespace WorldRecords
{
    class WorldRecords
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());  //Световен рекорд в секунди
            double distance = double.Parse(Console.ReadLine());         //Разстоянието в метри които трябва да преплува
            double timeInSekondsToM = double.Parse(Console.ReadLine()); //1метър за Х секунди на Иван

            double WRinSekonds = recordInSeconds / distance;            //1метър за Х секунди световен рекорд
            double delay = Math.Floor(distance / 15 * 12.5);            // секунди изоставне за Иван

            double WR = 
            double TimeIvan = distance * timeInSekondsToM
            

            Console.WriteLine(delay);

        }
    }
}
