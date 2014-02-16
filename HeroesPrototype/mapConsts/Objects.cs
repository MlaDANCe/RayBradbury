using System;
using System.Drawing;

namespace HeroesPrototype.mapConsts
{
    public static class Objects
    {
        public static Bitmap castle = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\castle.png"));
        public static Bitmap forest = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\forest.png"));
        public static Bitmap mountain = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\mountain.png"));
        public static Bitmap terrainCastle = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\terrainCastle.png"));
        public static Bitmap terrainInferno = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\terrainInferno.png"));
        public static Bitmap chest = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\chest.png"));
    }
}
