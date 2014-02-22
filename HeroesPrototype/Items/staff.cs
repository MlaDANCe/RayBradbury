using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class Staff : Weapon
	{
		public Staff(Point2D origin) : base("Staff", origin, 4, 10, 2)
		{
		}
	}
}