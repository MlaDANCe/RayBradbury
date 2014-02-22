using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class Staff : Weapon
	{
		public Staff(P2d origin) : base("staff", origin, 4, 10, 2)
		{
		}
	}
}