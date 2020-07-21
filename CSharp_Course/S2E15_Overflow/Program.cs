using System;

namespace S2E15_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //checked // !!!
            //{
                uint x = uint.MaxValue;

                Console.WriteLine(x); // 4294967295

                x += 1;

                Console.WriteLine(x); // 0 = Overflow

                x -= 1;

                Console.WriteLine(x); // 4294967295
            //}

        }
    }
}
