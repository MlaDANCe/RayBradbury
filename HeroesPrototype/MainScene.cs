using System;
using System.Drawing;
using System.Windows.Forms;
using HeroesPrototype.CharacterAssets;
using HeroesPrototype.Geometry;

namespace HeroesPrototype
{
	/// <summary>
	/// This class wraps the functionality provided by
	/// background worker and have instance of panel
	/// graphics ( passed in the constructor )
	/// </summary>
	public class MainScene
	{
		public const int ScreenToMapUnits = 50;

		private readonly Graphics scene;

		private readonly S2d sceneDimension;

		private readonly Level currentLevel;
		private readonly MainCharacter mainCharacter;

		private readonly Bitmap buff;
		private readonly Graphics buffG;

		public MainScene(Graphics panelGraphics, S2d sceneSize)
		{
			this.scene = panelGraphics;

			this.sceneDimension = sceneSize;

			this.currentLevel = new Level(this.sceneDimension);

			this.mainCharacter = new MainCharacter(new P2d(this.currentLevel.MapSize.W / 2, this.currentLevel.MapSize.W / 2),
				new P2d(this.sceneDimension.W / 2, this.sceneDimension.H / 2));

			this.buff = new Bitmap(this.sceneDimension.W, this.sceneDimension.H);
			this.buffG = Graphics.FromImage(this.buff);
		}

		internal void Draw()
		{
			this.scene.DrawImage(this.buff, new Point(0, 0)); // Here we draw the buffer on the screen
		}

		internal void GameLoop()
		{
			this.buffG.DrawImage(this.currentLevel.GetSprite(), this.currentLevel.Origin.X, this.currentLevel.Origin.Y); // Here we draw the map on the buffer
			this.buffG.DrawImage(this.mainCharacter.GetSprite(), this.mainCharacter.ScreenCoordinates.X, this.mainCharacter.ScreenCoordinates.Y); // Here we draw the character on the buffer
		}

		internal void MouseAction(int x, int y, MouseButtons mouseButtons)
		{
		}

		internal void KeyboardAction(Keys keys)
		{
			P2d dxdy = new P2d(0, 0);
			if (keys == Keys.Up)
			{
				dxdy.Y -= 1;
			}
			else if (keys == Keys.Down)
			{
				dxdy.Y += 1;
			}
			else if (keys == Keys.Left)
			{
				dxdy.X -= 1;
			}
			else if (keys == Keys.Right)
			{
				dxdy.X += 1;
			}
			this.MovePosition(dxdy);
		}

		private void MovePosition(P2d dxdy)
		{
			P2d newPlPos = this.mainCharacter.WorldPosition + dxdy;
			if (newPlPos.X >= 0 && newPlPos.X < this.currentLevel.MapSize.W &&
				newPlPos.Y >= 0 && newPlPos.Y < this.currentLevel.MapSize.H)
			{
				Rectangle2D newVis = this.currentLevel.VisibleSpace + dxdy;
				if (newVis.Left >= 0 && 
					newVis.Right <= this.currentLevel.MapSize.W &&
					newVis.Top >= 0 && 
					newVis.Bottom < this.currentLevel.MapSize.H && 
					!this.currentLevel.IsPositionOccupied(newPlPos))
				{
					this.mainCharacter.MoveTo(newPlPos);
					this.currentLevel.VisibleSpace = newVis;
					this.currentLevel.SetNotUpToDate();
				}
			}
		}
	}
}
