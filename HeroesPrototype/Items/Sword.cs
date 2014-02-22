using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class Sword : Weapon
	{
		public Sword(P2d origin) : base("sword", origin, 5, 8, 3)
		{
		}
	}
}
