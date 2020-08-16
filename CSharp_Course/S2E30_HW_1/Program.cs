using System;

namespace S2E30_HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.\n");

            string userName = Console.ReadLine();

            Console.WriteLine($"Hello, dear user, {userName} \n");

            // -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
            Console.WriteLine("\nPlease enter 1st int:");
            string numb1 = Console.ReadLine();
            int int1 = int.Parse(numb1);

            Console.WriteLine("\nPlease enter 2nd int:");
            string numb2 = Console.ReadLine();
            int int2 = int.Parse(numb2);

            Console.WriteLine($"Entered numbs: {int1} & {int2}");

            // -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
            // Reversing:

            int mediator = int2;
            int2 = int1;
            int1 = mediator;

            Console.WriteLine($"Reversed numbs: {int1} & {int2}");

            // -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

            Console.WriteLine("\nPlease enter 3rd int:");
            string numb3 = Console.ReadLine();
            //string is already Array of Chars
            int charAmmount = numb3.Length;

            Console.WriteLine(charAmmount);
        }
    }
}
