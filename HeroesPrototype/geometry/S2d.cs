namespace HeroesPrototype.Geometry
{
    /// <summary>
    /// This class holds a dimension defined by Width and Height
    /// </summary>
    public struct S2d
    {
        public int W { get; set; }
        public int H { get; set; } 

        public S2d(int width, int height) : this()
        {
            this.W = width;
            this.H = height;
        }
    }
}
