using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class HeavyArmor : Armor
	{
		public HeavyArmor(Point2D origin) : base("HeavyArmor", origin, 4, 4, 0)
		{
		}
	}
}
