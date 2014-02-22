using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class Shield : Armor
	{
		public Shield(P2d origin) : base("shield", origin, 4)
		{
		}
	}
}
