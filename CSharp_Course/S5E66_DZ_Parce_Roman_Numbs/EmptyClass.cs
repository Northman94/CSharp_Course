using System.Collections.Generic;

namespace S5E66_DZ_Parce_Roman_Numbs
{
    public class Roman_Numeral
    {
        // III = 1+1+1
        //  IV = 5-1
        // XIV = 10-1+5

        private static Dictionary <char, int> maping = new Dictionary <char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000}
        };

        public static int Parcing(string roman)
        {
            int result = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                if(i+1 < roman.Length && IsSubstractive(roman[i], roman[i+1]))
                {
                    result -= maping[roman[i]];
                }
                else
                {
                    result += maping[roman[i]];
                }
            }
            return result;
        }


        private static bool IsSubstractive(char c1, char c2)
        {
            return maping[c1] < maping[c2];
        }
    }
}
