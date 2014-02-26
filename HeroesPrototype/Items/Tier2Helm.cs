using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
    public class Tier2Helm : Armor
    {
        public Tier2Helm(Point2D origin)
            : base("Tier2Helm", origin, 3, 8, 0)
        {
        }
    }
}
