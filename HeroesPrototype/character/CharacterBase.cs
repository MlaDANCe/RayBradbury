using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HeroesPrototype.Geometry;
using HeroesPrototype.Items;

namespace HeroesPrototype.CharacterAssets
{
	public abstract class CharacterBase : IDrawable, IContaining
	{
		private readonly Random random = new Random();
		private int experience;

		protected CharacterBase(int attack, int defense, int spellPower)
		{
			this.Attack = attack;
			this.Defense = defense;
			this.SpellPower = spellPower;
			this.Level = 1;
		}

		public int Attack { get; set; }

		public int Defense { get; set; }

		public int SpellPower { get; set; }

		public int Knowledge { get; set; }

		public Point2D Origin { get; set; }

		public abstract Size2D Size { get; }

		public List<Item> Items { get; set; }

		public int Level { get; private set; }

		public int Gold { get; set; }

		public int Ore { get; set; }

		public int Wood { get; set; }

		public int Experience
		{
			get
			{
				return this.experience;
			}
			set
			{
				if (this.experience != value)
				{
					this.experience = value;
					this.UpdateLevel();
				}
			}
		}

		private void UpdateLevel()
		{
			if (this.experience >= this.Level * 1000)
			{
				this.experience = this.experience - this.Level * 1000;
				this.Level++;
				string attributeMessage = string.Empty;
				switch(this.random.Next(2))
				{
					case 0:
						this.Attack++;
						attributeMessage = "You have gained 1 Attack";
						break;
					case 1:
						this.Defense++;
						attributeMessage = "You have gained 1 Defense";
						break;
				}

				MessageBox.Show(string.Format("You have gained level!\nYou are now level {0}.\n{1}", this.Level, attributeMessage));
			}
		}

		public Weapon currentW { get; set; }

		public Armor currentA { get; set; }

		public List<Unit> Units { get; set; }

		public abstract Bitmap GetSprite();
	}
}