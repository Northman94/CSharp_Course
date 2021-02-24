using System;
using System.Collections;
using System.Collections.Generic;

namespace S5E92_foreachAndIEnumerable
{
    public class GenerStack<T> : IEnumerable<T>
    {
        private T[] _items;

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

            _items = new T[defaultCapacity];
        }

        //Constructor #2
        public GenerStack(int capacity)
        {
            _items = new T[capacity];
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

        public IEnumerator<T> GetEnumerator()
        {
            return new StackEnumerator<T>(_items, Count);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    public class StackEnumerator<T> : IEnumerator<T>
    {
        private readonly T[] array;
        private readonly int count;

        // Iterator:
        private int position;

        // Constructor:
        public StackEnumerator(T[] _array, int count)
        {
            this.array = _array;
            this.count = count;

            position = count;
        }

        
        // public T Current => throw new NotImplementedException();
        // which is:
        public T Current
        {
            get
            {
                return Current;
            }
        }


        // object IEnumerator.Current => throw new NotImplementedException();
        // which is:
        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            position--;
            return position >= 0;
        }

        public void Reset()
        {
            position = count;
        }
    }
}
