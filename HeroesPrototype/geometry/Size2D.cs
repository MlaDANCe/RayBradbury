namespace HeroesPrototype.Geometry
{
    /// <summary>
    /// This class holds a dimension defined by Width and Height
    /// </summary>
    public class Size2D
    {
        public int Width { get; set; }
        public int Height { get; set; } 

        public Size2D(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
