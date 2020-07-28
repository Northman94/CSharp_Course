using System;

namespace S2E22_String_Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 30;

            string str1 = "My name is" + name + "and I'm" + age + "y.o."; // Same
            
            string str2 = string.Format("My name is {0} and I'm {1} y.o.", name, age);

            //String interpolation: $"Text & {variable}";
            string str3 = $"My name is {name} and I'm {age} y.o.";
            
            Console.WriteLine(str2);

            // Escape-sequience
            // \n = new line
            string str4 = "The glass is \n half-full";
            //Or
            str4 = $"The glass is {Environment.NewLine} half-empty";
            // $"{Environment.NewLine}"  is cros-platform.
            // \n  = works differently on various platforms


            // \t = tabulation
            string str5 = "I'm\t30";  // I'm    30
            

            string str6 = "Phillip is a \"GOOD\" programmer";

            //Slash for slash // Экранирование
            string str7 = "C:\\tmp\\best_file.txt";
            Console.WriteLine(str7);

            // Verbatim strings for same purpose
            string str8 = @"C:\tmp\best_file.txt";

            Console.WriteLine(str8);
            

        }
    }
}
