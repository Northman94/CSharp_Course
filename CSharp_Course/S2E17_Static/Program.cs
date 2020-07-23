using System;

namespace S2E17_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "abracadabra"; // string type instance (экземпяр типа string/экземпляр строки)
            // string name1 = new string("abracadabra"); // same

            bool containsA = name.Contains('a');
            bool containsE = name.Contains('e');
            
            Console.WriteLine(containsA);  // True.   Console type is static = no class instance
            Console.WriteLine(containsE); // False.   Тип Console статический = не создавать экз. класса


            string abc = string.Concat("a", "b", "c"); // Concatination = склеивание
            // Метод Concat вызывается на самом типе string. Возвращает abc =экземпляр типа string

            Console.WriteLine(int.MinValue); // MinValue свойство и статический член, не метод.
            // Статический член вызывается на прямую на типе.

            // int to string:
            int x = 1;
            string xStr = x.ToString(); // ToString = экземплярный метод
            // No ariphmetic operations with string
        }
    }
}
