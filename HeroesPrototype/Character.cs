using HeroesPrototype.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype
{
    public abstract class Character : Drawable, Containable
    {



        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpellPower { get; set; }
        public int Knowledge { get; set; }


        public geometry.P2d P { get; set; }

        public geometry.D2d S { get; private set; }

        public abstract System.Drawing.Bitmap GetSprite();


        public List<Item> Items { get; set; }

    }
}
