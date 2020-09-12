using System;

namespace S3E45_DZ_Fibonacci
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pls Enter length of Fibonacci sequence:");
            int Fibonacci_sequence_length = GetArrayLength();

            int[] FiboArray = new int[Fibonacci_sequence_length];

            int a = 1;
            int b = 1;
            int summAB = 0;


            for (int i = 0; i < Fibonacci_sequence_length; i++)
            {
                if (i == 0)
                {
                    FiboArray[0] = a;
                }
                else if (i == 1)
                {
                    FiboArray[1] = b;
                }
                else
                {
                    summAB = a + b;

                    FiboArray[i] = summAB;

                    a = b;
                    b = summAB;
                }

                Console.Write(FiboArray[i] + ", ");
            }
        }

        static int GetArrayLength()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
