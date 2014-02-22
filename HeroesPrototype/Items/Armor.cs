using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public abstract class Armor : Item
	{
		public int Defense { get; set; }

		public Armor(string name, P2d origin, int defense) : base(name, origin)
		{
			this.Defense = defense;
		}
	}
}