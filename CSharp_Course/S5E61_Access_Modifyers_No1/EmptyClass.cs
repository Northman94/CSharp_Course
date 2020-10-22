using System;

namespace SecondNamespace2
{
    public class Character
    {
        private int health = 100;

        public int Health
        {
            get
            {
                return health;
            }
            private set
            {
                //So class Character could work with it
                health = value;
            }
        }

        public void Hit(int damage)
        {
            health -= damage;
            //Or via property:
            //Health -= damage;
        }
    }
}
