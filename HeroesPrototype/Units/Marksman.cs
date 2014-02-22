using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Units
{
	public class Marksman : UnitLevel2
	{
		public Marksman(Point2D origin) : base("Marksman", origin, 10, 10, 10)
		{
		}
	}
}