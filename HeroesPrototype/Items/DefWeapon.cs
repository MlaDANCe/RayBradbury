using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.Items
{
    class DefWeapon : Weapon
    {
        public DefWeapon() : base("", new Geometry.Point2D(0, 0), 0, 0, 0) { }
    }
}
