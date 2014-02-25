using System;
using System.Linq;
using HeroesPrototype.Geometry;
using System.Drawing;

namespace HeroesPrototype
{
	public class Magog : UnitLevel2
	{
        private readonly Bitmap sprite;
	
        public Magog(Point2D origin) : base("Magog", origin, 9, 6, 15, 180)
		{
		}

        public Magog(Point2D origin, Bitmap sprite)
            : base("Magog", origin, 9, 6, 15, 180)
        {
            this.Origin = origin;
            this.sprite = sprite;
        }
	}
}