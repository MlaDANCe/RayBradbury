using System;
using System.Linq;
using HeroesPrototype.Geometry;
using System.Drawing;

namespace HeroesPrototype
{
	public class Imp : UnitLevel1
	{
        private readonly Bitmap sprite;

		public Imp(Point2D origin) : base("Imp", origin, 10, 10, 10)
		{
		}

        public Imp(Point2D origin, Bitmap sprite)
            : base("Imp", origin, 10, 10, 10)
        {
            this.Origin = origin;
            this.sprite = sprite;
        }
	}
}