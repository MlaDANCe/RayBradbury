﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using HeroesPrototype.Geometry;
using HeroesPrototype.Items;

namespace HeroesPrototype.CharacterAssets
{
	public abstract class CharacterBase : IDrawable, IContaining
	{
		public int Attack { get; set; }

		public int Defense { get; set; }

		public int SpellPower { get; set; }

		public int Knowledge { get; set; }

		public Point2D Origin { get; set; }

		public abstract Size2D Size { get; }

		public List<Item> Items { get; set; }

		public abstract Bitmap GetSprite();

        protected Weapon currentW;

        protected Armor currentA;
	}
}