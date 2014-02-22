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

		private readonly P2d currentContainable;

		private readonly Bitmap scene;
		private readonly Graphics graphics;

		private bool isUpToDate;// I add this check because if the map is up to date the scene have not to be redrawn it safes 50% processing time 

		public P2d Origin { get; set; }

		public S2d Size { get; private set; }

		public Rectangle2D VisibleSpace { get; set; }

		public S2d MapSize { get; private set; }

		public Level(S2d sceneSize)
		{
			this.Origin = new P2d(0, 0);
			this.Size = sceneSize;
			this.map = LevelLoader.Load(@"..\..\sprites\mapobj\map.bmp");

			this.MapSize = new S2d(this.map.GetLength(1), this.map.GetLength(0));

			int c_x_t = this.map.GetLength(1) / 2;
			int c_y_t = this.map.GetLength(0) / 2;

			int left = c_x_t - (this.Size.W / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units
			int right = c_x_t + (this.Size.W / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units
			int top = c_y_t - (this.Size.H / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units
			int bottom = c_y_t + (this.Size.H / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units

            this.VisibleSpace = new Rectangle2D(new P2d(left, top), new S2d(right - left, bottom - top));

			this.scene = new Bitmap(this.Size.W, this.Size.H);
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

		public bool IsPositionOccupied(P2d pos)
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
			TerrainInferno tInferno = new TerrainInferno(new P2d(0, 0));
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
