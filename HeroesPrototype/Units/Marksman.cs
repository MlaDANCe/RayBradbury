using System;
using System.Linq;
using HeroesPrototype.Geometry;
using System.Drawing;

namespace HeroesPrototype
{
	public class Marksman : UnitLevel2
	{
        private readonly Bitmap sprite;

		public Marksman(Point2D origin) : base("Marksman", origin, 10, 10, 10)
		{
		}

        public Marksman(Point2D origin, Bitmap sprite)
            : base("Marksman", origin, 10, 10, 10)
        {
            this.Origin = origin;
            this.sprite = sprite;
        }
	}
}