using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.mapConsts
{
    public static class Consts
    {
        public const int Forest = 0x6a6a6a & 0xff;
        public const int Castle = 0xbcbcbc & 0xff;
        public const int Building = 0x272727 & 0xff;
        public const int TerrainCastle = 0xffffff & 0xff;
        public const int TerrainInferno = 0xaaaaaa & 0xff; // to do: change to real hex color
        public const int Chest = 0x5f5f5f & 0xff;
        public const int Mountain = 0x5a5a5a & 0xff; // to do: change to real hex color
    }
}
