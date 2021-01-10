using System;

namespace S5E80_BoxingAndUnboxing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 1;

            object obj1 = x; //boxing process
            //object is a reference type

            int y = (int)obj1; //unboxing
            // -- -- -- -- -- -- -- -- --
            

            //Should get InvalidCastExeption:
            //Can't cast System.Double to System.Int32
            double pi = 3.14;
            object obj2 = pi;

            int number = (int)pi;
            Console.WriteLine(number);

            //Can use:
            number = (int)(double)pi;
            Console.WriteLine(number);

            Do(obj2);
        }

        static void Do(object obj2)
        {
            bool isPointRef = obj2 is PointRef;

            if (isPointRef)
            {
                PointRef pr = (PointRef) obj2;
                //obj.
                Console.WriteLine(pr.X);
            }

            //OR

            PointRef pr1 = obj2 as PointRef;
            if (pr1 != null)
            {
                Console.WriteLine(pr1.X);
            }
        }

        private class PointRef
        {
            public int X;
            public int Y;

            public void LogValues()
            {
                Console.WriteLine($"X = {X}; Y = {Y};");
            }
        }
    }
}
