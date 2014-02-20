using System;
using System.Drawing;

namespace HeroesPrototype.MapConsts
{
	public static class Objects
	{
		public static readonly Bitmap Castle = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\castle.png"));
		public static readonly Bitmap Forest = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\forest.png"));
		public static readonly Bitmap Mountain = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\mountain.png"));
		public static readonly Bitmap TerrainCastle = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\terrainCastle.png"));
		public static readonly Bitmap TerrainInferno = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\terrainInferno.png"));
		public static readonly Bitmap Chest = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\chest.png"));
		////items
		public static readonly Bitmap Staff = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\staff.png"));
		public static readonly Bitmap Sword = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\sword.png"));
		public static readonly Bitmap HeavyArmor = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\heavyArmor.png"));
		public static readonly Bitmap Shield = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\shield.png"));
		public static readonly Bitmap Helm = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\helm.png"));
		public static readonly Bitmap Axe = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\axe.bmp"));
		////needs sprite for Gold
	}
}