using System;
using System.Collections.Generic;

namespace S5E87_Extension_Methods_Interfaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<object> list = new List<object>() { 1, 2, 3};

            IBaseCollection baseCollection = new BaseList(4);

            Console.WriteLine("000");
            baseCollection.AddRange(list);

            //Boxing because 8 is a value type (obj)
            baseCollection.Add(8);
        }
    }
}