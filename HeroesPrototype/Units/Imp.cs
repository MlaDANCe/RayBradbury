using System;
using System.Linq;
using HeroesPrototype.Geometry;
using System.Drawing;

namespace HeroesPrototype
{
	public class Imp : UnitLevel1
	{
        private readonly Bitmap sprite;

        private const int attack = 4;
        private const int defence = 4;
        private const int health = 4;
        private const int price = 50;

        public Imp(Point2D origin)
            : base("Imp", origin, attack, defence, health, price)
		{
		}

        public Imp(Point2D origin, Bitmap sprite)
            : base("Imp", origin, attack, defence, health, price)
        {
            this.Origin = origin;
            this.sprite = sprite;
        }
	}
}