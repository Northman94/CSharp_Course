using System;

namespace S5E89_Enum
{
    public enum TrafficLight
    {
        Red,
        Yellow,
        Green
    }

    public enum Race // : int  or byte
    {
        Elf = 0,
        Orc = 1,
        Human = 2
    }

    public enum Surface
    {
        Water = 32,
        Sand = 15,
        Earth = 5
    }
}
