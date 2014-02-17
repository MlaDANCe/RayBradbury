using HeroesPrototype.geometry;
using HeroesPrototype.mapConsts;
using HeroesPrototype.MapObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HeroesPrototype
{
    /// <summary>
    /// This class wraps the functionality provided by
    /// background worker and have instance of panel
    /// graphics ( passed in the constructor )
    /// </summary>
    /// 
    public class MainScene
    {
        private Graphics scene;

        private D2d sceneDimension;

        private Level currentLevel;
        private Character mainCharacter;

        public const int ScreenToMapUnits = 50;

        private Bitmap buff;
        private Graphics buffG;

        public MainScene(Graphics panelGraphics, D2d sceneSize)
        {
            this.scene = panelGraphics;

            this.sceneDimension = sceneSize;

            this.currentLevel = new Level(this.sceneDimension);

            this.mainCharacter = new Character(new P2d(currentLevel.mapSize.W / 2, currentLevel.mapSize.W / 2), 
                new P2d(this.sceneDimension.W / 2, this.sceneDimension.H / 2));

            this.buff = new Bitmap(this.sceneDimension.W, this.sceneDimension.H);
            this.buffG = Graphics.FromImage(this.buff);
        }

        internal void Draw()
        {
            this.scene.DrawImage(buff, new Point(0, 0)); // Here we draw the buffer on the screen
        }

        internal void GameLoop()
        {
            this.buffG.DrawImage(this.currentLevel.GetSprite(), this.currentLevel.P.X, this.currentLevel.P.Y); // Here we draw the map on the buffer
            this.buffG.DrawImage(this.mainCharacter.GetSprite(), this.mainCharacter.P.X, this.mainCharacter.P.Y); // Here we draw the character on the buffer
        }

        internal void MouseAction(int x, int y, MouseButtons mouseButtons)
        {

        }

        internal void KeyboardAction(Keys keys)
        {

            P2d dxdy = new P2d(0, 0);
            if (keys == Keys.Up)
            {
                dxdy.Y -= 1;
            }
            else if (keys == Keys.Down)
            {
                dxdy.Y += 1;
            }
            else if (keys == Keys.Left)
            {
                dxdy.X -= 1;
            }
            else if (keys == Keys.Right)
            {
                dxdy.X += 1;
            }
            MovePosition(dxdy);
        }

        private void MovePosition(P2d dxdy)
        {
            P2d newPlPos = this.mainCharacter.WP + dxdy;
            if(newPlPos.X >= 0 && newPlPos.X < this.currentLevel.mapSize.W &&
                newPlPos.Y >= 0 && newPlPos.Y < this.currentLevel.mapSize.H)
            {
                Rec newVis = currentLevel.visSpace + dxdy;
                if(newVis.L>= 0 && newVis.R <= currentLevel.mapSize.W
                    && newVis.T >= 0 && newVis.B < currentLevel.mapSize.H)
                {
                    if(!currentLevel.IsPositionOccupied(newPlPos))
                    {
                        mainCharacter.MoveTo(newPlPos);
                        currentLevel.visSpace = newVis;
                    }
                }
            }
        }
    }
}
