using System;

namespace S5E75_Value_And_Reference_Types
{
    //Structure => Value Type
    public struct PointVal
    {
        public int X;

        public int Y;


        public void LogValues()
        {
            Console.WriteLine($" X = {X} & Y = {Y};");
        }
    }

    //Class => Reference Type
    public class PointRef
    {
        public int X;

        public int Y;


        public void LogValues()
        {
            Console.WriteLine($" X = {X} & Y = {Y};");
        }
    }
}
