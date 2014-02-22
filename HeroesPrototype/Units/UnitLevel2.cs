using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Units
{
	public abstract class UnitLevel2 : Unit
	{
		public UnitLevel2(string name, P2d origin, int attack, int defence, int health) : base(name, origin, attack, defence, health)
		{
		}
	}
}