using HeroesPrototype.geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.Items
{
    class Sword:Weapon
    {
       public Sword(P2d p) : base(5,8,3,"sword")
        {
            this.P = p;
        }
    }
}
