using System;
using System.Linq;
using HeroesPrototype.Geometry;
using System.Drawing;

namespace HeroesPrototype
{
	public class Marksman : UnitLevel2
	{
        private readonly Bitmap sprite;

        private const int attack = 8;
        private const int defence = 5;
        private const int health = 15;
        private const int price = 180;

        public Marksman(Point2D origin)
            : base("Marksman", origin, attack, defence, health, price)
		{
		}

        public Marksman(Point2D origin, Bitmap sprite)
            : base("Marksman", origin, attack, defence, health, price)
        {
            this.Origin = origin;
            this.sprite = sprite;
        }
	}
}