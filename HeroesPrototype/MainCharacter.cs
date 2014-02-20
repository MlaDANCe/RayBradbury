using HeroesPrototype.geometry;
using HeroesPrototype.Items;
using HeroesPrototype.MapObjects;
using HeroesPrototype.character;
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
        private int currentCharacterStage;
        private Position pos;
        public MainCharacter(P2d worldPosition, P2d screenCoords)
        {
            this.WP = worldPosition;
            this.P = screenCoords;
            this.currentSprite = character.CharacterSprites.characRight[currentCharacterStage];
            this.currentCharacterStage = 0;
            this.pos = Position.Right;
        }
        public void MoveTo(P2d p)
        {
            int dx = p.X - this.WP.X;
            int dy = p.Y - this.WP.Y;
            if(dx>0)
            {
                if(this.pos!=Position.Right)
                {
                    this.pos = Position.Right;
                    this.currentCharacterStage = 0;
                }
                else
                {
                    this.currentCharacterStage += 1;
                    if(this.currentCharacterStage >= CharacterSprites.characRight.Length)
                    {
                        this.currentCharacterStage = 0;
                    }
                }
                this.currentSprite = character.CharacterSprites.characRight[currentCharacterStage];
            }
            if(dx < 0)
            {
                if (this.pos != Position.Left)
                {
                    this.pos = Position.Left;
                    this.currentCharacterStage = 0;
                }
                else
                {
                    this.currentCharacterStage += 1;
                    if (this.currentCharacterStage >= CharacterSprites.characLeft.Length)
                    {
                        this.currentCharacterStage = 0;
                    }
                }
                this.currentSprite = character.CharacterSprites.characLeft[currentCharacterStage];
            }
            if(dy < 0)
            {
                if (this.pos != Position.Top)
                {
                    this.pos = Position.Top;
                    this.currentCharacterStage = 0;
                }
                else
                {
                    this.currentCharacterStage += 1;
                    if (this.currentCharacterStage >= CharacterSprites.characTop.Length)
                    {
                        this.currentCharacterStage = 0;
                    }
                }
                this.currentSprite = character.CharacterSprites.characTop[currentCharacterStage];
            }
            if(dy > 0)
            {
                if (this.pos != Position.Bottom)
                {
                    this.pos = Position.Bottom;
                    this.currentCharacterStage = 0;
                }
                else
                {
                    this.currentCharacterStage += 1;
                    if (this.currentCharacterStage >= CharacterSprites.characBottom.Length)
                    {
                        this.currentCharacterStage = 0;
                    }
                }
                this.currentSprite = character.CharacterSprites.characBottom[currentCharacterStage];
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
