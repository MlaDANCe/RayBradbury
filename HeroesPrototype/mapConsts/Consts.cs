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
        //resources
        public const int Chest = 0x5f5f5f & 0xff;
        public const int GoldPile = 0xfff262 & 0xff;
        // Items
        public const int Axe = 0x5a5a51 & 0xff;
        public const int HeavyArmor = 0x5a5a52 & 0xff;
        public const int Helm = 0x5a5a53 & 0xff;
        public const int Shield = 0x5a5a54 & 0xff;
        public const int Staff = 0x5a5a55 & 0xff;
        public const int Sword = 0x5a5a57 & 0xff;
    }
}