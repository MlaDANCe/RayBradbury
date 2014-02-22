using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class Helm : Armor
	{
		public Helm(Point2D origin) : base("Helm", origin, 3)
		{
		}
	}
}
