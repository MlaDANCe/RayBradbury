using System;
using System.Linq;
using HeroesPrototype.Geometry;
using HeroesPrototype.Items;
using System.Collections.Generic;
using System.Drawing;

namespace HeroesPrototype
{
    internal class Wood :Item, IDrawable
	{
        private readonly List<int> woodPileValue = new List<int> { 5, 6, 7, 8, 9, 10 };
        private static Random randomWoodPileValue = new Random();
        private readonly Bitmap sprite;

        public Point2D Origin { get; set; }

        public Size2D Size { get; private set; }

        public Wood(Point2D origin, Bitmap sprite)
            : base("wood", origin)
        {
            base.Quantity = woodPileValue[randomWoodPileValue.Next(woodPileValue.Count)];
            this.Origin = origin;
            this.sprite = sprite;
        }

        public Bitmap GetSprite()
        {
            return this.sprite;
        }

		public Wood(Point2D origin) : base("wood", origin)
		{
            base.Quantity = woodPileValue[randomWoodPileValue.Next(woodPileValue.Count)];
		}
	}
}
