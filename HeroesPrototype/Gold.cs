using System;
using System.Linq;
using HeroesPrototype.Geometry;
using HeroesPrototype.Items;
using System.Collections.Generic;
using System.Drawing;
namespace HeroesPrototype
{
    internal class Gold : Item, IDrawable
	{
        private readonly List<int> goldPileValue = new List<int> { 500, 600, 700, 800, 900, 1000 };

        private readonly Bitmap sprite;

        public Point2D Origin { get; set; }

        public Size2D Size { get; private set; }

        public Gold(Point2D origin, Bitmap sprite)
            : base("gold", origin)
        {
            base.Quantity = goldPileValue[Rnd.Next(0, 5)];
            this.Origin = origin;
            this.sprite = sprite;
        }

        public Bitmap GetSprite()
        {
            return this.sprite;
        }

		public Gold(Point2D origin) : base("gold", origin)
		{
            base.Quantity = goldPileValue[Rnd.Next(0, 5)];
		}
	}
}
