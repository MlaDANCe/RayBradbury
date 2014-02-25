using System.Drawing;
using HeroesPrototype.Geometry;

namespace HeroesPrototype
{
	public class Menu
	{
		public Point2D Origin { get; set; }

		public Size2D Size { get; set; }

		public Menu(Point2D origin, Size2D size)
		{
			this.Origin = origin;
			this.Size = size;
		}

		public virtual System.Drawing.Bitmap GetMenu()
		{
			Bitmap menu = new Bitmap(this.Size.Width, this.Size.Height);
			Graphics graphics = Graphics.FromImage(menu);
			Pen pen = new Pen(Color.Black, 2.0f);

			int maxX = this.Size.Width / MainScene.ScreenToMapUnits;
			int maxY = this.Size.Height / MainScene.ScreenToMapUnits;

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
			graphics.DrawLine(pen, new Point(1, menu.Height -1), new Point(menu.Width - 1, menu.Height - 1));
			graphics.DrawLine(pen, new Point(1, 1), new Point(1, menu.Height - 1));
			graphics.DrawLine(pen, new Point(menu.Width - 1, 1), new Point(menu.Width - 1, menu.Height - 1));

			return menu;
		}
	}
}