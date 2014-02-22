using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Units
{
	public class Marksman : UnitLevel2
	{
		public Marksman(P2d origin) : base("Marksman", origin, 10, 10, 10)
		{
		}
	}
}