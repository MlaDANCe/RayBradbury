using HeroesPrototype.Geometry;
using HeroesPrototype.Items;

namespace HeroesPrototype
{
    using System;
    using System.Drawing;

    internal class CampFire : Item, IDrawable
    {
        private const int goldValue = 500;
        private const int resourceValue = 5;
        private static Random woodOrOre = new Random();
        private readonly Bitmap sprite;

        public Point2D Origin { get; set; }

        public Size2D Size { get; private set; }

        public CampFire(Point2D origin, Bitmap sprite)
            : base("CampFire", origin)
        {
            int resourceType = woodOrOre.Next(100);
            base.GoldQuantity = goldValue;
            if (resourceType % 2 == 0)
            {
                base.WoodQuantity = resourceValue;
            }
            else
            {
                base.OreQuantity = resourceValue;
            }

            this.Origin = origin;
            this.sprite = sprite;
        }

        public Bitmap GetSprite()
        {
            return this.sprite;
        }

        //public CampFire(Point2D origin)
        //    : base("CampFire", origin)
        //{
        //    int resourceType = woodOrOre.Next(100);
        //    base.GoldQuantity = goldValue;
        //    if (resourceType % 2 == 0)
        //    {
        //        base.WoodQuantity = resourceValue;
        //    }
        //    else
        //    {
        //        base.OreQuantity = resourceValue;
        //    }
        //}
    }
}