using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
    public class VialOfBlood : Armor
    {
        public VialOfBlood(Point2D origin)
            : base("VialOfBlood", origin, 0, 2, 5)
        {
        }
    }
}