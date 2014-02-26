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
            this.UnitsSpawned = new List<Unit>();

            this.UnitsSpawned.Add(new Magog(new Point2D(0, 0)));
            this.UnitsSpawned.Add(new Magog(new Point2D(0, 0)));

            this.UnitsSpawned.Add(new Angel(new Point2D(0, 0)));
            this.UnitsSpawned.Add(new Angel(new Point2D(0, 0)));
            
            this.UnitsSpawned.Add(new Devil(new Point2D(0, 0)));
            this.UnitsSpawned.Add(new Devil(new Point2D(0, 0)));
            
            this.UnitsSpawned.Add(new Marksman(new Point2D(0, 0)));
            this.UnitsSpawned.Add(new Marksman(new Point2D(0, 0)));

            this.UnitsSpawned.Add(new Pikeman(new Point2D(0, 0)));
            this.UnitsSpawned.Add(new Pikeman(new Point2D(0, 0)));

            this.UnitsSpawned.Add(new Imp(new Point2D(0, 0)));
            this.UnitsSpawned.Add(new Imp(new Point2D(0, 0)));
        }
        public bool IsSpawnable { get; set; }


        public List<Unit> UnitsSpawned { get; set; }

        public List<Unit> BuyUnits(int gold)
        {
            return UnitsSpawned;
        }
    }
}