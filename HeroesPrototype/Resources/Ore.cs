using System;
using System.Linq;
using HeroesPrototype.Geometry;
using HeroesPrototype.Items;
using System.Collections.Generic;
using System.Drawing;

namespace HeroesPrototype
{
    internal class Ore:Item, IDrawable
	{
        private readonly List<int> orePileValue = new List<int> { 5, 6, 7, 8, 9, 10 };
        private static Random randomOrePileValue = new Random();
        private readonly Bitmap sprite;

        public Point2D Origin { get; set; }

        public Size2D Size { get; private set; }

        public Ore(Point2D origin, Bitmap sprite)
            : base("ore", origin)
        {
            base.Quantity = orePileValue[randomOrePileValue.Next(orePileValue.Count)];
            this.Origin = origin;
            this.sprite = sprite;
        }

        public Bitmap GetSprite()
        {
            return this.sprite;
        }

		public Ore(Point2D origin) : base("ore", origin)
		{
            base.Quantity = orePileValue[randomOrePileValue.Next(orePileValue.Count)];
		}
	}
}
