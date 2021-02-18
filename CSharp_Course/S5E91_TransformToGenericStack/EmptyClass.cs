using System;

namespace S5E91_TransformToGenericStack
{
    public class GenerStack<T>
    {
        private T [] _items;

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
        public GenerStack()
        {
            const int defaultCapacity = 4;

            _items = new T [defaultCapacity];
        }

        //Constructor #2
        public GenerStack(int capacity)
        {
            _items = new T [capacity];
        }


        public void Push(T item)
        {
            if (_items.Length == Count)
            {
                T[] largerArr = new T[Count * 2];
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
            /*
            // Префиксный дикримент приоритетние взятия индекса[]
            _items[--Count] = null;
            */
            // T не поддерживает null по этому используем:
            _items[--Count] = default(T); //or just default
        }

        public T Peek()
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
