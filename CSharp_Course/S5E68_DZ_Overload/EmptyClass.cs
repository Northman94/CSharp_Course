using System;


namespace SpaceName2
{
    public class Triangle_Overload
    {
        public double TwoSides(double s1, double s2, double alpha)
        {
            //Convert Radians to Degrees:
            double rads_to_degr = alpha * Math.PI / 180;

            return 0.5 * s1 * s2 * Math.Sin(rads_to_degr);
        }
    }
}
