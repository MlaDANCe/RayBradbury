using HeroesPrototype.geometry;
using HeroesPrototype.mapConsts;
using HeroesPrototype.MapObjects;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace HeroesPrototype
{
    /// <summary>
    /// In this class we start to work with map units
    /// lets assume that one map unit equals 50x50px screen units
    /// </summary>

    public class Level : Drawable
    {

        public P2d P { get; set; }
        public D2d S { get; private set; }

        private Rec visSpace;

        private Drawable[,] map;

        private Character main;

        private P2d currentContainable;

        Bitmap scene;
        Graphics g;

        public Level(D2d sceneSize)
        {
            this.P = new P2d(0, 0);
            this.S = sceneSize;
            this.map = LevelLoader.Load(@"..\..\sprites\mapobj\map.bmp");

            int c_x_t = map.GetLength(1) / 2;
            int c_y_t = map.GetLength(0) / 2;

            this.visSpace = new Rec();
            this.visSpace.L = c_x_t - (this.S.W / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units
            this.visSpace.R = c_x_t + (this.S.W / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units
            this.visSpace.T = c_y_t - (this.S.H / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units
            this.visSpace.B = c_y_t + (this.S.H / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units

            this.main = new Character(new P2d(c_x_t, c_y_t), new P2d(this.S.W / 2, this.S.H / 2));

            this.scene = new Bitmap(this.S.W, this.S.H);
            this.g = Graphics.FromImage(scene);
        }
        private void CalcVisibleSpace()
        {

        }
        public Bitmap GetSprite()
        {

            TerrainCastle tCastle = new TerrainCastle(new P2d(0, 0));
            //TerrainInferno tInferno = new TerrainInferno(new P2d(0, 0));
            for (int i = this.visSpace.L; i < this.visSpace.R; i++)
            {
                for (int j = this.visSpace.T; j < this.visSpace.B; j++)
                {
                    int x = (i - this.visSpace.L) * MainScene.ScreenToMapUnits;
                    int y = (j - this.visSpace.T) * MainScene.ScreenToMapUnits;
                    
                    g.DrawImage(tCastle.GetSprite(), x, y);

                    if (map[j, i] != null)
                    {
                        g.DrawImage(map[j, i].GetSprite(), new Point(x, y));
                    }
                }
            }
            g.DrawImage(main.GetSprite(), main.P.X, main.P.Y);
            return scene;
        }


        internal void MovePlayer(P2d dxdy) // This method sould be improved
        {
            P2d newPPos = this.main.WP + dxdy;
            if (newPPos.X >= 0 && newPPos.Y < this.map.GetLength(1)
                && newPPos.Y >= 0 && newPPos.Y < this.map.GetLength(0)) // Check if the character is inside the map
            {
                Rec newVis = this.visSpace + dxdy;
                if (newVis.L >= 0 && newVis.R <= map.GetLength(1)
                    && newVis.T >= 0 && newVis.B < map.GetLength(0)) // Check if the current visible is inside the map
                {
                    if (map[newPPos.Y, newPPos.X] == null)
                    {
                        this.main.MoveTo(newPPos);
                        this.visSpace = newVis;
                    }
                }
            }
        }

        internal List<Item> GetCharacterItems()
        {
            return this.main.Items;
        }

        internal bool HaveContainableObjects()
        {
            int cx = this.main.WP.X;
            int cy = this.main.WP.Y;
            if (this.map[cy - 1, cx] is Containable)
            {
                currentContainable = new P2d(cy - 1, cx);
                return true;
            }
            else if (this.map[cy + 1, cx] is Containable)
            {
                currentContainable = new P2d(cy + 1, cx);
                return true;
            }
            else if (this.map[cy, cx - 1] is Containable)
            {
                currentContainable = new P2d(cy, cx - 1);
                return true;
            }
            else if (this.map[cy, cx + 1] is Containable)
            {
                currentContainable = new P2d(cy, cx + 1);
                return true;
            }
            return false;
        }

        internal List<Item> GetContent()
        {
            return (this.map[currentContainable.X, currentContainable.Y] as Containable).Items;
        }
    }
}
