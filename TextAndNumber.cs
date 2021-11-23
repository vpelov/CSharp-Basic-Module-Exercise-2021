using System;

namespace TextAndNumber
{
    class TextAndNumber
    {
        static void Main()
        {
            Console.WriteLine("Please insert your First Name:");
            var FirstName = Console.ReadLine();
            Console.WriteLine("Please insert your Last Name:");
            var LastName = Console.ReadLine();
            Console.WriteLine("How old are you?:");
            var Old = int.Parse(Console.ReadLine());
            Console.WriteLine("Where are you From?");
            var Town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {3} years old from {2}", FirstName, LastName, Town, Old);
        }
    }
}
