using System;

namespace PassTask
{
    class PassTask
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = Console.ReadLine();

            string check = Console.ReadLine();            

            while (check != pass )
            {
                check = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {user}!");

        }
    }
}
