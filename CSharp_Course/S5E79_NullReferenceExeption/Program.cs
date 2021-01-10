using System;

namespace S5E79_NullReferenceExeption
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PointRef c; //OR  = null;

            Console.WriteLine(c.X); // NullReferenceExeprion
            //-- -- -- -- -- -- -- -- -- -- -- -- --


            PointVal? pv = null;

            if (pv.HasValue)
            {
                PointVal pv2 = pv.Value;

                Console.WriteLine(pv.Value.X);
                Console.WriteLine(pv2.X); //Same
            }

            //OR THIS VARIATION instead of if block:
            PointVal pv3 = pv.GetValueOrDefault();
        }

        static struct PointVal
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
