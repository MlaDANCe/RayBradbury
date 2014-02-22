using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Units
{
	public class Magog : UnitLevel2
	{
		public Magog(Point2D origin) : base("Magog", origin, 10, 10, 10)
		{
		}
	}
}