using System;
using System.Linq;
using HeroesPrototype.Geometry;
using System.Drawing;

namespace HeroesPrototype
{
	public class Devil : UnitLevel3
	{
        private readonly Bitmap sprite;

        private const int attack = 13;
        private const int defence = 11;
        private const int health = 40;
        private const int price = 300;

		public Devil(Point2D origin) 
            : base("Devil", origin, attack, defence, health, price)
		{
		}

        public Devil(Point2D origin, Bitmap sprite)
            : base("Devil", origin, attack, defence, health, price)
        {
            this.Origin = origin;
            this.sprite = sprite;
        }
	}
}