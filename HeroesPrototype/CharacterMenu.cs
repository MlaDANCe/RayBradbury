using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using HeroesPrototype.Geometry;
using HeroesPrototype.Items;

namespace HeroesPrototype
{
	public class CharacterMenu : Menu
	{
		private readonly Menu sidebar;
		private readonly Menu mainMenu;
		private List<Item> currentContent;
		private bool haveContent;

		public CharacterMenu(P2d p, S2d d) : base(p,d)
		{
			this.sidebar = new Menu(new P2d(50, 50), new S2d(100, this.Size.H - 100));
			this.mainMenu = new Menu(new P2d(this.sidebar.Origin.X + this.sidebar.Size.W + 50, 50),
				new S2d(base.Size.W - this.sidebar.Size.W - 150, this.Size.H - 100));
			this.haveContent = false;
		}

		public void ClearContent()
		{
			this.currentContent = new List<Item>();
			this.haveContent = false;
		}

		public void AddContent(List<Item> content)
		{
			this.currentContent = content;
			this.haveContent = true;
		}

		public override System.Drawing.Bitmap GetMenu()
		{
			Bitmap menu = base.GetMenu();
			Graphics g = Graphics.FromImage(menu);
			if (this.haveContent)
			{
				Bitmap cont = this.DrawContent();
				g.DrawImage(cont, this.sidebar.Origin.X, this.sidebar.Origin.Y);
			}
			else
			{
				g.DrawImage(this.sidebar.GetMenu(), this.sidebar.Origin.X, this.sidebar.Origin.Y);
			}
			g.DrawImage(this.mainMenu.GetMenu(), this.mainMenu.Origin.X, this.mainMenu.Origin.Y);
			return menu;
		}

		private Bitmap DrawContent()
		{
			Bitmap cont = this.sidebar.GetMenu();
			Graphics g = Graphics.FromImage(cont);
			Font f = new Font("Arial", 12.0f);
			SolidBrush b = new SolidBrush(Color.Black);
			for (int i = 0; i < this.currentContent.Count; i++)
			{
				string name = string.Empty;
				if (this.currentContent[i] is Gold)
				{
					name = "Gold";
				}
				string quantity = this.currentContent[i].Quantity.ToString();
				g.DrawString(name + " " + quantity, f, b, new Point(this.sidebar.Origin.X - 50, this.sidebar.Origin.Y - 50));
			}
			return cont;
		}
	}
}
