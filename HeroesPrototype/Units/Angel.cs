using System;
using System.Linq;
using HeroesPrototype.Geometry;
using System.Drawing;

namespace HeroesPrototype
{
	public class Angel : UnitLevel3
	{
        private readonly Bitmap sprite;

        private const int attack = 12;
        private const int defence = 12;
        private const int health = 40;
        private const int price = 300;
                    
        public Angel(Point2D origin)
            : base("Angel", origin, attack, defence, health, price)
		{
		}        

        public Angel(Point2D origin, Bitmap sprite)
            : base("Angel", origin, attack, defence, health, price)
        {
            this.Origin = origin;
            this.sprite = sprite;
        }
	}
}