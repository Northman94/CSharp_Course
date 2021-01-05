using System;

namespace S5E77_StructuresContainingRefTyte
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            EvilStruct es1 = new EvilStruct();
            es1.PointRef = new PointRef() { X = 1, Y = 2};
            //OR
            //es1.PointR.X = 1;
            //es1.PointR.Y = 2;
            EvilStruct es2 = es1;

            Console.WriteLine($@"es1.PointRef.X = {es1.PointRef.X},
                                 es1.PointRef.Y = {es1.PointRef.Y}");

            Console.WriteLine($@"es2.PointRef.X = {es2.PointRef.X},
                                 es2.PointRef.Y = {es2.PointRef.Y}");

            es2.PointRef.X = 3;
            es2.PointRef.Y = 4;

            Console.WriteLine($@"es1.PointRef.X = {es1.PointRef.X},
                                 es1.PointRef.Y = {es1.PointRef.Y}");

            Console.WriteLine($@"es2.PointRef.X = {es2.PointRef.X},
                                 es2.PointRef.Y = {es2.PointRef.Y}");


            //Result:
            //es1.PointRef.X = 1, es1.PointRef.Y = 2
            //es2.PointRef.X = 1, es2.PointRef.Y = 2

            //es1.PointRef.X = 3, es1.PointRef.Y = 4
            //es2.PointRef.X = 3, es2.PointRef.Y = 4
        }
    }
}