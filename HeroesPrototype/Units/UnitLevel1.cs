using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Units
{
	public abstract class UnitLevel1 : Unit
	{
		public UnitLevel1(string name, P2d origin, int attack, int defence, int health) : base(name, origin, attack, defence, health)
		{
		}
	}
}