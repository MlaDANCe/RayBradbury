using System;
using System.Linq;
using HeroesPrototype.Geometry;
using System.Drawing;

namespace HeroesPrototype
{
	public class Pikeman : UnitLevel1
	{
        private readonly Bitmap sprite;

		public Pikeman(Point2D origin) : base("Pikeman", origin, 10, 10, 10)
		{
		}

        public Pikeman(Point2D origin, Bitmap sprite)
            : base("Pikeman", origin, 10, 10, 10)
        {
            this.Origin = origin;
            this.sprite = sprite;
        }
	}
}
