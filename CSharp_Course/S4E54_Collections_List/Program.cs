using System;
using System.Collections.Generic;
using System.Linq;

namespace S4E54_Collections_List
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Basic List API(Application Programming Interface)

            //using System.Collections.Generic;
            var intList = new List<int> {1, 4, 2, 7, 5, 9, 12};
            intList.Add(8);


            int[] array1 = {1,2,3};

            //Covering Array with List
            intList.AddRange(array1);

            //Deletes only first than could find:
            if (intList.Remove(3))//returns bool
            {
                //do 
            }

            intList.RemoveAt(0);//by index

            intList.Reverse();

            bool contains = intList.Contains(2);


            //using System.Linq;
            int min = intList.Min();
            int max = intList.Max();

            Console.WriteLine($"Min = {min}, Max = {max}");



            int indexOf = intList.IndexOf(2); //First 2 to meet
            int lastIndexOf = intList.LastIndexOf(2); //Last 2 in List
            Console.WriteLine($"IndexOf2 = {indexOf}. LastIndexOf2 = {lastIndexOf}");

            
            //Array = .Length // List = .Count
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine($"{intList[i]}");
            }


            foreach (var item in intList)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
        }
    }
}
