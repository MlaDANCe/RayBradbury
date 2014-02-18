using HeroesPrototype.Items;
using HeroesPrototype.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype
{
    internal class Gold : Item
    {
        public Gold() : base("gold")
        {
            base.Quantity = (new Random()).Next(1, 50);
        }
    }
}
