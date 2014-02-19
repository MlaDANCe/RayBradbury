using HeroesPrototype.geometry;
using HeroesPrototype.mapConsts;
using System;
using System.Collections.Generic;
using System.Drawing;
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
