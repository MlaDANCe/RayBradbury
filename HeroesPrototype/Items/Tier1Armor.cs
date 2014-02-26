using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
    public class Tier1Armor : Armor
    {
        public Tier1Armor(Point2D origin)
            : base("Tier1Armor", origin, 1, 6, 0)
        {
        }
    }
}
