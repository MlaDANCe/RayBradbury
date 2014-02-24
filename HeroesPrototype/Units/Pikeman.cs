using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype
{
	public class Pikeman : UnitLevel1
	{
		public Pikeman(Point2D origin) : base("Pikeman", origin, 10, 10, 10)
		{
		}
	}
}
