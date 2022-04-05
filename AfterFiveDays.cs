using System;

namespace AfterFiveDays
{
    class AfterFiveDays
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            int newDays = days + 5;
            

            switch (month)
            {
                case 1:                                //31days
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (newDays > 31)
                    {
                        newDays -= 31;
                        if (month < 9)
                        {
                            Console.WriteLine($"{newDays}.0{month + 1}");
                        }
                        else if (month == 10)
                        {
                            Console.WriteLine($"{newDays}.{month + 1}");
                        }
                        else if (month == 12)
                        {
                            Console.WriteLine($"{newDays}.0{month - 11}");
                        }

                    }
                    else
                    {
                        if (month < 9)
                        {
                        Console.WriteLine($"{newDays}.0{month}");
                        }
                        else if (month > 9)
                        {
                            Console.WriteLine($"{newDays}.{month}");                        
                        }

                    }
                    break;
                case 4:                                 //30days
                case 6:
                case 9:
                case 11:
                    if (newDays > 30)
                    {
                        newDays -= 30;
                        if (month < 9)
                        {
                        Console.WriteLine($"{newDays}.0{month + 1}");
                        }
                        else
                        {
                        Console.WriteLine($"{newDays}.{month + 1}");
                        }
                    }
                    else
                    {
                        if (month < 10)
                        {
                        Console.WriteLine($"{newDays}.0{month}");
                        }
                        else
                        {
                            Console.WriteLine($"{newDays}.{month}");
                        }
                    }
                    break;
                case 2:                                  //28days
                    if (newDays > 28)
                    {
                        newDays -= 28;
                        Console.WriteLine($"{newDays}.{month + 1:d2}");
                    }
                    else
                    {
                        Console.WriteLine("{0}.{1:d2}", newDays, month);
                    }
                    break;
            }
        }
    }
}
