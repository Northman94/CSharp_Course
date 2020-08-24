using System;
using System.Security.Cryptography.X509Certificates;

namespace S3E42_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            int counterBreak = 0;

            // Pairs which summ == 0
            for (int i = 0; i < numbs.Length - 1; i++) // -1 => last, nothing to compare with
            {
                for (int j = i + 1; j < numbs.Length; j++)
                {
                    int atI = numbs[i];
                    int atJ = numbs[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"pair ({atI};{atJ}). Indexes ({i};{j})");
                        counterBreak++;
                    }

                    if(counterBreak == 3) 
                    {
                        break;
                    }
                }
            }

            // - - - - - - - - - - - - - - - - - - - - - - - 
            int[] numbArr1 = {0, 5, 2, 8, 4, 1, 6, 7, 3, 9};
            char[] letters = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'};

            for(int i = 0; i < numbArr1.Length; i++) 
            {
                Console.WriteLine($"\nNumber = {numbArr1[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbArr1[i] == j) 
                    {
                        break; //Stops cycle execytion & goes to higher level cycle
                    }
                    Console.Write($"{letters[j]} ");
                }
            }


            // - - - - - - - - - - - - - - - - - - - - - - 
            int[] numbArr2 = { 0, 5, 2, 8, 4, 1, 6, 7, 3, 9 };

            foreach (int n in numbArr2) 
            {
                /*
                if (n % 2 == 0) 
                {
                    Console.WriteLine(n);
                }
                */
                if (n % 2 != 0) 
                {
                    continue;
                }
                Console.WriteLine(n);
            }
        }
    }
}