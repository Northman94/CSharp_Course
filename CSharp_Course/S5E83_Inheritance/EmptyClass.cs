using System;

namespace S5E83_OOP_Inheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Model_X_Terminal x_Terminal = new Model_X_Terminal("123");
            x_Terminal.Connect();

            Console.WriteLine();

            Model_S_Terminal s_Terminal = new Model_S_Terminal("789");
            s_Terminal.Connect();

            Console.ReadLine();
        }
    }
}
