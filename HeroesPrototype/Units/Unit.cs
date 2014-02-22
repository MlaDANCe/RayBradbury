using System;
using System.Drawing;
using System.Linq;
using HeroesPrototype.Geometry;
using HeroesPrototype.MapConsts;

namespace HeroesPrototype.Units
{
	public abstract class Unit : IDrawable //,IDisappearing //can create a list of items in hero to store all the items
	{
		public string Name { get; set; }

		public int Attack { get; set; }

		public int Defence { get; set; }

		public int Health { get; set; }
        
		public Point2D Origin { get; set; }

		public Size2D Size { get; private set; }

		//public Bitmap CurrentSprite { get; set; }
		public Unit(string name, Point2D origin, int attack, int defence, int health)
		{
			this.Name = name;
			this.Attack = attack;
			this.Defence = defence;
			this.Health = health;
			this.Origin = origin;
		}

		Bitmap IDrawable.GetSprite()
		{
			return (Bitmap)(typeof(Objects)
										   .GetField(this.Name)
										   .GetValue(null)); //method that shoud be inherited
		}
	}
}
