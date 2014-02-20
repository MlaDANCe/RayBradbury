using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Units
{
	public abstract class UnitLevel3 : Unit
	{
		public UnitLevel3(string name, Point2D origin, int attack, int defence, int health) : base(name, origin, attack, defence, health)
		{
		}
	}
}