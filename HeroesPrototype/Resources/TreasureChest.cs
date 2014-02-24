using System;
using System.Linq;
using HeroesPrototype.Geometry;
using HeroesPrototype.Items;
using System.Collections.Generic;
using System.Drawing;

namespace HeroesPrototype
{
    internal class TreasureChest : Item, IDrawable
    {
        private readonly List<int> goldValue = new List<int> { 1000, 1500, 2000 };
        private readonly List<int> experienceValue = new List<int> { 500, 1000, 1500 };
        private static Random randomValue = new Random();
        private readonly Bitmap sprite;

        public Point2D Origin { get; set; }

        public Size2D Size { get; private set; }

        public TreasureChest(Point2D origin, Bitmap sprite)
            : base("TreasureChest", origin)
        {
            base.GoldQuantity = goldValue[randomValue.Next(goldValue.Count)];
            base.ExperienceQuantity = experienceValue[randomValue.Next(experienceValue.Count)];
            this.Origin = origin;
            this.sprite = sprite;
        }

        public Bitmap GetSprite()
        {
            return this.sprite;
        }

        public TreasureChest(Point2D origin)
            : base("TreasureChest", origin)
        {
            base.GoldQuantity = goldValue[randomValue.Next(goldValue.Count)];
            base.ExperienceQuantity = experienceValue[randomValue.Next(experienceValue.Count)];
        }
    }
}
