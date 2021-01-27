using System;

namespace S5E86_Interface
{
    public interface IBaseCollection
    {
        //Will have basic functionality.
        void Add(object obj);

        void Remove(object obj);
    }


    public class BaseList : IBaseCollection
    {
        private int count = 0;
        private object[] items;

        public BaseList(int initialCapacity)
        {
            items = new object[initialCapacity];
        }


        public void Add(object obj)
        {
            items[count] = obj;
            count++;
        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}
