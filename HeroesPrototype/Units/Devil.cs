using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Units
{
	public class Devil : UnitLevel3
	{
		public Devil(P2d origin) : base("Devil", origin, 10, 10, 10)
		{
		}
	}
}