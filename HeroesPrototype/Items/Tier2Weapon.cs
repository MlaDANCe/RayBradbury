using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class Tier2Weapon : Weapon
	{
        public Tier2Weapon(Point2D origin)
            : base("Tier2Weapon", origin, 12, 3, 0)
		{
		}
	}
}
