using System;
using System.Drawing;
using HeroesPrototype.Geometry;
using HeroesPrototype.MapConsts;
using HeroesPrototype.MapObjects;
using HeroesPrototype.Items;

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
						map[i, j] = new Mountain(new Point2D(j, i));
					}
					else if (val == Consts.CastleTopLeft)
					{
						map[i, j] = new Castle(new Point2D(j, i), Objects.CastleTopLeft);
					}
                    else if (val == Consts.CastleTopCenter)
                    {
                        map[i, j] = new Castle(new Point2D(j, i), Objects.CastleTopCenter);
                    }
                    else if (val == Consts.CastleTopRight)
                    {
                        map[i, j] = new Castle(new Point2D(j, i), Objects.CastleTopRight);
                    }
                    else if (val == Consts.CastleBotLeft)
                    {
                        map[i, j] = new Castle(new Point2D(j, i), Objects.CastleBotLeft);
                    }
                    else if (val == Consts.CastleBotCenter)
                    {
                        map[i, j] = new Castle(new Point2D(j, i), Objects.CastleBotCenter);
                    }
                    else if (val == Consts.CastleBotRight)
                    {
                        map[i, j] = new Castle(new Point2D(j, i), Objects.CastleBotRight);
                    }
                    else if (val == Consts.InfernoTopLeft)
                    {
                        map[i, j] = new Castle(new Point2D(j, i), Objects.InfernoTopLeft);
                    }
                    else if (val == Consts.InfernoTopCenter)
                    {
                        map[i, j] = new Castle(new Point2D(j, i), Objects.InfernoTopCenter);
                    }
                    else if (val == Consts.InfernoTopRight)
                    {
                        map[i, j] = new Castle(new Point2D(j, i), Objects.InfernoTopRight);
                    }
                    else if (val == Consts.InfernoBotLeft)
                    {
                        map[i, j] = new Castle(new Point2D(j, i), Objects.InfernoBotLeft);
                    }
                    else if (val == Consts.InfernoBotCenter)
                    {
                        map[i, j] = new Castle(new Point2D(j, i), Objects.InfernoBotCenter);
                    }
                    else if (val == Consts.InfernoBotRight)
                    {
                        map[i, j] = new Castle(new Point2D(j, i), Objects.InfernoBotRight);
                    }
					else if (val == Consts.Forest)
					{
						map[i, j] = new Forest(new Point2D(j, i));
					}
					else if (val == Consts.Chest)
					{
						map[i, j] = new Chest(new Point2D(j, i));
					}
                    else if (val == Consts.TerrainBlack)
                    {
                        map[i, j] = new TerrainBlack(new Point2D(j, i));
                    }
					else if (val == Consts.TerrainCastle)
					{
						map[i, j] = new TerrainCastle(new Point2D(j, i));
					}
					else if (val == Consts.TerrainInferno)
					{
						map[i, j] = new TerrainInferno(new Point2D(j, i));
					}
                    else if (val == Consts.TerrainMixed1)
                    {
                        map[i, j] = new TerrainMixed1(new Point2D(j, i));
                    }
                    else if (val == Consts.TerrainMixed2)
                    {
                        map[i, j] = new TerrainMixed2(new Point2D(j, i));
                    }
                    else if(val == Consts.Axe)
                    {
                        map[i, j] = new Axe(new Point2D(j, i));
                    }
                    else if (val == Consts.HeavyArmor)
                    {
                        map[i, j] = new HeavyArmor(new Point2D(j, i));
                    }
                    else if (val == Consts.Helm)
                    {
                        map[i, j] = new Helm(new Point2D(j, i));
                    }
                    else if (val == Consts.Sword)
                    {
                        map[i, j] = new Sword(new Point2D(j, i));
                    }
                    else if (val == Consts.Staff)
                    {
                        map[i, j] = new Staff(new Point2D(j, i));
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
