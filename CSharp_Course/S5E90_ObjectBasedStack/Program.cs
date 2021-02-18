using System;

namespace S5E90_ObjectBasedStack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyStack ms = new MyStack();

            ms.Push(1);
            ms.Push(2);
            ms.Push(3);
            /*
            ms.Push("text");
            ms.Push(false);
            ms.Push('Q');
            ms.Push(3.5);
            //ms.Push(new Character(Race.Elf));

            while (ms.Count != 0)
            {
                Console.WriteLine((int)ms.Peek());
                ms.Pop();
                // Will cause InvalidCastExeption!!!
            }
            */

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
