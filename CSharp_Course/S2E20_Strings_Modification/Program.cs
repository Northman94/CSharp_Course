using System;

namespace S2E20_Strings_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameConcat = string.Concat("Her", "name", "is", "Sarah.");
            nameConcat = string.Join(" ", "My ", "name ", "is ", "John.");
            // First is separator. Result will be similar.

            nameConcat = "My " + "name " + "is " + "John."; // Variation

            string newName = nameConcat.Insert(0, "By the way, ");
            // Or
            nameConcat = nameConcat.Insert(0, "By the way, ");

            // nameConcat.Insert(0, "By the way, ");
            // Without assigning to a variable will not work


            nameConcat = nameConcat.Remove(5); // Starting index
            nameConcat = nameConcat.Remove(5, 3); // + ammount of symbols

            string replaced = nameConcat.Replace('J', 'R'); //All J to R


            string data = "12;28;45;98;99";
            string[] splitData = data.Split(';');
            string first = splitData[0];
            Console.WriteLine(first); // 12


            char[] chars = nameConcat.ToCharArray(); //string to char array
            Console.WriteLine(chars[0]);
            // Or just one line:
            Console.WriteLine(nameConcat[0]);

            string lower = nameConcat.ToLower();  // All to lowercase
            string upper = nameConcat.ToUpper(); // All to uppercase

            // 2 same String lines with one e.g. uppercase char will not be ==

            string spaces = "  Prosperity  ";
            Console.WriteLine(spaces.Trim()); // Cutting side spaces
        }
    }
}
