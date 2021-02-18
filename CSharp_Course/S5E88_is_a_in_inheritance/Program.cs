using System;

namespace S5E88_is_a_in_inheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            // Example of BAD code (no use)
            // Obj initializer syntax allow to miss "()" 
            Rect rect = new Rect { Height = 2, Width = 5 };

            int rectArea = AreaCalculator.CalcSquare(rect);

            Console.WriteLine($"Rect area = {rectArea}");


            // Объявление переменной базового класса и
            // проинициализровать экземпляром наследника.
            // The problem of representatives (проблема представителей)
            // Квадрат не дочерняя сущность от прямоугольника.
            // Это Ошибка проектирования vvv . Решается через Interface. 

            Rect square = new Square( Height = 2, Width = 10 );
            */
            //-- -- -- -- -- -- -- -- -- -- --
            IShape rect1 = new Rect() { Height = 2, Width = 10 };

            IShape square1 = new Square() { SideLength = 10 };

            Console.WriteLine($"Rect area = {rect1.CalcSquare()}");
            Console.WriteLine($"Square area = {square1.CalcSquare()}");
        }
    }
}
