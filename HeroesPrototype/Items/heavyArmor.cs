using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class HeavyArmor : Armor
	{
		public HeavyArmor(Point2D origin) : base("heavyArmour", origin, 5)
		{
		}
	}
}
