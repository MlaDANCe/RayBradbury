using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class Shield : Armor
	{
		public Shield(Point2D origin) : base("Shield", origin, 4)
		{
		}
	}
}
