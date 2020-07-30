using System;
using System.Threading;

namespace S2E22_Strings_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abcde";
            string str2 = "abcde";

            bool areEqual = str1 == str2; // true
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, StringComparison.Ordinal); //same variation
            Console.WriteLine(areEqual);
            

            string ln1 = "Strasse";
            string ln2 = "Straße";

            areEqual = string.Equals(ln1, ln2, StringComparison.Ordinal); //False // Bite comparison
            Console.WriteLine("\n" + areEqual);
            areEqual = string.Equals(ln1, ln2, StringComparison.InvariantCulture); // True // Slower
            Console.WriteLine(areEqual);
            areEqual = string.Equals(ln1, ln2, StringComparison.CurrentCulture); // True
            //Depends on System Language.
            Console.WriteLine(areEqual);

            // Current Culture can be modified:
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }
    }
}
