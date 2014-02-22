using System;
using System.Drawing;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.MapObjects
{
	public abstract class MapObjectBase : IDrawable
	{
		private readonly Bitmap sprite;

		public P2d Origin { get; set; }

		public S2d Size { get; private set; }

		public MapObjectBase(P2d origin, Bitmap sprite)
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