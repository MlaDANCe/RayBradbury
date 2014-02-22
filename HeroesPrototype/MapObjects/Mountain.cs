using System.Drawing;
using HeroesPrototype.Geometry;
using HeroesPrototype.MapConsts;

namespace HeroesPrototype.MapObjects
{
	public class Mountain : MapObjectBase
	{
		public Mountain(Point2D origin) : base(origin, Objects.Mountain)
		{
		}
	}
}