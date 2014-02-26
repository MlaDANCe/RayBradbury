using System;
using System.Linq;
using HeroesPrototype.Geometry;
using System.Drawing;

namespace HeroesPrototype
{
	public class Magog : UnitLevel2
	{
        private readonly Bitmap sprite;

        private const int attack = 9;
        private const int defence = 6;
        private const int health = 15;
        private const int price = 180;

        public Magog(Point2D origin)
            : base("Magog", origin, attack, defence, health, price)
		{
		}

        public Magog(Point2D origin, Bitmap sprite)
            : base("Magog", origin, attack, defence, health, price)
        {
            this.Origin = origin;
            this.sprite = sprite;
        }
	}
}