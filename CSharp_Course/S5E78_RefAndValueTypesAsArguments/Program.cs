using System;
using System.Collections.Generic; //For List<>

namespace S5E78_RefAndValueTypesAsArguments
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;

            SwapValue(a, b); //passing Value-type

            Console.WriteLine($"By Value: A = {a}, B = {b}");


            //List<int> list = new List<int>();
            var list = new List<int>();

            AddNumbers(list);


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            SwapRef(ref a, ref b);

            Console.WriteLine($"By Ref: A = {a}, B = {b}");
        }

        static void SwapValue(int a, int b) //Uses a copy of Values
        {
            Console.WriteLine($"Original a = {a}, original b = {b}");

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"Swapped a = {a}, swapped b = {b}");
        }

        static void SwapRef(ref int a, ref int b) //Uses Reference to Values
        {
            Console.WriteLine($"Original a = {a}, original b = {b}");

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"Swapped a = {a}, swapped b = {b}");
        }

        static void AddNumbers(List <int> numbers)//Will use Ref
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }
    }
}
