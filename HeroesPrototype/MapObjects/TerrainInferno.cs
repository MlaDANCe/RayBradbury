using HeroesPrototype.geometry;
namespace HeroesPrototype.MapObjects
{
    class TerrainInferno : Drawable
    {
        public P2d P { get; set; }
        public D2d S { get; private set; }

        public TerrainInferno(P2d xy)
        {
            this.P = xy;
        }

        public System.Drawing.Bitmap GetSprite()
        {
            return mapConsts.Objects.terrainInferno;
        }
    }
}