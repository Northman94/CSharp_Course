using System;

namespace S4E57_MultidimensionalArrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 1 2 3
            // 4 5 6

            int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
                //OR
            int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //(1) = dimention
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
