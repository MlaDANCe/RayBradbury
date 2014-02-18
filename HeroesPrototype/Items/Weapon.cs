using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.Items
{ 
    abstract class Weapon:Item
    {
        public int Damage { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }

        protected Weapon(int attack, int damage, int speed, string name):base(name)
        {
            Attack = attack;
            Damage = damage;
            Speed = speed;
        }
    }
}
