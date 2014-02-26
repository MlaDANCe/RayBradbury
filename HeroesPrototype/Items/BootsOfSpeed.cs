using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
    public class BootsOfSpeed : Weapon
    {
        public BootsOfSpeed(Point2D origin)
            : base("BootsOfSpeed", origin, 1, 1, 5)
        {
        }
    }
}
