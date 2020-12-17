using System;

namespace S5E74_Optional_Parameters
{
    public class E73_Class
    {
        public static double CalcTriangleSquare(double ab, double ac, int alpha, bool isInRadians = false)
        {
            //Check on passing Radians type
            if (isInRadians)
            {
                return 0.5 * ab * ac * Math.Sin(alpha);
            }
            else
            {
                double inRadians = alpha * Math.PI / 180;

                return 0.5 * ab * ac * Math.Sin(inRadians);
            }   
        }
    }
}
