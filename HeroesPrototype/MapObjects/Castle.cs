using HeroesPrototype.Geometry;
using HeroesPrototype.MapConsts;
using System.Drawing;
using System.Collections.Generic;

namespace HeroesPrototype.MapObjects
{
    public class Castle : MapObjectBase, Spawnable
    {
        public Castle(Point2D origin, Bitmap sprite)
            : base(origin, sprite)
        {
            this.UnitsSpawned = new List<Units.Unit>();
            this.UnitsSpawned.Add(new Units.Magog(new Point2D(0, 0)));
            this.UnitsSpawned.Add(new Units.Magog(new Point2D(0, 0)));
            this.UnitsSpawned.Add(new Units.Magog(new Point2D(0, 0)));
            this.UnitsSpawned.Add(new Units.Magog(new Point2D(0, 0)));
        }
        public bool IsSpawnable { get; set; }


        public List<Units.Unit> UnitsSpawned { get; set; }

        public List<Units.Unit> BuyUnits(int gold)
        {
            return UnitsSpawned;
        }
    }
}