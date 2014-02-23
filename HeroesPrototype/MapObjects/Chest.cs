using System;
using System.Collections.Generic;
using HeroesPrototype.Geometry;
using HeroesPrototype.Items;
using HeroesPrototype.MapConsts;


namespace HeroesPrototype.MapObjects
{
    public class Chest : MapObjectBase, IContaining
    {
        public List<Item> Items { get; set; }

        public Chest(Point2D origin)
            : base(origin, Objects.Chest)
        {
            this.Items = new List<Item>();
            this.Items.Add(new Gold(origin));
        }
    }
}