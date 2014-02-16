using HeroesPrototype.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype
{
    class Gold : Item
    {
        public Gold()
        {
            base.Quantity = (new Random()).Next(1, 50);
        }
    }
}
