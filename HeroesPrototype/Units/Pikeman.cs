﻿using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Units
{
	public class Pikeman : UnitLevel1
	{
		public Pikeman(P2d origin) : base("Pikeman", origin, 10, 10, 10)
		{
		}
	}
}
