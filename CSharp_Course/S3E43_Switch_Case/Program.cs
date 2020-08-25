using System;

namespace S3E43_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearsMarried = int.Parse(Console.ReadLine());

            string name = string.Empty;

            switch (yearsMarried)
            {
                case 5:
                    name = "Wooden";
                    break;
                case 10:
                    name = "Tin"; //Олово
                    break;
                case 15:
                    name = "Crystal";
                    break;
                case 20:
                    name = "Porcelain"; //Фарфор
                    break;
                case 25:
                    name = "Silver";
                    break;
                case 30:
                    name = "Perl";
                    break;
                default:
                    name = "Good Luck!";
                    break;
            }
            Console.WriteLine(name);

            int month = int.Parse(Console.ReadLine());

            string season = string.Empty;
            switch (month) 
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autmn";
                    break;
                default:
                    throw new ArgumentException("Unexpected month.");
            }
            Console.WriteLine(season);

        }
    }
}
