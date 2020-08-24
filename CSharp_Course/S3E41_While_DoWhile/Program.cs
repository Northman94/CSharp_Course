using System;

namespace S3E41_While_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;

            while(age < 18) 
            {
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }

            //- - - - - - - - - - - - - - - - - - - -
            int count = -8;
            do
            {
                Console.WriteLine(count);
                count++;
            }
            while (count <= 8);

            //- - - - - - - - - - - - - - - - - - - -
            int[] numb = {-6, 4, 8, 5, 10};
            int i = 0;

            while (i < numb.Length) 
            {
                Console.WriteLine(numb[i] + " ");
                i++;
            }
        }
    }
}
