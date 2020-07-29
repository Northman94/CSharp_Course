using System;
using System.Text;
using System.Threading;

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

            //Slash for slash // Экранирование // \t - флаг экранрования
            string str7 = "C:\\tmp\\best_file.txt";

            // Verbatim strings for same purpose
            string str8 = @"C:\tmp\best_file.txt";

            // Special string formatting
            int answer = 42;
            string result = string.Format("{0:d}", answer); //d - is for whole numbs //42
            string result2 = string.Format("{0:d4}", answer); //0042

            result = string.Format("{0:f}", answer);    //42.00
            result2 = string.Format("{0:f4}", answer); //42.0000

            double numDouble = 25.08;
            string res3 = string.Format("{0:f}", numDouble);   //25.08
            string res4 = string.Format("{0:f1}", numDouble); //25.1 rounded

            Console.OutputEncoding = Encoding.UTF8;
            double money = 12.8;
            result = string.Format("{0:C}", money);    //$12.80
            result2 = string.Format("{0:C2}", money); //$12.80 system currenccy

            Console.WriteLine(money.ToString("C2")); // Same

            result = $"{money:C2}"; //Same


            // Change system currency to $:
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine(money.ToString("C2"));
        }
    }
}
