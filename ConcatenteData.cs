using System;

namespace ConcatenateData
{
    class ConcatenteData
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            string Family = Console.ReadLine();
            string Age = Console.ReadLine();
            string Town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", Name, Family, Age, Town);
        }
    }
}
