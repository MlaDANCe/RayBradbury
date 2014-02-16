using System;
using System.Drawing;

namespace HeroesPrototype.mapConsts
{
    public static class Objects
    {
        public static Bitmap castle = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\castle.png"));
        public static Bitmap forest = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\forest.png"));
        public static Bitmap building = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\building.png"));
        public static Bitmap blank = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\floor.png"));
        public static Bitmap chest = new Bitmap(Bitmap.FromFile(@"..\..\sprites\mapobj\chest.png"));
    }
}
