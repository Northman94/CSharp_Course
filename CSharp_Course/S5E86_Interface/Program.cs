using System;

namespace S5E86_Interface
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IBaseCollection baseCollection = new BaseList(4);

            //Boxing because 8 is a value type (obj)
            baseCollection.Add(8); 

        }
    }
}
