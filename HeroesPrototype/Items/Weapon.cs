using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{ 
	public abstract class Weapon : Item
	{
		public int Damage { get; set; }

		public int Attack { get; set; }

		public int Speed { get; set; }

		protected Weapon(string name, P2d origin, int attack, int damage, int speed) : base(name, origin)
		{
			this.Attack = attack;
			this.Damage = damage;
			this.Speed = speed;
		}
	}
}