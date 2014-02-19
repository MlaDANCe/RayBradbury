using HeroesPrototype.geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.Units
{
    public class Devil : UnitLevel3
    {
        public Devil(P2d p, string name, int attack, int defence, int health)
            : base("Devil", 10, 10, 10)
        {
            this.P = p;
        }
    }
}