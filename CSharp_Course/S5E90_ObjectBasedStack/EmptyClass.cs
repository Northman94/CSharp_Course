using System;
namespace S5E90_ObjectBasedStack
{
    public class MyStack
    {
        private object[] _items;

        //Property
        public int Count { get; private set; }

        //Readonly Property
        public int Capacity
        {
            get
            {
                return _items.Length;
            }
        }


        //Constructor
        public MyStack()
        {
            const int defaultCapacity = 4;

            _items = new object[defaultCapacity];
        }

        //Constructor #2
        public MyStack(int capacity)
        {
            _items = new object[capacity];
        }


        public void Push(object item)
        {
            if(_items.Length == Count)
            {
                object[] largerArr = new object[Count * 2];
                Array.Copy(_items, largerArr, Count);

                _items = largerArr;
            }
            // Приоритет операци взятия индекса [],
            // приоритетние постфикс инкремента
            _items[Count++] = item;
        }

        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            // Префиксный дикримент приоритетние взятия индекса[]
            _items[--Count] = null; 
        }

        public object Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return _items[Count - 1];
            // Не декрементируем каунтер, а берем последний элемент
            // ибо индексы идус с нуля
        }
    }
}
