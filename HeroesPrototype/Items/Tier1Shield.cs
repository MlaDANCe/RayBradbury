using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class Tier1Shield : Armor
	{
        public Tier1Shield(Point2D origin)
            : base("Tier1Shield", origin, 0, 4, 0)
		{
		}
	}
}
