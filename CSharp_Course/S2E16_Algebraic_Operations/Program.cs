using System;
using System.Numerics;

namespace S2E16_Algebraic_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Increment_Decrement_Variations();
            Combined();
            Comparison();
        }

        static void Increment_Decrement_Variations()
        {
            int x = 1;


            // Increment:
            x = x + 1; // Operation goes from Right to Left

            x++;  // Postfix
            ++x; // Prefix/Infix

            // Decrement:
            x = x - 1;

            x--;
            --x;
            Console.WriteLine("\n");


            Console.WriteLine("Syntax difference: ");
            Console.WriteLine($"Last X state is: {x}"); // 1

            int j = x++; // "=" assignition operation has higher priority than postfix increment
            Console.WriteLine(j); // 1
            Console.WriteLine(x); // 2

            j = ++x;  // Prefix increment has higher priority than assignition
            Console.WriteLine(j); // 3
            Console.WriteLine(x); // 3

            // Another increment syntax:
            x += 2;  // x = x +2;

            j -= 2; // j = j - 2;
        }

        static void Combined() 
        {
            int q = 1;
            int y = 2;

            int z = q + y;       // 3
            int k = q - y;      // -1
            int a = z + k - y; // 0

            int b = z * 2; // 6
            int c = k / 2; // -1 / 2 = 0 due to (int) cutting off floationg point numbers

            // Остаток от деления (Чётность числа):
            a = 4 % 2; // 0
            b = 5 % 2; // 1

            int R = 5;
            int O = 8;
            R *= 2; // 10
            R /= 2; // 4


            // Priority change:
            int T = 2 + 2 * 2;    // 6
            int W = (2 + 2) * 2; // 8

        }

        static void Comparison() 
        {
            // Bool type is a result of comparison operators
            int P = 1;
            int L = 2;

            bool areEqual = P == L;
            Console.WriteLine(areEqual);


            // Operator of strict comparison:
            bool result = P > L; 
            Console.WriteLine(result);

            // Operator of non-strict comparison:
            result = P >= L; // true
            Console.WriteLine(result);

            result = P < L; // true
            Console.WriteLine(result);

            result = P <= L;
            Console.WriteLine(result);


            result = P != L; // "!=" as an non equal
            Console.WriteLine(result);
        }
    }
}
