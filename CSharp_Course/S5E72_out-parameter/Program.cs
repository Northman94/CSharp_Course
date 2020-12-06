using System;

namespace S5E72_outparameter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Out_calc calc = new Out_calc();

            if (calc.TryDivide(divisible: 10, divisor: 2, out double res))
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Division Failed");
            }

            /*
             
            Console.WriteLine("Pls, enter a number");
            string line = Console.ReadLine();

            //Before C# 6:
            int numb;
            bool wasParsed = int.TryParse(line, out numb);
            //Try-methods use out modificator

            if (wasParsed)
            {
                Console.WriteLine(numb);
            }
            else
            {
                Console.WriteLine("Failed to Parce.");
            }

            Console.WriteLine(wasParsed);

            */

            Console.WriteLine("Pls, enter a number");
            string line = Console.ReadLine();

           
            bool wasParsed = int.TryParse(line, out int result); //or var
            //Try-methods use out modificator

            if (wasParsed)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Failed to Parce.");
            }

            Console.WriteLine(wasParsed);

            // // // // // // // // // // // // // // //


            
            
        }
    }
}
