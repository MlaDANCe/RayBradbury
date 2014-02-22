using System;
using System.Linq;
using HeroesPrototype.Geometry;
using HeroesPrototype.Items;

namespace HeroesPrototype
{
	internal class Gold : Item
	{
		public Gold(Point2D origin) : base("gold", origin)
		{
			base.Quantity = (new Random()).Next(1, 50);
		}
	}
}
