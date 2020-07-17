using System;

namespace S2E13_Literals
{     
    class Literals
    {
        static void Main(string[] args)
        {
            Variables();
        }

        static void Variables()
        {
            Console.WriteLine("Hello World!");


            int x = 0b11;           // (11 = 3)
            int y = 0b1001;       // ( = )

            int k = 0b10001001;
            For more convenience we can write it in this way too:
            int m = 0b1000_1001;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);


            Console.ReadLine();
        }
    }
}
