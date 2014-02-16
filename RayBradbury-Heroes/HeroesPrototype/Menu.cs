using HeroesPrototype.geometry;
using HeroesPrototype.MenuObjects;
using System.Collections.Generic;
using System.Drawing;

namespace HeroesPrototype
{
    public class Menu
    {
        public P2d P { get; set; }
        public D2d S { get; set; }

        public Menu(P2d p, D2d s)
        {
            this.P = p;
            this.S = s;
        }
        public virtual System.Drawing.Bitmap GetMenu()
        {
            Bitmap menu = new Bitmap(this.S.W, this.S.H);
            Graphics g = Graphics.FromImage(menu);
            Pen p = new Pen(Color.Black, 2.0f);



            int maxX = this.S.W / MainScene.ScreenToMapUnits;
            int maxY = this.S.H / MainScene.ScreenToMapUnits;

            for (int i = 0; i < maxY; i++)
            {
                for (int j = 0; j < maxX; j++)
                {
                    int cx = j * MainScene.ScreenToMapUnits;
                    int cy = i * MainScene.ScreenToMapUnits;
                    g.DrawImage(MenuObjects.MenuObjects.background, cx, cy);
                }
            }
            g.DrawLine(p, new Point(1, 1), new Point(menu.Width - 1, 1));
            g.DrawLine(p, new Point(1, menu.Height - 1), new Point(menu.Width - 1, menu.Height - 1));
            g.DrawLine(p, new Point(1, 1), new Point(1, menu.Height - 1));
            g.DrawLine(p, new Point(menu.Width - 1, 1), new Point(menu.Width - 1, menu.Height - 1));
            return menu;
        }
    }
}
