using System;
using SpaceName2;

namespace S5E68_DZ_Overload
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Triangle_Overload tr_over = new Triangle_Overload();


            Console.WriteLine("Enter 1st triangle side.");
            double side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd triangle side.");
            double side2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter triangle Angle.");
            double angle = double.Parse(Console.ReadLine());


            double result = tr_over.TwoSides(side1, side2, angle);

            Console.WriteLine(result);
        }
    }
}
