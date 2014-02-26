using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class Tier1Helm : Armor
	{
        public Tier1Helm(Point2D origin)
            : base("Tier1Helm", origin, 1, 3, 0)
		{
		}
	}
}
