using System;

namespace S5E91_TransformToGenericStack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GenerStack<int> ms = new GenerStack<int>();

            ms.Push(1);
            ms.Push(2);
            ms.Push(3);

            //Now Compiler will forbid to use non-int values!!!

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
