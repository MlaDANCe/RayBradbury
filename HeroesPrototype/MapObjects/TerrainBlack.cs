using HeroesPrototype.Geometry;
using HeroesPrototype.MapConsts;

namespace HeroesPrototype.MapObjects
{
    public class TerrainBlack : MapObjectBase
    {
        public TerrainBlack(Point2D origin)
            : base(origin, Objects.TerrainBlack)
        {
        }
    }
}