using HeroesPrototype.geometry;
using HeroesPrototype.Items;
using System;
using System.Collections.Generic;

namespace HeroesPrototype.MapObjects
{
    public class Chest : Drawable, Containable
    {
        public P2d P { get; set; }
        public D2d S { get; private set; }

        public Chest(P2d xy)
        {
            this.P = xy;
            this.Items = new List<Item>();
            this.Items.Add(new Gold());
        }

        public System.Drawing.Bitmap GetSprite()
        {
            return mapConsts.Objects.chest;
        }

        public List<Item> Items
        {
            get;
            set;
        }



        public List<Item> GetItems()
        {
            return this.Items;
        }
    }
}
