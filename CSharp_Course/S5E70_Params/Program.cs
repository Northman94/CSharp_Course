using System;
using OverridenMethods;

namespace S5E70_Params
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Triangle_Overload tr_sq = new Triangle_Overload();


            double aver1 = tr_sq.Average(new int[] {1, 2, 3, 4});

            double aver2 = tr_sq.Average2(5, 4, 3, 2, 1);

            Console.WriteLine($" Aver1 = {aver1}; \n Aver2 = {aver2};");
        }
    }
}
