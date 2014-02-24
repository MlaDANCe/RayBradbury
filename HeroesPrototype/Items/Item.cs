using System;
using System.Drawing;
using System.Linq;
using HeroesPrototype.Geometry;
using HeroesPrototype.MapConsts;

namespace HeroesPrototype.Items
{
	public abstract class Item : IDrawable//,IDisappearing//can create a list of items in hero to store all the items
	{
		private int quantity = 1;
        private int secondQuantity = 1;
        public Random Rnd = new Random();

		public string Name { get; set; }

        public int Quantity
        {
			get
			{
				return this.quantity;
			}
			set
			{
				this.quantity = value;
			}
		}

        public int SecondQuantity
        {
            get
            {
                return this.secondQuantity;
            }
            set
            {
                this.secondQuantity = value;
            }
        }

		public Point2D Origin { get; set; }

		public Size2D Size { get; private set; }

		//public Bitmap CurrentSprite { get; set; }
		protected Item(string name, Point2D origin)
		{
			this.Name = name;
			this.Origin = origin;
		}

		Bitmap IDrawable.GetSprite()
		{
			return (Bitmap)(typeof(Objects)
										   .GetField(this.Name)
										   .GetValue(null));//method that shoud be inherited
		}
	}
}
