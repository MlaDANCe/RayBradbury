using HeroesPrototype.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype
{
    interface Containable
    {
        List<Item> Items { get; set; }

        List<Item> GetItems();
    }
}
