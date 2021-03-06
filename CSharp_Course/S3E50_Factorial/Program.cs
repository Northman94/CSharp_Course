﻿using System;

namespace S3E50_Factorial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Factorial => 5!  = 5 * 4 * 3 * 2 * 1

            Console.WriteLine("Please enter a number to count Factorial.");

            int FactorialInput = GetFactorial();
            int operationalVariable;


            if (FactorialInput == 0 || FactorialInput == 1)
            {
                Console.WriteLine($"Factorial of {FactorialInput}! = 1");
            }
            else
            {
                operationalVariable = FactorialInput;

                Console.Write($"Factorial of {FactorialInput}! = {FactorialInput} ");

                do
                {
                    operationalVariable--;

                    FactorialInput *= operationalVariable;

                    Console.Write($" * {operationalVariable}");
                }
                while (operationalVariable != 1);
            }

            Console.Write($" = {FactorialInput}."); 
        }

        static int GetFactorial()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}

            /*
            // Another shorter way:

            int n = int.Parse(Console.ReadLine());

            long factorial = 1; //Because 0! & 1! = 1;

            for (int i = 1; i < n; i++)
            {
                factorial *= i;
            }
            */