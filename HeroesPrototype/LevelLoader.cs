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
        public static Point2D playerStartPosition; // This should not be here but i dont want to make player start position drawable :)
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
                        var castle = new Castle(new Point2D(j, i), Objects.CastleBotCenter);
                        castle.IsSpawnable = true;
                        map[i, j] = castle;
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
                    else if (val == Consts.CampFire)
                    {
                        map[i, j] = new CampFire(new Point2D(j, i), Objects.CampFire);
                    }
					else if (val == Consts.TreasureChest)
					{
                        map[i, j] = new TreasureChest(new Point2D(j, i), Objects.TreasureChest);
					}
                    else if (val == Consts.GoldPile)
                    {
                        map[i, j] = new Gold(new Point2D(j, i), Objects.GoldPile);
                    }
                    else if (val == Consts.WoodPile)
                    {
                        map[i, j] = new Wood(new Point2D(j, i), Objects.WoodPile);
                    }
                    else if (val == Consts.OrePile)
                    {
                        map[i, j] = new Ore(new Point2D(j, i), Objects.OrePile);
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
                    else if (val == Consts.Imp)
                    {
                        map[i, j] = new Imp(new Point2D(j, i), Objects.Imp);
                    }
                    else if (val == Consts.Magog)
                    {
                        map[i, j] = new Magog(new Point2D(j, i), Objects.Magog);
                    }
                    else if (val == Consts.Angel)
                    {
                        map[i, j] = new Angel(new Point2D(j, i), Objects.Angel);
                    }
                    else if (val == Consts.Marksman)
                    {
                        map[i, j] = new Marksman(new Point2D(j, i), Objects.Marksman);
                    }
                    else if (val == Consts.Pikeman)
                    {
                        map[i, j] = new Pikeman(new Point2D(j, i), Objects.Pikeman);
                    }
                    else if (val == Consts.Devil)
                    {
                        map[i, j] = new Devil(new Point2D(j, i), Objects.Devil);
                    }
                    else if(val == Consts.BootsOfSpeed)
                    {
                        map[i, j] = new BootsOfSpeed(new Point2D(j, i));
                    }
                    else if (val == Consts.VialOfBlood)
                    {
                        map[i, j] = new VialOfBlood(new Point2D(j, i));
                    }
                    else if (val == Consts.Tier1Armor)
                    {
                        map[i, j] = new Tier1Armor(new Point2D(j, i));
                    }
                    else if (val == Consts.Tier2Armor)
                    {
                        map[i, j] = new Tier2Armor(new Point2D(j, i));
                    }
                    else if (val == Consts.Tier1Weapon)
                    {
                        map[i, j] = new Tier1Weapon(new Point2D(j, i));
                    }
                    else if (val == Consts.Tier2Weapon)
                    {
                        map[i, j] = new Tier2Weapon(new Point2D(j, i));
                    }
                    else if (val == Consts.Tier1Shield)
                    {
                        map[i, j] = new Tier1Shield(new Point2D(j, i));
                    }
                    else if (val == Consts.Tier2Shield)
                    {
                        map[i, j] = new Tier2Shield(new Point2D(j, i));
                    }
                    else if (val == Consts.Tier1Helm)
                    {
                        map[i, j] = new Tier1Helm(new Point2D(j, i));
                    }
                    else if (val == Consts.Tier2Helm)
                    {
                        map[i, j] = new Tier2Helm(new Point2D(j, i));
                    }
                    else if(val == Consts.PlayerStartPosition)
                    {
                        playerStartPosition = new Point2D(j, i);
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
