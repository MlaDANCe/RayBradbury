using HeroesPrototype.geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesPrototype.mapConsts;

namespace HeroesPrototype.Items
{
    public class Item:Drawable//,IDisappearing//can create a list of items in hero to store all the items
    {
        public string  Name { get; set; }
        public int quantity=1;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

       
        //public Bitmap CurrentSprite { get; set; }
         protected Item(string name)
         {
             Name = name;
         }

         public P2d P { get; set; }
         public D2d S { get; private set; }

         Bitmap Drawable.GetSprite()
         {

             return (Bitmap)(typeof(Objects)
                    .GetField(Name)
                    .GetValue(null));//method that shoud be inherited
         }

    }

}
