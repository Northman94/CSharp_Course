using System;

namespace S5E89_Enum
{
    
    class MainClass
    {
        public static void Main(string[] args)
        {
            Character Legolas = new Character(Race.Elf);
        }


        public class Character
        {
            private readonly int speed = 10;

            public int Health { get; set; } = 100;

            public Race Race { get; private set; }

            public int Armor { get; private set; }


            public Character(Race race)
            {
                Race = race;
                // Явное приведение к int, ибо enum наследуется от int
                Armor = (int)race;
            }

            public Character(Race race, int armor)
            {
                Race = race;

                Armor = armor;
            }
        }
    }



    public Character(Race race)
    {
        Race = race;

        switch (race)
        {
            case Race.Elf:
                Armor = 25;
                break;
            case Race.Orc:
                Armor = 40;
                break;
            case Race.Human:
                Armor = 15;
                break;
            default:
                throw new ArgumentException("Unknown race.");
        }

        if (race == Race.Elf)
        {
            Armor = 25;
        }
        else if (race == Race.Orc)
        {
            Armor = 40;
        }
        else if (race == Race.Human)
        {
            Armor = 15;
        }
        else
        {
            throw new ArgumentException("Unknown race.");
        }
    }

}
