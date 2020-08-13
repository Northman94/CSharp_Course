using System;

namespace S2E28_Arrays_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1;
            a1 = new int[10]; //10 elemnts = 40 bytes

            int[] a2 = new int[5];

            int[] a3 = new int [5] {1,3,-8,7,10}; // Array initialization

            int[] a4 = {1,3,2,4,-5};

            Console.WriteLine(a4[4]); //-5
            Console.WriteLine(a3[0]); //1

            int numb = a3[2];
            Console.WriteLine(numb);//-8

            //Overwrite:
            a4[0] = -6;

            Console.WriteLine(a4.Length); //Array Length = ammount of elements from 1
            // Last  Array element:
            Console.WriteLine (a4 [a4.Length - 1]);


            string s1 = "abcdefg";
            char first = s1[0];
            char last = s1[s1.Length - 1];

            Console.WriteLine($"First: {first}. Last: {last}");

            //Imposible string change:
            // s1[0] = 'Z';
        }
    }
}