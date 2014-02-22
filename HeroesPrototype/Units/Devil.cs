using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Units
{
	public class Devil : UnitLevel3
	{
		public Devil(Point2D origin) : base("Devil", origin, 10, 10, 10)
		{
		}
	}
}