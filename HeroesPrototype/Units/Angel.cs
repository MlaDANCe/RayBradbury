using HeroesPrototype.geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.Units
{
    public class Angel : UnitLevel3
    {
        public Angel(P2d p, string name, int attack, int defence, int health)
            : base("Angel", 10, 10, 10)
        {
            this.P = p;
        }
    }
}