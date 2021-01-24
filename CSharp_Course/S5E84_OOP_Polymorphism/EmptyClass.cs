using System;

namespace S5E84_OOP_Polymorphism
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // We can't create abstract Class Instance, but
            Shape[] shapes = new Shape[2];
            // Havу null in it. Shape class is a reference type
            // Array of Classes.
            shapes[0] = new Rectangle(5, 10);

            shapes[1] = new Triangle(10, 20, 30);
            //Working with ingerits through BASE class

            foreach (Shape i in shapes)
            {
                i.Draw();
                Console.WriteLine(i.Perimeter());
            }
        }
    }
}
