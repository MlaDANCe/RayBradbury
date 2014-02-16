namespace HeroesPrototype.geometry
{
    /// <summary>
    /// This class holds a dimension defined by Width and Height
    /// I use short name because it will be used often
    /// </summary>
    public class D2d
    {
        public int W { get; set; }
        public int H { get; set; } 

        public D2d(int width, int height)
        {
            this.W = width;
            this.H = height;
        }
    }
}
