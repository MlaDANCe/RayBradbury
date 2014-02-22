namespace HeroesPrototype.Geometry
{
    /// <summary>
    /// This class holds a point with x and y coordinates
    /// </summary>
    public struct P2d
    {
        public int X { get; set; }
        public int Y { get; set; }

        public P2d(int x, int y): this()
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
