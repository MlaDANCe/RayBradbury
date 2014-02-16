using HeroesPrototype.geometry;
using HeroesPrototype.mapConsts;
using HeroesPrototype.MapObjects;
using System;
using System.Drawing;
namespace HeroesPrototype
{
    public static class LevelLoader
    {
        public static Drawable[,] Load(string path)
        {
            Bitmap bmp = new Bitmap(Bitmap.FromFile(path));

            Drawable[,] map = new Drawable[bmp.Height, bmp.Width];

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    int val = bmp.GetPixel(j, i).ToArgb() & 0xff;

                    if (val == Consts.Building)
                    {
                        map[i, j] = new Building(new P2d(j, i));
                    }
                    else if (val == Consts.Castle)
                    {
                        map[i, j] = new Castle(new P2d(j, i));
                    }
                    else if (val == Consts.Forest)
                    {
                        map[i, j] = new Forest(new P2d(j, i));
                    }
                    else if (val == Consts.Chest)
                    {
                        map[i, j] = new Chest(new P2d(j, i));
                    }
                    else
                    {
                        map[i, j] = null;
                    }
                }
            }

            return map;

        }
    }
}
