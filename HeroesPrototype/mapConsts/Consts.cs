using System;
using System.Linq;

namespace HeroesPrototype.MapConsts
{
    public static class Consts
    {
        // Terrain and map objects
        public const int TerrainBlack = 0x010101 & 0xff;
        public const int TerrainCastle = 0x22b14c & 0xff;
        public const int TerrainInferno = 0xed1c24 & 0xff;
        public const int TerrainMixed1 = 0xff7f27 & 0xff;
        public const int TerrainMixed2 = 0xff7fc7 & 0xff;
        public const int CastleTopLeft = 0x0afa0a & 0xff;
        public const int CastleTopCenter = 0x14fa14 & 0xff;
        public const int CastleTopRight = 0x1efa1e & 0xff;
        public const int CastleBotLeft = 0x28fa28 & 0xff;
        public const int CastleBotCenter = 0x32fa32 & 0xff;
        public const int CastleBotRight = 0x3cfa3c & 0xff;
        public const int InfernoTopLeft = 0xff00f1 & 0xff;
        public const int InfernoTopCenter = 0xff00f2 & 0xff;
        public const int InfernoTopRight = 0xff00f3 & 0xff;
        public const int InfernoBotLeft = 0xff00f4 & 0xff;
        public const int InfernoBotCenter = 0xff00f5 & 0xff;
        public const int InfernoBotRight = 0xff00f6 & 0xff;
        public const int Forest = 0x6a6a6a & 0xff;
        public const int Mountain = 0x272726 & 0xff;

        // Resources
        public const int TreasureChest = 0x5f5f5f & 0xff;
        public const int GoldPile = 0xfff262 & 0xff;
        public const int CampFire = 0xfff259 & 0xff;
        public const int WoodPile = 0x606060 & 0xff;
        public const int OrePile = 0x616161 & 0xff;

        // Items
        public const int BootsOfSpeed = 0xff0049 & 0xff;
        public const int Tier1Weapon =  0xff0050 & 0xff;
        public const int Tier2Weapon =  0xff0051 & 0xff;
        public const int Tier1Armor =   0xff0052 & 0xff;
        public const int Tier2Armor =   0xff0053 & 0xff;
        public const int Tier1Helm =    0xff0054 & 0xff;
        public const int Tier2Helm =    0xff0055 & 0xff;
        public const int Tier1Shield =  0xff0056 & 0xff;
        public const int Tier2Shield = 0xff0057 & 0xff;
        public const int VialOfBlood =  0xff0058 & 0xff;
        

        // Units
        public const int Imp = 0x000065 & 0xff;
        public const int Magog = 0x000066 & 0xff;
        public const int Devil = 0x000067 & 0xff;
        public const int Angel = 0x000068 & 0xff;
        public const int Marksman = 0x000069 & 0xff;
        public const int Pikeman = 0x000070 & 0xff;

        //Player start position
        public const int PlayerStartPosition = 0x5a1818 & 0xff;
    }
}