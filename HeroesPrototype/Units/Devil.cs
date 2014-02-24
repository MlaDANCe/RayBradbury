using System;
using System.Linq;
using HeroesPrototype.Geometry;
using System.Drawing;

namespace HeroesPrototype
{
	public class Devil : UnitLevel3, IDrawable
	{
        private readonly Bitmap sprite;
		public Devil(Point2D origin) : base("Devil", origin, 10, 10, 10)
		{
		}

        public Devil(Point2D origin, Bitmap sprite)
            : base("Devil", origin, 10, 10, 10)
        {
            this.Origin = origin;
            this.sprite = sprite;
        }
	}
}