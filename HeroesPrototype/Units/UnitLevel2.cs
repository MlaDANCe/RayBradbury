using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype
{
	public abstract class UnitLevel2 : Unit
	{
		public UnitLevel2(string name, Point2D origin, int attack, int defence, int health, int price) : base(name, origin, attack, defence, health, price)
		{
		}
	}
}