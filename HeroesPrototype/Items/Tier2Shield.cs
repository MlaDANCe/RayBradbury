using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class Tier2Shield : Weapon
	{
        public Tier2Shield(Point2D origin)
            : base("Tier2Shield", origin, 2, 10, 0)
		{
		}
	}
}