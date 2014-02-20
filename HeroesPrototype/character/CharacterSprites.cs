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
        public static Bitmap[] characLeft = new Bitmap[]
        {
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s1_l.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s2_l.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s3_l.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s4_l.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s5_l.png"))
        };

        public static Bitmap[] characRight = new Bitmap[]
        {
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s1_r.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s2_r.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s3_r.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s4_r.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s5_r.png"))
        };

        public static Bitmap[] characTop = new Bitmap[]
        {
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s1_u.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s2_u.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s3_u.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s4_u.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s5_u.png"))
        };

        public static Bitmap[] characBottom = new Bitmap[]
        {
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s1_b.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s2_b.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s3_b.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s4_b.png")),
            new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s5_b.png"))
        };
    }
}
