using System;
using System.Drawing;
using HeroesPrototype.Geometry;
using HeroesPrototype.MapConsts;
using HeroesPrototype.MapObjects;

namespace HeroesPrototype
{
	public static class LevelLoader
	{
		public static IDrawable[,] Load(string path)
		{
			Bitmap bmp = new Bitmap(Bitmap.FromFile(path));

			IDrawable[,] map = new IDrawable[bmp.Height, bmp.Width];

			for (int i = 0; i < bmp.Height; i++)
			{
				for (int j = 0; j < bmp.Width; j++)
				{
					int val = bmp.GetPixel(j, i).ToArgb() & 0xff;

					if (val == Consts.Mountain)
					{
						map[i, j] = new Mountain(new P2d(j, i));
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
					else if (val == Consts.TerrainCastle)
					{
						map[i, j] = new TerrainCastle(new P2d(j, i));
					}
					else if (val == Consts.TerrainInferno)
					{
						map[i, j] = new TerrainInferno(new P2d(j, i));
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
