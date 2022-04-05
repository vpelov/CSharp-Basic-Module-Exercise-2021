using System;

namespace MagicNumber
{
    class MagicNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //int a = 9;
            //int b = 9;
            //int c = 9;
            //int d = 9;
            //int e = 9;
            //int f = 9;

            for (int i = 1; i <= 9; i++)
            {               
                for (int o = 1; o <= 9; o++)
                {                    
                    for (int p = 1; p <= 9; p++)
                    {                       
                        for (int s = 1; s <= 9 ; s++)
                        {                           
                            for (int k = 1; k <= 9; k++)
                            {                               
                                for (int g = 1; g <= 9; g++)
                                {
                                    int f = i * o * p * s * k * g;

                                    if (f == n )
                                    {
                                        Console.Write($"{i}{o}{p}{s}{k}{g} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }



        }
    }
}
