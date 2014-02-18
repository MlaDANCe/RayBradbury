using HeroesPrototype.geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HeroesPrototype.Items
{
    class Axe:Weapon
    {
        public Axe(P2d p) : base(4,10,2,"axe")
        {
            this.P = p;
        }
    }
}
