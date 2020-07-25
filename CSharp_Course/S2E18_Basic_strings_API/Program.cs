using System;

namespace S2E18_Basic_strings_API
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Magnolia is a beautiful flower";

            bool containsA = name.Contains('a');  // True
            bool containsE = name.Contains('E'); // False

            bool endsWithsOwer = name.EndsWith("ower");   // True
            bool startsWithMag = name.StartsWith("Mag"); // True

            int indexOfA = name.IndexOf('a', 5); // With a starting index if neaded
            // Starting from 0
            //Result 7

            int lastIndexOfA = name.LastIndexOf('a'); // 16

            Console.WriteLine(name.Length); // Starting from 1. // 30

            string substrFrom20 = name.Substring(20); // ful flower // not including 20
            string substrFromTo = name.Substring(0,4); // Magn // not including 4
        }
    }
}
