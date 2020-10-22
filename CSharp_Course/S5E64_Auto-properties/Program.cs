using System;

namespace S5E64_Autoproperties
{
    public class Character
    {
        public int Health { get; private set; } = 100;
        public void Hit(int damage)
        {
            Health -= damage;
            //Or via property:
            //Health -= damage;
        }
    }
}