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
        public const int ScreenToMapUnits = 50;
        private Bitmap buff;
        private Graphics buffG;

        public MainScene(Graphics panelGraphics, D2d sceneSize)
        {
            this.scene = panelGraphics;
            this.sceneDimension = sceneSize;
            this.currentLevel = new Level(this.sceneDimension);
            this.buff = new Bitmap(this.sceneDimension.W, this.sceneDimension.H);
            this.buffG = Graphics.FromImage(this.buff);
        }

        internal void Draw()
        {
            this.scene.DrawImage(buff, new Point(0, 0)); // Here we draw the buffer over the screen
        }

        internal void GameLoop()
        {
            this.buffG.DrawImage(this.currentLevel.GetSprite(), this.currentLevel.P.X, this.currentLevel.P.Y); // Here we draw over the buffer
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
            if (keys == Keys.Tab)
            {
                List<Item> cItems = currentLevel.GetCharacterItems();
            }
            if (keys == Keys.E)
            {
                if (currentLevel.HaveContainableObjects())
                {
                    List<Item> containement = currentLevel.GetContent();
                }
            }
            this.currentLevel.MovePlayer(dxdy);

        }
    }
}
