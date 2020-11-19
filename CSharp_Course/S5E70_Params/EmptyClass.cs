using System;

namespace OverridenMethods
{
    public class Triangle_Overload
    {
        public double Average(int[] numbs)
        {
            int sum1 = 0;

            foreach (int n in numbs)
            {
                sum1 += n;
            }
            return (double)sum1 / numbs.Length; 
        }


        // Implicit Arr creation.
        //In case of giving multiple arguments
        //the one with params should be last
        public double Average2(params int[] numbs)
        {
            int sum2 = 0;

            foreach (int n in numbs)
            {
                sum2 += n;
            }
            return (double)sum2 / numbs.Length;
        }
    }
}
