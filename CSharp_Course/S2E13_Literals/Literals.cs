﻿using System;

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

            // Binary:
            int x = 0b11;           //(11 = 3)
            int y = 0b1001;        //( 1001 = 9)

            int k = 0b10001001;
            //For more convenience we can write it in this way too with "_" in any place:
            int m = 0b10_00_1001;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            Console.WriteLine("\n");

            // Hexadecimal:
            x = 0x1F;
            y = 0xFF0D;
            k = 0x1FAB30EF;
            m = 0x1FAB_30EF;  // Also can use "_" in any place.

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);


            Console.WriteLine(4.5e2);    //= 4.5 * 10^2 = 450
            Console.WriteLine(3.1E-1);  //= 3.1 * 10^-1 = 0,31
            Console.WriteLine();

            Console.WriteLine('\x78');    // Hexadecimal value is used. x
            Console.WriteLine('\x5A');   // Z

            //Unicode:
            Console.WriteLine('\u0420');  // P 
            Console.WriteLine('\u0421'); // C

            Console.ReadLine();
        }
    }
}
