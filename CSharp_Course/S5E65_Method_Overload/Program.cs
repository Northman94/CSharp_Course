using System;

namespace S5E65_Method_Overload
{
    class Calculator
    {
        public double  CalcTriangleSquare(double ab, double bc, double ac)
        {
            double p = (ab + bc + ac) / 2;

            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }

        public double CalcTriangleSquare(double basis, double height)
        {
            return 0.5 * basis * height;
        }
    }
}
