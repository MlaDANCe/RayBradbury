using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class Tier2Armor : Armor
	{
        public Tier2Armor(Point2D origin)
            : base("Tier2Armor", origin, 3, 12, 0)
		{
		}
	}
}
