using System;

namespace ExamTime
{
    class ExamTime
    {
        static void Main(string[] args)
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMinuts = int.Parse(Console.ReadLine());
            int arrivalHours = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int totalTimeExam = examHours * 60 + examMinuts;
            int totalArrivalTime = arrivalHours * 60 + arrivalMinutes;

            string time = "";
            int hours = 0;
            int minutes = 0;
            int total = 0;

            if (totalTimeExam < totalArrivalTime)
            {
                total = totalArrivalTime - totalTimeExam;
                time = "Late";
            }
            else if (totalTimeExam == totalArrivalTime)
            {
                total = totalTimeExam;
                time = "On time";
            }
            else if (totalTimeExam >= totalArrivalTime)
            {
                total = totalTimeExam - totalArrivalTime;
                time = "Early";
            }


            switch (time)
            {
                case "Early":
                    hours = total / 60;
                    minutes = total % 60;

                    if (totalTimeExam <= totalArrivalTime + 30)
                    {
                        Console.WriteLine($"On time {minutes} minutes before the start");
                    }
                    else if (total < 60)
                    {
                        Console.WriteLine($"Early {minutes} minutes before the start");
                    }
                    else if (total >= 60)
                    {
                        if (minutes < 10)
                        {
                            Console.WriteLine($"Early {hours}:0{minutes} hours before the start");

                        }
                        else
                        Console.WriteLine($"Early {hours}:{minutes} hours before the start");
                    }
                    break;

                case "On time":
                    Console.WriteLine("On time");
                    break;

                case "Late":
                    hours = total / 60;
                    minutes = total % 60;
                    if (total < 60)
                    {
                        Console.WriteLine($"Late {minutes} minutes after the start");
                    }
                    else if (total >= 60 && minutes < 10)
                    {
                        Console.WriteLine($"Late {hours}: 0{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"Late {hours}:{minutes} hours after the start");
                    }
                    break;
            }

            
        }
    }
}
