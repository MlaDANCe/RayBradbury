using System;
using System.Linq;

namespace HeroesPrototype.Geometry
{
	public struct Rectangle2D
	{
		public int Left { get; set; }

		public int Right { get; set; }

		public int Top { get; set; }

		public int Bottom { get; set; }

		public Rectangle2D(P2d topLeft, S2d widthHeight) : this()
		{
			this.Left = topLeft.X;
			this.Right = topLeft.X + widthHeight.W;
			this.Top = topLeft.Y;
			this.Bottom = topLeft.Y + widthHeight.H;
		}


		public static Rectangle2D operator+(Rectangle2D rectangle, P2d point)
		{
			return new Rectangle2D
			{
				Left = rectangle.Left + point.X,
				Right = rectangle.Right + point.X,
				Top = rectangle.Top + point.Y,
				Bottom = rectangle.Bottom + point.Y,
			};
		}

		public static Rectangle2D operator-(Rectangle2D a, P2d p)
		{
			return new Rectangle2D
			{
				Left = a.Left - p.X,
				Right = a.Right - p.X,
				Top = a.Top - p.Y,
				Bottom = a.Bottom - p.Y,
			};
		}
	}
}