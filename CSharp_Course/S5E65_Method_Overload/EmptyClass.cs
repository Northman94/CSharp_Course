using System;

namespace S5E65_Method_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            double square1 = calc.CalcTriangleSquare(10, 20);
            double square2 = calc.CalcTriangleSquare(40, 20, 30);

            Console.WriteLine($"Square1 = {square1}.\n Square2 = {square2}.");
        }
    }
}
