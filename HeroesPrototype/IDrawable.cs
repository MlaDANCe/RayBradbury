using System.Drawing;
using HeroesPrototype.Geometry;

namespace HeroesPrototype
{
	// This interface ensures that every object that will be drawn on the screen will have position, dimesion and image
	public interface IDrawable
	{
		Point2D Origin { get; set; }

		Size2D Size { get; }

		Bitmap GetSprite();
	}
}
