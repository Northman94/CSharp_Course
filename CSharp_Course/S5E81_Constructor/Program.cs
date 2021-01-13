using System;

namespace S5E81_Constructor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Character chara = new Character("Elf");

            Console.WriteLine(chara.Race);
        }
    }

    public class Character
    {
        private static int speed = 10;

        public int Health { get; set; } = 100; //

        public string Race { get; private set; }

        public int Armour { get; private set; }


        public Character(string race) //Constructor (ctor)
        {
            Race = race;
            Armour = 30; //to set by default
        }

        public Character(string _race, int _armour) //Constructor (ctor)
        {
            Race = _race;
            Armour = _armour;
        }

        public void Hit(int damage)
        {
            if(damage > Health)
            {
                damage = Health;

                Health -= damage;
            }
        }
    }
}

