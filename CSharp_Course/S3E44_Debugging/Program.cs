using System;

namespace S3E44_Debugging
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Square of triangle calculation");

            Console.WriteLine("Enter length of AB side");
            double AB = GetDouble();


            Console.WriteLine("Enter length of BC side");
            double BC = GetDouble();


            Console.WriteLine("Enter length of CD side");
            double AC = GetDouble();

            double p = (AB + BC + AC) / 2;

            double square = Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
            Console.WriteLine($"Square of the triangle equals {square}");
        }


        static double GetDouble()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}
