using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using HeroesPrototype.Items;
using HeroesPrototype.Geometry;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace HeroesPrototype.CharacterAssets
{
	public class MainCharacter : CharacterBase
	{
		Bitmap currentSprite;

		private int currentCharacterStage;

		private Position position;


        private int maxMoves = int.MaxValue;
        private int moves;

		public Point2D WorldPosition { get; set; }

		public Point2D ScreenCoordinates { get; set; }

        public int MaxMoves { get; set; }

        public int Moves { get; set; }

        public override Size2D Size
        {
			get
			{
				throw new NotImplementedException();
			}
		}

	    private Dictionary<Type, Unit> units = new Dictionary<Type, Unit>();


		public MainCharacter(Point2D worldPosition, Point2D screenCoordinates):base(100,100,30)
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

            this.MaxMoves = this.maxMoves;

            this.units = new Dictionary<Type, Unit>();

            this.Units = new List<Unit>();
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
        public void AddUnit(Unit unit)
        {
            this.Units.Add(unit);
        }

	    public int AttackPower()
	    {
	        int heroPower=Attack+SpellPower;
            heroPower += Items.OfType<Weapon>().Sum(weapon => weapon.Attack + weapon.Damage);
	        int power= units.Sum(entry => entry.Value.Quantity*entry.Value.Attack);
	        Console.WriteLine(power);
	        Console.WriteLine(heroPower);
	        Console.ReadLine();
	        return (int) (power + heroPower + 0.01*heroPower*power);

	    }
        public int DefensePower()
        {
            int heroPower = Defense;
           
            heroPower += Items.OfType<Armor>().Sum(armor => armor.Defense);
            
            int power = units.Sum(entry => entry.Value.Quantity * entry.Value.Defence*entry.Value.Health);
          //  MessageBox.Show("Defense" + power.ToString());
            return (int)(power + heroPower + 0.01 * heroPower * power);
            
        }
		public override Bitmap GetSprite()
		{
			return this.currentSprite;
		}
	}
}
