using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.character
{
    public static class CharacterSprites
    {
        public static Bitmap charac_left = new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\luke_left.png"));
        public static Bitmap charac_right = new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\luke_right.png"));
        public static Bitmap charac_top = new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\luke_top.png"));
        public static Bitmap charac_bottom = new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\luke_bottom.png"));
    }
}
