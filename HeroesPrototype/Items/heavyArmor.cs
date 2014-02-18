using HeroesPrototype.geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.Items
{
    class heavyArmor:Armor
    {
        public heavyArmor(P2d p) : base("heavyArmour", 5)
        {
            P = p;
        }
    }
}
