using System;

namespace S2E27_Class_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 8;

            long c = Math.BigMul(a, b);
            // Multiplies 2x ints & stores to long
            Console.WriteLine(Math.BigMul(a, b)); // 40

            Console.WriteLine(Math.Pow(a,b)); // a^b // (a) в степени (b)

            Console.WriteLine(Math.Sqrt(9)); // 3

            Console.WriteLine(Math.Round(1.7));    // 2
            Console.WriteLine(Math.Round(1.3));   // 1
            Console.WriteLine(Math.Round(1.5));  // 2
            Console.WriteLine(Math.Round(2.5)); // 2 same as .ToEven
            Console.WriteLine();

            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero)); // 3
            // Rounding to the nearest numb away from zero

            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven)); // 2 same as Round
            // Rounding to nearest even (чётное) numb. Used in Banking
        }
    }
}
 