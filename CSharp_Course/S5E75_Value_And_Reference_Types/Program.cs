using System;

namespace S5E75_Value_And_Reference_Types
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Экземпляр структуры:
            PointVal a1; //or PointVal a1 = new PointVal();

            a1.X = 3;
            a1.Y = 5;

            PointVal b2 = a1;

            b2.X = 7;
            b2.Y = 10;


            a1.LogValues(); //X = 3 & Y = 5;
            b2.LogValues(); //X = 7 & Y = 10;

            Console.WriteLine("\n\n");

            //Ref types only fuly declared:
            PointRef c3 = new PointRef();

            c3.X = 3;
            c3.Y = 5;

            PointRef d4 = c3;

            d4.X = 7;
            d4.Y = 10;


            c3.LogValues(); // X = 7 & Y = 10;
            d4.LogValues(); // X = 7 & Y = 10;
        }
    }
}
