using System;

namespace S5E73_Static_Modificator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Due to method being static, no need to create
            // Class instance (экз. класса), to adress to the method
            
            double result = Calculator.Average(4, 5, 6);

            Console.WriteLine(result);
        }
    }
}
