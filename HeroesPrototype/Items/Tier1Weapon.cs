using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class Tier1Weapon : Weapon
	{
        public Tier1Weapon(Point2D origin)
            : base("Tier1Weapon", origin, 5, 0, 0)
		{
		}
	}
}
