using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public abstract class Armor : Item
	{
        public int Attack { get; set; }

		public int Defense { get; set; }

        public int BonusUnitsHealth { get; set; }

        public Armor(string name, Point2D origin, int attack, int defense, int bonusUnitsHealth): base(name, origin)
		{
            this.Attack = attack;
			this.Defense = defense;
            this.BonusUnitsHealth = bonusUnitsHealth;
		}
	}
}