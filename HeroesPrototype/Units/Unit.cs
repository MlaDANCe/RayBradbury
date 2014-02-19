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
    public abstract class Unit : Drawable //,IDisappearing //can create a list of items in hero to store all the items
    {
        public string Name { get; set; }
        public int attack;
        public int defence;
        public int health;

        public int Attack
        {
            get { return this.attack; }
            set { this.attack = value; }
        }

        public int Defence
        {
            get { return this.defence; }
            set { this.defence = value; }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        
        //public Bitmap CurrentSprite { get; set; }
        public Unit(string name, int attack, int defence, int health)
        {
            this.Name = name;
            this.Attack = attack;
            this.Defence = defence;
            this.Health = health;
        }

        public P2d P { get; set; }
        public D2d S { get; private set; }

        Bitmap Drawable.GetSprite()
        {

            return (Bitmap)(typeof(Objects)
                   .GetField(Name)
                  .GetValue(null)); //method that shoud be inherited
        }
    }
}
