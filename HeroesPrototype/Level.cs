using System;
using System.Drawing;
using HeroesPrototype.Geometry;
using HeroesPrototype.MapObjects;
using HeroesPrototype.Items;

namespace HeroesPrototype
{
    /// <summary>
    /// In this class we start to work with map units
    /// lets assume that one map unit equals 50x50px screen units
    /// </summary>
    public class Level : IDrawable
    {
        // Another map array that will contain the default terrain, loaded from another bmp map file
        private readonly IDrawable[,] defaultTerrain;

        private readonly IDrawable[,] map;

        private readonly Point2D currentContainable;

        private readonly Bitmap scene;
        private readonly Graphics graphics;

        private bool isUpToDate;// I add this check because if the map is up to date the scene have not to be redrawn it safes 50% processing time 

        public Point2D Origin { get; set; }

        public Size2D Size { get; private set; }

        public Rectangle2D VisibleSpace { get; set; }

        public Size2D MapSize { get; private set; }

        public Level(Size2D sceneSize)
        {
            this.Origin = new Point2D(0, 0);
            this.Size = sceneSize;
            this.map = LevelLoader.Load(@"..\..\sprites\mapobj\map.bmp");
            this.defaultTerrain = LevelLoader.Load(@"..\..\sprites\mapobj\Default_Terrain.bmp");

            this.MapSize = new Size2D(this.map.GetLength(1), this.map.GetLength(0));

            int c_x_t = this.map.GetLength(1) / 2;
            int c_y_t = this.map.GetLength(0) / 2;

            int left = c_x_t - (this.Size.Width / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units
            int right = c_x_t + (this.Size.Width / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units
            int top = c_y_t - (this.Size.Height / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units
            int bottom = c_y_t + (this.Size.Height / MainScene.ScreenToMapUnits / 2); // Convert from screen to map units

            this.VisibleSpace = new Rectangle2D(new Point2D(left, top), new Size2D(right - left, bottom - top));

            this.scene = new Bitmap(this.Size.Width, this.Size.Height);
            this.graphics = Graphics.FromImage(this.scene);

            this.isUpToDate = false;
        }

        public Bitmap GetSprite()
        {
            if (!this.isUpToDate)
            {
                this.RenderScene();
            }
            return this.scene;
        }

        public bool IsPositionOccupied(Point2D pos)
        {
            var tile = this.map[pos.Y, pos.X];
            return !(tile == null || tile is TerrainCastle || tile is TerrainInferno || tile is TerrainMixed1 || tile is TerrainMixed2);
        }

        public void SetNotUpToDate()
        {
            this.isUpToDate = false;
        }

        private void RenderScene()
        {
            for (int i = this.VisibleSpace.Left; i < this.VisibleSpace.Right; i++)
            {
                for (int j = this.VisibleSpace.Top; j < this.VisibleSpace.Bottom; j++)
                {
                    int x = (i - this.VisibleSpace.Left) * MainScene.ScreenToMapUnits;
                    int y = (j - this.VisibleSpace.Top) * MainScene.ScreenToMapUnits;
               
                    if (this.defaultTerrain[j, i] != null)
                    {
                        this.graphics.DrawImage(this.defaultTerrain[j, i].GetSprite(), new Point(x, y));
                    }

                    if (this.map[j, i] != null)
                    {
                        this.graphics.DrawImage(this.map[j, i].GetSprite(), new Point(x, y));
                    }
                }
            }
            this.isUpToDate = true;
        }

        internal Item GetItem(Point2D newPlPos)
        {
            if (this.map[newPlPos.Y, newPlPos.X] is Item)
            {
                Item i = this.map[newPlPos.Y, newPlPos.X] as Item;
                this.map[newPlPos.Y, newPlPos.X] = this.GetSurrounding(newPlPos);
                return i;
            }
            return null;
        }

        private IDrawable GetSurrounding(Point2D newPlPos)
        {
            int terrainInfernoCount = 0;
            int terrainCastleCount = 0;
            int terrainMixed1 = 0;
            int terrMixed2 = 0;
            for (int i = newPlPos.Y - 1; i >= newPlPos.Y + 1; i++)
            {
                for (int j = newPlPos.X - 1; j < newPlPos.X + 1; j++)
                {
                    if (this.map[i, j] is TerrainInferno)
                    {
                        terrainInfernoCount++;
                    }
                    else if (this.map[i, j] is TerrainCastle)
                    {
                        terrainCastleCount++;
                    }
                    else if (this.map[i, j] is TerrainMixed1)
                    {
                        terrainMixed1++;
                    }
                    else if (this.map[i, j] is TerrainMixed2)
                    {
                        terrMixed2++;
                    }
                }
            }
            if (terrainCastleCount >= terrainInfernoCount || terrainCastleCount >= terrainMixed1 || terrainCastleCount >= terrMixed2)
            {
                return new TerrainCastle(newPlPos);
            }
            else if (terrainInfernoCount >= terrainCastleCount || terrainInfernoCount >= terrainMixed1 || terrainInfernoCount >= terrMixed2)
            {
                return new TerrainInferno(newPlPos);
            }
            else if (terrainMixed1 >= terrainCastleCount || terrainMixed1 >= terrainInfernoCount || terrainMixed1 >= terrMixed2)
            {
                return new TerrainMixed1(newPlPos);
            }
            else
            {
                return new TerrainMixed2(newPlPos);
            }
        }
    }
}
