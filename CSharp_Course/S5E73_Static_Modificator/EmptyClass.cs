using System;

namespace S5E73_Static_Modificator
{
    public class Calculator
    {
        //static - method
        public static double Average(double x, double y, double z)
        {
            return (x + y + z) / 3;
        }

        // this Class can be static to prevent
        // Calculator Class instance creation
        // in another Class.
    }
}
