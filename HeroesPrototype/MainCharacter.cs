using HeroesPrototype.geometry;
using HeroesPrototype.Items;
using HeroesPrototype.MapObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype
{
    public class MainCharacter : Character
    {

        public P2d WP
        {
            get;
            set;
        }

        Bitmap currentSprite;
        public MainCharacter(P2d worldPosition, P2d screenCoords)
        {
            this.WP = worldPosition;
            this.P = screenCoords;
            this.currentSprite = character.CharacterSprites.charac_left;
        }
        public void MoveTo(P2d p)
        {
            int dx = p.X - this.WP.X;
            int dy = p.Y - this.WP.Y;
            if(dx>0)
            {
                this.currentSprite = character.CharacterSprites.charac_right;
            }
            if(dx < 0)
            {
                this.currentSprite = character.CharacterSprites.charac_left;
            }
            if(dy < 0)
            {
                this.currentSprite = character.CharacterSprites.charac_top;
            }
            if(dy > 0)
            {
                this.currentSprite = character.CharacterSprites.charac_bottom;
            }
            this.WP = p;
        }
        public P2d P
        {
            get;
            set;
        }
        public D2d S
        {
            get { throw new NotImplementedException(); }
        }

        public override Bitmap GetSprite()
        {
            return this.currentSprite;
        }
        
        public List<Item> Items { get; set; }


        public List<Item> GetItems()
        {
            return this.Items;
        }
    }
}
