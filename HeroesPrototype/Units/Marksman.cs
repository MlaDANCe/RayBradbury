using HeroesPrototype.geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.Units
{
    public class Marksman : UnitLevel2
    {
        public Marksman(P2d p, string name, int attack, int defence, int health)
            : base("Marksman", 10, 10, 10)
        {
            this.P = p;
        }
    }
}