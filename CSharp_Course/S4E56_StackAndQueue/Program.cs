using System;
using System.Collections.Generic;

namespace S4E56_StackAndQueue
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Stack:

            var stack = new Stack<int>();
            //Needs to be constructed by calling constructor with no parameners "()"

            stack.Push(1);
            stack.Push(4);
            stack.Push(5);
            stack.Push(8);

            Console.WriteLine($"Print out 8: {stack.Peek()}");

            Console.WriteLine(stack.Pop()); //Same as Peak + deletes iteam

            Console.WriteLine($"Print out 5: {stack.Peek()}");


            //Stack iteration from end to begining:
            foreach (var item1 in stack)
            {
                Console.WriteLine(item1);
            }
            // -- -- -- -- -- -- -- -- -- -- 

            //Queue:

            var queue = new Queue<int>();

            queue.Enqueue(7);
            queue.Enqueue(3);
            queue.Enqueue(0);
            queue.Enqueue(1);

            Console.WriteLine($"Print out 7: {queue.Peek()}");

            queue.Dequeue();

            Console.WriteLine($"Print out 3: {queue.Peek()}");

            foreach (var item2 in queue)
            {
                Console.WriteLine(item2);
            }
        }
    }
}
