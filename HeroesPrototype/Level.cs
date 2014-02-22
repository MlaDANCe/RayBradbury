using System;
using System.Drawing;
using HeroesPrototype.Geometry;
using HeroesPrototype.MapObjects;

namespace HeroesPrototype
{
	/// <summary>
	/// In this class we start to work with map units
	/// lets assume that one map unit equals 50x50px screen units
	/// </summary>
	public class Level : IDrawable
	{
		private readonly IDrawable[,] map;

		private readonly Point2D currentContainable;

		private readonly Bitmap scene;
		private readonly Graphics graphics;

		private bool isUpToDate;// I add this check because if the map is up to date the scene have not to be redrawn it safes 50% processing time 

		public Point2D Origin { get; set; }

		public Size2D Size { get; private set; }

		public Rectangle2D VisibleSpace { get; set; }

		public Size2D MapSize { get; private set; }

		public Level(Size2D sceneSize)
		{
			this.Origin = new Point2D(0, 0);
			this.Size = sceneSize;
			this.map = LevelLoader.Load(@"..\..\sprites\mapobj\map.bmp");

			this.MapSize = new Size2D(this.map.GetLength(1), this.map.GetLength(0));

			int c_x_t = this.map.GetLength(1) / 2;
			int c_y_t = this.map.GetLength(0) / 2;

			int left = c_x_t - (this.Size.Width / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units
			int right = c_x_t + (this.Size.Width / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units
			int top = c_y_t - (this.Size.Height / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units
			int bottom = c_y_t + (this.Size.Height / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units

            this.VisibleSpace = new Rectangle2D(new Point2D(left, top), new Size2D(right - left, bottom - top));

			this.scene = new Bitmap(this.Size.Width, this.Size.Height);
			this.graphics = Graphics.FromImage(this.scene);

			this.isUpToDate = false;
		}

		public Bitmap GetSprite()
		{
			if (!this.isUpToDate)
			{
				this.RenderScene();
			}
			return this.scene;
		}

		public bool IsPositionOccupied(Point2D pos)
		{
			var tile = this.map[pos.Y, pos.X];
			return !(tile == null || tile is TerrainCastle || tile is TerrainInferno);
		}

		public void SetNotUpToDate()
		{
			this.isUpToDate = false;
		}

		private void RenderScene()
		{
			TerrainInferno tInferno = new TerrainInferno(new Point2D(0, 0));
			for (int i = this.VisibleSpace.Left; i < this.VisibleSpace.Right; i++)
			{
				for (int j = this.VisibleSpace.Top; j < this.VisibleSpace.Bottom; j++)
				{
					int x = (i - this.VisibleSpace.Left) * MainScene.ScreenToMapUnits;
					int y = (j - this.VisibleSpace.Top) * MainScene.ScreenToMapUnits;

					this.graphics.DrawImage(tInferno.GetSprite(), x, y);

					if (this.map[j, i] != null)
					{
						this.graphics.DrawImage(this.map[j, i].GetSprite(), new Point(x, y));
					}
				}
			}
			this.isUpToDate = true;
		}
	}
}
