using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Units
{
	public class Angel : UnitLevel3
	{
		public Angel(P2d origin) : base("Angel", origin, 10, 10, 10)
		{
		}
	}
}