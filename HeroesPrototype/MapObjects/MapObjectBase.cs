using System;
using System.Drawing;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.MapObjects
{
	public abstract class MapObjectBase : IDrawable
	{
		private readonly Bitmap sprite;

		public Point2D Origin { get; set; }

		public Size2D Size { get; private set; }

		public MapObjectBase(Point2D origin, Bitmap sprite)
		{
			this.Origin = origin;
			this.sprite = sprite;
		}

		public Bitmap GetSprite()
		{
			return this.sprite;
		}
	}
}