using HeroesPrototype.geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.Items
{
    class Staff:Weapon
    {
        public Staff(P2d p) : base(4,10,2,"staff")
        {
            this.P = p;
        }
    }
}
