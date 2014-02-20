namespace HeroesPrototype.Geometry
{
    /// <summary>
    /// This class holds a point with x and y coordinates
    /// </summary>
    public class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2D(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public static Point2D operator+(Point2D p1, Point2D p2)
        {
            return new Point2D(p1.X + p2.X, p1.Y + p2.Y);
        }
        public static Point2D operator-(Point2D p1, Point2D p2)
        {
            return new Point2D(p2.X - p1.X, p2.Y - p1.Y);
        }
    }
}
