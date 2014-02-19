using HeroesPrototype.geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesPrototype.mapConsts;

namespace HeroesPrototype.Units
{
    public abstract class UnitLevel1 : Unit
    {
        public UnitLevel1(string name, int attack, int defence, int health)
            : base(name, attack, defence, health)
        {
        }
    }
}
