using System;
using System.Dynamic;

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

            // -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
            // S2E33_HW_2
            Console.WriteLine("\n\n We have a triangle. Let's find it's square/area.");
            Console.WriteLine("Enter side a cm size:");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter side b cm size:");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter side c cm size:");
            float c = float.Parse(Console.ReadLine());
            // P is a triangle half preimeter
            float p = (a + b + c) / 2;

            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"Triangle suqare area is: {S} cm2");

            
            // -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
            //S2E34_HW3    -   Body mass index
            Console.WriteLine("Please Enter your profile surname");
            string surname = Console.ReadLine();
            
            Console.WriteLine("Please Enter your profile name");
            string name = Console.ReadLine();

            Console.WriteLine("Please Enter your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter your weight (Kg)");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter your height (Meters)");
            float height = float.Parse(Console.ReadLine());

            float BMI = weight / (height * height);

            Console.WriteLine(
                $"\n\n Your profile: \n" +
                $"Full name: {surname} {name};\n " +
                $"Age: {age};\n " +
                $"Weight: {weight};\n " +
                $"Height: {height};\n " +
                $"Body Mass index: {BMI}.");

            // -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
            //Same variation
            Console.WriteLine(
                $"\n\n Your profile: {Environment.NewLine} " +
                $"Full name: {surname} {name}; {Environment.NewLine}" +
                $"Age: {age}; {Environment.NewLine}" +
                $"Weight: {weight}; {Environment.NewLine}" +
                $"Height: {height}; {Environment.NewLine}" +
                $"Body Mass index: {BMI}.");

        }
    }
}
