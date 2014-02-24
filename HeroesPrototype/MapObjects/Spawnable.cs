using HeroesPrototype.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.MapObjects
{
    interface Spawnable
    {
        bool IsSpawnable { get; set; }

        List<Unit> UnitsSpawned {  get;  set; }

        List<Unit> BuyUnits(int gold);
    }
}
