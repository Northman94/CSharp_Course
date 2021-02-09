using System;
using System.Collections.Generic;

namespace S5E87_Extension_Methods_Interfaces
{
    public interface IBaseCollection
    {
        //Will have basic functionality.
        void Add(object obj);

        void Remove(object obj);
    }


    //Extension method:
    public static class BaseCollectionExtension
    {
        public static void AddRange(this IBaseCollection IColl, IEnumerable <object> objects)
        {
            foreach (var item in objects)
            {
                IColl.Add(item);
                Console.WriteLine("!!!");
            }
        }
    }
    Ъ


    // Class:
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
            Console.WriteLine("+++");
        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}

