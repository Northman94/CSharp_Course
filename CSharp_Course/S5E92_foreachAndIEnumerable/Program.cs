using System;

namespace S5E92_foreachAndIEnumerable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GenerStack<int> ms = new GenerStack<int>();
            System.Collections.IEnumerable enu = (System.Collections.IEnumerable)ms;

            enu.GetEnumerator();

            ms.Push(1);
            ms.Push(2);
            ms.Push(3);
            //Now Compiler will forbid to use non-int values!!!

            /*
            var enumerator = ms.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            */

            //vvv Лучшая вариация чем ^^^
            foreach (var item in ms)
            {
                Console.WriteLine(item);
            }
            
            while (ms.Count != 0)
            {
                //No need to use explicit convertation to (int)
                Console.WriteLine(ms.Peek());
                ms.Pop();
            }

            Console.WriteLine(ms.Peek()); //3
            // Show last

            ms.Pop(); // Delete last

            Console.WriteLine(ms.Peek()); //2

            ms.Push(3);
            ms.Push(4);
            ms.Push(5);

            Console.WriteLine(ms.Peek()); //5
        }
    }
}
