using HeroesPrototype.Geometry;
using HeroesPrototype.MapConsts;
using System.Drawing;

namespace HeroesPrototype.MapObjects
{
    public class Castle : MapObjectBase
    {
        public Castle(Point2D origin, Bitmap sprite)
            : base(origin, sprite)
        {
        }
    }
}