using HeroesPrototype.Geometry;
using HeroesPrototype.MapConsts;

namespace HeroesPrototype.MapObjects
{
    public class TerrainDefault : MapObjectBase
    {
        public TerrainDefault(Point2D origin)
            : base(origin, Objects.TerrainDefault)
        {
        }
    }
}
