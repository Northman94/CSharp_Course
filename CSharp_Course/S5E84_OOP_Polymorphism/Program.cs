using System;

namespace S5E84_OOP_Polymorphism
{
    public abstract class Shape
    {
        public Shape() //Constructor
        {
            Console.WriteLine("Shape created");
        }


        public abstract void Draw();

        public abstract double Area();

        public abstract double Perimeter();
    }
    // -- -- -- -- -- -- -- -- -- -- -- --

    public class Rectangle : Shape
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)//: base()
        {
            this.width = width;
            this.height = height;
            Console.WriteLine("Rectangle created");
        }


        public override double Area()
        {
            return width * height;
        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle was drawn");
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }
    // -- -- -- -- -- -- -- -- -- -- -- -- --

    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ac;


        public Triangle(double ab, double bc, double ac)//: base()
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;
            Console.WriteLine("Triangle created");
        }

        public override double Area()
        {
            double hp = (ab + bc + ac) / 2;
            return Math.Sqrt (hp * (hp - ab) * (hp - bc) * (hp - ac));
        }

        public override void Draw()
        {
            Console.WriteLine("Triangle was drawn");
        }

        public override double Perimeter()
        {
            return ab + bc + ac;
        }
    }
}
