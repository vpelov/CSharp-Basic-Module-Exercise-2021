using System;

namespace Exam
{
    class Exam
    {
        static void Main(string[] args)
        {
            int numberStudent = int.Parse(Console.ReadLine());

            double totalStudent = 0.0;
            double totalGrade = 0.0;

            double fiveAndMore = 0.0;
            double fourAndMore = 0.0;
            double threeAndMore = 0.0;
            double threeAndLess = 0.0;

            for (int i = 0; i < numberStudent; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 3)
                {
                    threeAndLess++;
                }
                else if (grade >= 3 && grade < 4)
                {
                    threeAndMore++;
                }
                else if (grade >= 4 && grade < 5)
                {
                    fourAndMore++;
                }
                else if (grade >= 5)
                {
                    fiveAndMore++;
                }

                totalGrade += grade;
                totalStudent++;
            }

            Console.WriteLine($"Top students: {fiveAndMore / totalStudent * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {fourAndMore / totalStudent * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {threeAndMore / totalStudent * 100:f2}%");
            Console.WriteLine($"Fail: {threeAndLess / totalStudent * 100:f2}%");
            Console.WriteLine($"Average: {totalGrade / totalStudent:f2}");



        }
    }
}
