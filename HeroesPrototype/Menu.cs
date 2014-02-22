using System.Drawing;
using HeroesPrototype.Geometry;

namespace HeroesPrototype
{
	public class Menu
	{
		public P2d Origin { get; set; }

		public S2d Size { get; set; }

		public Menu(P2d origin, S2d size)
		{
			this.Origin = origin;
			this.Size = size;
		}

		public virtual System.Drawing.Bitmap GetMenu()
		{
			Bitmap menu = new Bitmap(this.Size.W, this.Size.H);
			Graphics graphics = Graphics.FromImage(menu);
			Pen pen = new Pen(Color.Black, 2.0f);

			int maxX = this.Size.W / MainScene.ScreenToMapUnits;
			int maxY = this.Size.H / MainScene.ScreenToMapUnits;

			for (int i = 0; i < maxY; i++)
			{
				for (int j = 0; j < maxX; j++)
				{
					int cx = j * MainScene.ScreenToMapUnits;
					int cy = i * MainScene.ScreenToMapUnits;
					graphics.DrawImage(MenuObjects.MenuObjects.Background, cx, cy);
				}
			}
			graphics.DrawLine(pen, new Point(1, 1), new Point(menu.Width - 1, 1));
			graphics.DrawLine(pen, new Point(1, menu.Height - 1), new Point(menu.Width - 1, menu.Height - 1));
			graphics.DrawLine(pen, new Point(1, 1), new Point(1, menu.Height - 1));
			graphics.DrawLine(pen, new Point(menu.Width - 1, 1), new Point(menu.Width - 1, menu.Height - 1));

			return menu;
		}
	}
}