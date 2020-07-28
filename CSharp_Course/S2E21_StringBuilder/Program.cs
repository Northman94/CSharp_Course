using System;
using System.Text;

namespace S2E21_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // StringBuilder is the Fastest solution for big strings Concatination
            StringBuilder sb = new StringBuilder();
            // Requires:  using System.Text;
            sb.Append("Great ");
            sb.Append("day");
            sb.AppendLine("!");  // Transfers cursor to the new line
           
            string concatResult = sb.ToString();
            Console.WriteLine(concatResult);
        }
    }
}
