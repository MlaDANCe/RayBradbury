using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{ 
	public abstract class Weapon : Item
	{
		public int Attack { get; set; }

        public int Defense { get; set; }

        public int MovementPoints { get; set; }
		
		protected Weapon(string name, Point2D origin, int attack, int defense, int movementPoints) : base(name, origin)
		{
			this.Attack = attack;
            this.Defense = defense;
            this.MovementPoints = movementPoints;
		}
	}
}