using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.Items
{
    class Armor:Item
    {
        public int Defense { get; set; }

        public Armor(string name, int defense) : base(name)
        {
            Defense = defense;
        }
    }
}
