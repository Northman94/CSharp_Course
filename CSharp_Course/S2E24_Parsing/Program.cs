using System;

namespace S2E24_Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Приведение типов меньших к большим:
            byte b = 3;   // 0000 0011 // = 8 bit
            int i = b;   // 0000 0000 0000 0000 0000 0000 0000 0011 // 32 bit
            long l = i; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

            float f = i; // 3.0

            // We shouldnt put BIGGER in SMALLER type;
            // But though we can: put int 3 in byte 3.
            // Явное приведение: (implicit type convertion or cast)
            b = (byte)i; // int to byte

            f = 3.1f;
            i = (int)f; // = 3

            // Несовместимые типы:
            string str = "1";
            // i = (int)str; // Can't do this, but:
            i = int.Parse(str);
            Console.WriteLine($"Parsed i = {i}");

            //-- -- -- -- -- -- -- --

            int x = 5;
            int result = x / 2; // = 2

            double result2 = (double)x / 2; // 2.5
        }
    }
}
