using System;

namespace BarkodGeneratorTwo
{
    class BarkodGeneratorTwo
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int working = begin;

            while (working <= end)
            {
                if (working /1000 % 10 >= begin / 1000 % 10 &&  working / 1000 % 10 <= end / 1000 % 10 && (working / 1000 % 10) % 2 != 0 )
                {
                    if (working / 100 % 10 >= begin / 100 % 10 && working / 100 % 10 <= end / 100 % 10 && (working / 100 % 10) % 2 != 0)
                    {
                        if (working / 10 % 10 >= begin / 10 % 10 && working / 10 % 10 <= end / 10 % 10 && (working / 10 % 10) % 2 != 0)
                        {
                            if (working % 10 >= begin % 10 && working % 10 <= end % 10 && (working % 10) % 2 != 0)
                            {
                                Console.Write($"{working} ");
                            }
                        }
                    }
                }


                working++;
            }

        }
    }
}
