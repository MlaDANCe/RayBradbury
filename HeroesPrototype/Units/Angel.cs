using System;
using System.Linq;
using HeroesPrototype.Geometry;
using System.Drawing;

namespace HeroesPrototype
{
	public class Angel : UnitLevel3
	{       
		public Angel(Point2D origin) : base("Angel", origin, 10, 10, 10)
		{
		}        
	}
}