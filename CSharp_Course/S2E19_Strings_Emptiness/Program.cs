using System;

namespace S2E19_Strings_Emptiness
{
    class Program
    {
        static void Main(string[] args)
        {
            string nullString = null; // = instance absence in memory. No name.method
            string empty = "";
            string empty2 = string.Empty; // Same as ""
            string whiteSpaced = " ";
            string spaceAndChara = " H";
            

            Console.WriteLine("IsNullOrEmpty");

            bool IsNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(IsNullOrEmpty); //True

            IsNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(IsNullOrEmpty); //True

            IsNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(IsNullOrEmpty); //False

            IsNullOrEmpty = string.IsNullOrEmpty(spaceAndChara);
            Console.WriteLine(IsNullOrEmpty); //False


            Console.WriteLine("\nIsNullOrWhiteSpace");

            bool isNullOrWhitespaced = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(isNullOrWhitespaced); // True

            isNullOrWhitespaced = string.IsNullOrWhiteSpace(empty);// !!!
            Console.WriteLine(isNullOrWhitespaced); // True

            isNullOrWhitespaced = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(isNullOrWhitespaced); // True

            isNullOrWhitespaced = string.IsNullOrWhiteSpace(spaceAndChara);
            Console.WriteLine(isNullOrWhitespaced); //False
        }
    }
}
