using System;
 

namespace S4E59_Change_Array_Index
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Arrays with not 0 start index works slower

            Array myArray = Array.CreateInstance(typeof(int), new[] {4}, new[] {1});
            //4 elements, starting count from 1, not 0.

            myArray.SetValue(2019, 1);
            myArray.SetValue(2019, 2);
            myArray.SetValue(2019, 3);
            myArray.SetValue(2019, 4); //Would trigger an Exeption, if started from 0.

            Console.WriteLine($"Starting index: {myArray.GetLowerBound(0)}");
            Console.WriteLine($"Ending index: {myArray.GetUpperBound(0)} \n");

            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            {
                Console.WriteLine($"{myArray.GetValue(i)} at insex {i}");
            }
            Console.WriteLine();

            //Same variation

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"{myArray.GetValue(i)} at insex {i}");
            }
        }
    }
}
