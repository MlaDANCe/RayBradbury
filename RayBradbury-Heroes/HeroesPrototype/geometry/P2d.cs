namespace HeroesPrototype.geometry
{
    /// <summary>
    /// This class holds a point with x and y coordinates
    /// I use short names  because it will be used often
    /// </summary>
    public class P2d
    {
        public int X { get; set; }
        public int Y { get; set; }

        public P2d(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public static P2d operator+(P2d p1, P2d p2)
        {
            return new P2d(p1.X + p2.X, p1.Y + p2.Y);
        }
        public static P2d operator-(P2d p1, P2d p2)
        {
            return new P2d(p2.X - p1.X, p2.Y - p1.Y);
        }
    }
}
