using System;

namespace S2E12_Variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = -1;

            int y;
            y = 2;

            //
            Int32 L1 = -1;
            //uint L2 = -1; //Only 0&+ varia

            float f = 1.1f; //Needs F, otherwise considered as double

            double d = 2.3;
            double d1 = 5.5d;

            //Equal lines:
            int x2 = 0;
            int x3 = new int();


            var a = 1;
            //Good to use for long written variable types
            //such as:
            //Dictionary<int, string> dict1 = new Dictionary<int, string>();

            //2nd variation
            //var dict2 = new Dictionary<int, string>();

            //var v; //No assigned variable will lead to an error

            decimal money = 3.5m;

            char Ch = 'G';

            string name = "Hi, there!";


            bool CanSing = true; //or false

            //Object types:
            object o1 = 1;
            object o2 = "Hello, again!";


            //if var type same as type - use @ in the name
            char @char = 'H';


            Console.WriteLine(d1);
        }
    }
}
