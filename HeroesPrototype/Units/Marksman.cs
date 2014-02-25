using System;
using System.Linq;
using HeroesPrototype.Geometry;
using System.Drawing;

namespace HeroesPrototype
{
	public class Marksman : UnitLevel2
	{
        private readonly Bitmap sprite;

        public Marksman(Point2D origin)
            : base("Marksman", origin, 8, 5, 15, 180)
		{
		}

        public Marksman(Point2D origin, Bitmap sprite)
            : base("Marksman", origin, 8, 5, 15, 180)
        {
            this.Origin = origin;
            this.sprite = sprite;
        }
	}
}