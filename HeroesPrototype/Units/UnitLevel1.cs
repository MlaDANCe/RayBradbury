using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype
{
	public abstract class UnitLevel1 : Unit
	{
		public UnitLevel1(string name, Point2D origin, int attack, int defence, int health) : base(name, origin, attack, defence, health)
		{
		}
	}
}