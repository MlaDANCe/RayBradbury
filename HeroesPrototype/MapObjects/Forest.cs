using HeroesPrototype.geometry;
namespace HeroesPrototype.MapObjects
{
    class Forest : Drawable
    {
        public P2d P { get; set; }
        public D2d S { get; private set; }

        public Forest(P2d xy)
        {
            this.P = xy;
        }

        public System.Drawing.Bitmap GetSprite()
        {
            return mapConsts.Objects.forest;
        }
    }
}
