using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Units
{
	public class Imp : UnitLevel1
	{
		public Imp(Point2D origin) : base("Imp", origin, 10, 10, 10)
		{
		}
	}
}