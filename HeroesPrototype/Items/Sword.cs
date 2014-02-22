using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class Sword : Weapon
	{
		public Sword(Point2D origin) : base("Sword", origin, 5, 8, 3)
		{
		}
	}
}
