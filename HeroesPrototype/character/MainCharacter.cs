using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using HeroesPrototype.Items;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.CharacterAssets
{
	public class MainCharacter : CharacterBase
	{
		Bitmap currentSprite;
		private int currentCharacterStage;
		private Position position;

		public P2d WorldPosition { get; set; }

		public P2d ScreenCoordinates { get; set; }

		public override S2d Size
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public List<Item> Items { get; set; }

		public MainCharacter(P2d worldPosition, P2d screenCoordinates)
		{
			this.WorldPosition = worldPosition;
			this.ScreenCoordinates = screenCoordinates;
			this.currentSprite = CharacterSprites.CharacterRight[this.currentCharacterStage];
			this.currentCharacterStage = 0;
			this.position = Position.Right;
		}

		public void MoveTo(P2d point)
		{
			int dx = point.X - this.WorldPosition.X;
			int dy = point.Y - this.WorldPosition.Y;
			if (dx > 0)
			{
				if (this.position != Position.Right)
				{
					this.position = Position.Right;
					this.currentCharacterStage = 0;
				}
				else
				{
					this.currentCharacterStage += 1;
					if (this.currentCharacterStage >= CharacterSprites.CharacterRight.Length)
					{
						this.currentCharacterStage = 0;
					}
				}
				this.currentSprite = CharacterSprites.CharacterRight[this.currentCharacterStage];
			}
			if (dx < 0)
			{
				if (this.position != Position.Left)
				{
					this.position = Position.Left;
					this.currentCharacterStage = 0;
				}
				else
				{
					this.currentCharacterStage += 1;
					if (this.currentCharacterStage >= CharacterSprites.CharacterLeft.Length)
					{
						this.currentCharacterStage = 0;
					}
				}
				this.currentSprite = CharacterSprites.CharacterLeft[this.currentCharacterStage];
			}
			if (dy < 0)
			{
				if (this.position != Position.Top)
				{
					this.position = Position.Top;
					this.currentCharacterStage = 0;
				}
				else
				{
					this.currentCharacterStage += 1;
					if (this.currentCharacterStage >= CharacterSprites.CharacterTop.Length)
					{
						this.currentCharacterStage = 0;
					}
				}
				this.currentSprite = CharacterSprites.CharacterTop[this.currentCharacterStage];
			}
			if (dy > 0)
			{
				if (this.position != Position.Bottom)
				{
					this.position = Position.Bottom;
					this.currentCharacterStage = 0;
				}
				else
				{
					this.currentCharacterStage += 1;
					if (this.currentCharacterStage >= CharacterSprites.CharacterBottom.Length)
					{
						this.currentCharacterStage = 0;
					}
				}
				this.currentSprite = CharacterSprites.CharacterBottom[this.currentCharacterStage];
			}
			this.WorldPosition = point;
		}

		public override Bitmap GetSprite()
		{
			return this.currentSprite;
		}
	}
}
