using HeroesPrototype.geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.Items
{
    class Helm:Armor
    {
          public Helm(P2d p) : base("helm", 3)
        {
            P = p;
        }
    }
}
