using System;
using System.Linq;
using HeroesPrototype.Geometry;
using System.Drawing;

namespace HeroesPrototype
{
	public class Pikeman : UnitLevel1
	{
        private const int attack = 6;
        private const int defence = 5;
        private const int health = 10;
        private const int price = 75;

        private readonly Bitmap sprite;

        public Pikeman(Point2D origin)
            : base("Pikeman", origin, attack, defence, health, price)
		{
		}

        public Pikeman(Point2D origin, Bitmap sprite)
            : base("Pikeman", origin, attack, defence, health, price)
        {
            this.Origin = origin;
            this.sprite = sprite;
        }
	}
}
