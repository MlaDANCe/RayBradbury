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

        public Rec visSpace { get; set; }

        private Drawable[,] map;

        private P2d currentContainable;

        private Bitmap scene;
        private Graphics g;

        public D2d mapSize { get; private set; }

        public Level(D2d sceneSize)
        {
            this.P = new P2d(0, 0);
            this.S = sceneSize;
            this.map = LevelLoader.Load(@"..\..\sprites\mapobj\map.bmp");

            this.mapSize = new D2d(this.map.GetLength(1), this.map.GetLength(0));

            int c_x_t = map.GetLength(1) / 2;
            int c_y_t = map.GetLength(0) / 2;

            this.visSpace = new Rec();
            this.visSpace.L = c_x_t - (this.S.W / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units
            this.visSpace.R = c_x_t + (this.S.W / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units
            this.visSpace.T = c_y_t - (this.S.H / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units
            this.visSpace.B = c_y_t + (this.S.H / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units

            this.scene = new Bitmap(this.S.W, this.S.H);
            this.g = Graphics.FromImage(scene);
        }
        public Bitmap GetSprite()
        {
            TerrainInferno tInferno = new TerrainInferno(new P2d(0, 0));
            for (int i = this.visSpace.L; i < this.visSpace.R; i++)
            {
                for (int j = this.visSpace.T; j < this.visSpace.B; j++)
                {
                    int x = (i - this.visSpace.L) * MainScene.ScreenToMapUnits;
                    int y = (j - this.visSpace.T) * MainScene.ScreenToMapUnits;

                    g.DrawImage(tInferno.GetSprite(), x, y);

                    if (map[j, i] != null)
                    {
                        g.DrawImage(map[j, i].GetSprite(), new Point(x, y));
                    }
                }
            }
            return scene;
        }

        public bool IsPositionOccupied(P2d pos)
        {
            bool isFree = false;
            if(this.map[pos.Y, pos.X] is TerrainCastle || 
                this.map[pos.Y, pos.X] is TerrainInferno || 
                this.map[pos.Y,pos.X] == null )
            {
                return false;
            }
            return true;
        }
        
    }
}
