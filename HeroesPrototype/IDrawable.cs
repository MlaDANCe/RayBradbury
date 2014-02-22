using System.Drawing;
using HeroesPrototype.Geometry;

namespace HeroesPrototype
{
	// This interface ensures that every object that will be drawn on the screen will have position, dimesion and image
	public interface IDrawable
	{
		P2d Origin { get; set; }

		S2d Size { get; }

		Bitmap GetSprite();
	}
}
