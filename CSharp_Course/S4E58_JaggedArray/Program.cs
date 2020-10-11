using System;

namespace S4E58_JaggedArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Jagged Array [][] = зубчатый массив

            // 1
            // 2 3 4
            // 5 6
            // 7 8 9 10

            int[][] jaggedArray = new int[4][]; // 4 rows Array length

            jaggedArray[0] = new int[1]; //new sub-Array length (column)
            jaggedArray[1] = new int[3]; //new sub-Array length (column)
            jaggedArray[2] = new int[2]; //new sub-Array length (column)
            jaggedArray[3] = new int[4]; //new sub-Array length (column)


            Console.WriteLine("\nPlease fill the Array:");

            for (int i = 0; i < jaggedArray.Length; i++) //4
            {
                for (int p = 0; p < jaggedArray[i].Length; p++) //Column length
                {
                    string st = Console.ReadLine();
                    jaggedArray[i][p] = int.Parse(st);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Result:");

            for (int i = 0; i < jaggedArray.Length; i++) //4
            {
                for (int p = 0; p < jaggedArray[i].Length; p++) //Column length
                {
                    Console.Write(jaggedArray[i][p] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}