using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesPrototype.MapObjects
{
    interface Spawnable
    {
        bool IsSpawnable { get; set; }

        List<Unit> UnitsSpawned {  get;  set; }

        List<Unit> BuyUnits(int gold);
    }
}
