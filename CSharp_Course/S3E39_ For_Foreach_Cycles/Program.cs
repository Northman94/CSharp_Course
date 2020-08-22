using System;

namespace S3E39__For_Foreach_Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};


            for (int i = 0; i < numbers.Length; i++) //from 1[0] to 9[8]
            {
                Console.WriteLine(numbers[i] + " "); //In Column
            }

            for(int j = numbers.Length - 1; j >= 0; j--) 
            {
                Console.Write(numbers[j] + " "); // In a Row
            }

            Console.WriteLine();
            for (int k = 0; k < numbers.Length; k++) 
            {
                if (numbers[k] % 2 == 0) // Euclidean division //Остаток от деления
                {
                    Console.WriteLine(numbers[k] + " "); //2 4 6 8 v
                }
            }


            foreach (int p in numbers) 
            {
                Console.WriteLine(p + " p");
            }
        }
    }
}
