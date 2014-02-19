using HeroesPrototype.geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.Units
{
    public class Magog : UnitLevel2
    {
        public Magog(P2d p, string name, int attack, int defence, int health)
            : base("Magog", 10, 10, 10)
        {
            this.P = p;
        }
    }
}