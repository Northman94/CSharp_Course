using System;

namespace S2E23_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name ?\n");

            string name = Console.ReadLine();
            string line1 = $"Your age is {name}";
            Console.WriteLine(line1);


            Console.WriteLine("\nWhat is your age ?\n");
            string input = Console.ReadLine();
            int age = int.Parse(input); //string to int

            string sentence = $"Your age is {age}";
            Console.WriteLine(sentence);

            Console.Clear(); // Clears console

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.Write("\n"); // = Console.WriteLine("");
        }
    }
}
