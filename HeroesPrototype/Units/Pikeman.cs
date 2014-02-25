using System;
using System.Linq;
using HeroesPrototype.Geometry;
using System.Drawing;

namespace HeroesPrototype
{
	public class Pikeman : UnitLevel1
	{
        private readonly Bitmap sprite;

		public Pikeman(Point2D origin) : base("Pikeman", origin, 6, 5, 10, 75)
		{
		}

        public Pikeman(Point2D origin, Bitmap sprite)
            : base("Pikeman", origin, 6, 5, 10, 75)
        {
            this.Origin = origin;
            this.sprite = sprite;
        }
	}
}
