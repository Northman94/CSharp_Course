using System;

namespace S4E53_Array_No2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1;
            a1 = new int[10];


            int[] a2 = new int[5];

            int[] a3 = new int[5] {7, 3, 4, 8, -3};

            int[] a4 = {10, -7, 6, 2, 1};


            Array myArray5 = new int[5];

            //Same variation
            Array myArray6 = Array.CreateInstance(typeof(int), 5);
                  myArray6.SetValue(43, 0);

            //Can't be used to class Array:  Console.WriteLine(myArray6[0]);
            //Though:
            Console.WriteLine(myArray6.GetValue(0)); //43


            Console.WriteLine();

            //------------------------------------
            int[] a7 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //Binary search works only on sorted Array. Returns index.
            int indexS = Array.BinarySearch(a7, 8); //Uses IComparable
            Console.WriteLine("Index: " + indexS); //Index: 7

            Console.WriteLine();


            int[] copyArr1 = new int[10];
            Array.Copy(a7, copyArr1, a7.Length);

            int[] copyArr2 = new int[10];
            copyArr1.CopyTo(copyArr2, 0); //& 0 as a start index, not ammount of elements

            Array.Reverse(copyArr2);
            foreach (var item in copyArr2)
            {
                Console.WriteLine(item); //10 to 1
            }

            Console.WriteLine();

           //-------------------------
            Array.Sort(a4);
            foreach (var item2 in a4)
            {
                Console.WriteLine(item2);
            }
            
            Array.Clear(a4, 0, a4.Length); //0 as a start index
        }
    }
}
