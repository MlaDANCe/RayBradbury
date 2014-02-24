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

        public uint Gold { get; set; }
        public uint Ore { get; set; }
        public uint Wood { get; set; }

        private int maxMoves = 20;
        private int moves;

		public Point2D WorldPosition { get; set; }

		public Point2D ScreenCoordinates { get; set; }

        public int MaxMoves
        {
            get
            {
                return this.maxMoves;
            }
            set
            {
                this.maxMoves = value;
            }
        }

        public int Moves
        {
            get
            {
                return this.moves;
            }
            set
            {
                this.moves = value;
            }
        }

        public override Size2D Size
        {
			get
			{
				throw new NotImplementedException();
			}
		}

		public List<Item> Items { get; set; }

		public MainCharacter(Point2D worldPosition, Point2D screenCoordinates)
		{
			this.WorldPosition = worldPosition;
			this.ScreenCoordinates = screenCoordinates;

			this.currentSprite = CharacterSprites.CharacterRight[this.currentCharacterStage];

			this.currentCharacterStage = 0;
			this.position = Position.Right;

            this.currentA = new DefArmor();
            this.currentW = new DefWeapon();

            this.Attack = this.currentW.Attack;
            this.Defense = this.currentA.Defense;

            this.Items = new List<Item>();


		}

		public void MoveTo(Point2D point)
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
        public void AddItem(Item item)
        {
            if (item is Weapon)
            {
                var itm = item as Weapon;
                if(itm.Attack > this.currentW.Attack)
                {
                    this.Items.Add(this.currentW);
                    this.currentW = itm;
                }
            }
            else if (item is Armor)
            {
                var itm = item as Armor;
                if(itm.Defense > this.currentA.Defense)
                {
                    this.Items.Add(this.currentA);
                    this.currentA = itm;
                }
            }
        }
		public override Bitmap GetSprite()
		{
			return this.currentSprite;
		}
	}
}
