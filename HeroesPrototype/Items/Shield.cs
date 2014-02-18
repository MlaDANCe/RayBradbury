using HeroesPrototype.geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.Items
{
    class Shield:Armor
    {
           public Shield(P2d p) : base("shield", 4)
        {
            P = p;
        }
    }
}
