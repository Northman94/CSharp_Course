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

        /*
        //True face of a Property:
        public int GetHealth()
        {
            return health;
        }
        private void SetHealth(int value)
        {
            health = value;
        }

        //Fot this methods - we'll rewrite Hit:

        public void Hit(int damage)
        {
            var health = GetHealth() - damage;

            SetHealth(health);
        }
        */
    }
}

