using System;
using SecondNamespace2;

namespace FirstNamespace1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Character ch = new Character();

            ch.Hit(10);

            Console.WriteLine(ch.health);
        }
    }
}
