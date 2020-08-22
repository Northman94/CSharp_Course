using System;

namespace S3E40__Cycle_In_Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            // Pairs which summ == 0
            for (int i = 0; i < numbs.Length - 1; i++) // -1 => last, nothing to compare with
            {
                for(int j = i + 1; j < numbs.Length; j++) 
                {
                    int atI = numbs[i];
                    int atJ = numbs[j];

                    if(atI + atJ == 0) 
                    {
                        Console.WriteLine($"pair ({atI};{atJ}). Indexes ({i};{j})");
                    }
                }
            }
            Console.WriteLine("\n");

            //Triplets summ == 0
            for (int i = 0; i < numbs.Length - 2; i++)
            {
                for (int j = i + 1; j < numbs.Length - 1; j++)
                {
                    for (int k = 0; k < numbs.Length; k++)
                    {
                        int atI = numbs[i];
                        int atJ = numbs[j];
                        int atK = numbs[k];

                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"pair ({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
                        }
                    }
                }
            }
        }
    }
}
