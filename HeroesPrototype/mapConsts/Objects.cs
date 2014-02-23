using System;
using System.Drawing;

namespace HeroesPrototype.MapConsts
{
    public static class Objects
    {
        // Terrain and map objects
        public static readonly Bitmap TerrainDefault = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\TerrainDefault.png"));
        public static readonly Bitmap TerrainBlack = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\TerrainBlack.png"));
        public static readonly Bitmap TerrainCastle = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\TerrainCastle.png"));
        public static readonly Bitmap TerrainInferno = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\TerrainInferno.png"));
        public static readonly Bitmap TerrainMixed1 = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\TerrainMixed1.png"));
        public static readonly Bitmap TerrainMixed2 = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\TerrainMixed2.png"));
        public static readonly Bitmap CastleTopLeft = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Castle\CAS_TL.png"));
        public static readonly Bitmap CastleTopCenter = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Castle\CAS_TC.png"));
        public static readonly Bitmap CastleTopRight = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Castle\CAS_TR.png"));
        public static readonly Bitmap CastleBotLeft = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Castle\CAS_BL.png"));
        public static readonly Bitmap CastleBotCenter = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Castle\CAS_BC.png"));
        public static readonly Bitmap CastleBotRight = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Castle\CAS_BR.png"));
        public static readonly Bitmap InfernoTopLeft = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Inferno\INF_TL.png"));
        public static readonly Bitmap InfernoTopCenter = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Inferno\INF_TC.png"));
        public static readonly Bitmap InfernoTopRight = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Inferno\INF_TR.png"));
        public static readonly Bitmap InfernoBotLeft = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Inferno\INF_BL.png"));
        public static readonly Bitmap InfernoBotCenter = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Inferno\INF_BC.png"));
        public static readonly Bitmap InfernoBotRight = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Inferno\INF_BR.png"));
        public static readonly Bitmap Forest = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\Forest.png"));
        public static readonly Bitmap Mountain = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Terrain\Mountain.png"));
        public static readonly Bitmap Chest = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\Chest.png"));
        // Items
        public static readonly Bitmap Staff = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\staff.png"));
        public static readonly Bitmap Sword = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\sword.png"));
        public static readonly Bitmap HeavyArmor = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\heavyArmor.png"));
        public static readonly Bitmap Shield = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\shield.png"));
        public static readonly Bitmap Helm = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\helm.png"));
        public static readonly Bitmap Axe = new Bitmap(Bitmap.FromFile(@"..\..\sprites\items\axe.bmp"));
        ////needs sprite for Gold
    }
}