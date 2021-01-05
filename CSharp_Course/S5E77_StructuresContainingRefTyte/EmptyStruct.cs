using System;

namespace S5E77_StructuresContainingRefTyte
{
    public struct EvilStruct
    {
        public int X;
        public int Y;

        //Refference behaviour:
        public PointRef PointRef;
    }

    public struct PointVal
    {
        public int X;
        public int Y;

        public void LogValues ()
        {
            Console.WriteLine($"X = {X}; Y = {Y};");
        }
    }

    public class PointRef
    {
        public int X;
        public int Y;

        public void LogValues()
        {
            Console.WriteLine($"X = {X}; Y = {Y};");
        }
    }
}
