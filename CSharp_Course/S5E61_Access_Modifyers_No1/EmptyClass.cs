using System;

namespace SecondNamespace2
{
    public class Character
    {
        private int health = 100;

        public void Hit(int damage)
        {
            health -= damage;
        }
    }
}
