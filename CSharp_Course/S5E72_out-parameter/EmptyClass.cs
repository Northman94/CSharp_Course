using System;

namespace S5E72_outparameter
{
    public class Out_calc
    {
        public bool TryDivide(double divisible, double divisor, out double res)
        {
            res = 0; //always initialize OUT

            if (divisor == 0)
            {
                return false;
            }
            else
            {
                res = divisible / divisor;
                return true;
            }
        }
    }
}
