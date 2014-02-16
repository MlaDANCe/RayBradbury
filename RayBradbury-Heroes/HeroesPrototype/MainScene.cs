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
        private bool inGame;
        private bool inMenu;
        private CharacterMenu cm;
        public MainScene(Graphics panelGraphics, D2d sceneSize)
        {
            this.scene = panelGraphics;
            this.sceneDimension = sceneSize;
            this.currentLevel = new Level(this.sceneDimension);
            this.inGame = true;
            this.inMenu = false;
            cm = new CharacterMenu(new P2d(100, 100), new D2d(600, 400));
        }

        internal void Draw()
        {
            if (this.inGame)
            {
                this.scene.DrawImage(this.currentLevel.GetSprite(), this.currentLevel.P.X, this.currentLevel.P.Y);
            }
            else if(this.inMenu)
            {
                this.scene.DrawImage(this.cm.GetMenu(), this.cm.P.X, this.cm.P.Y);
            }
        }

        internal void GameLoop()
        {
            
        }

        internal void MouseAction(int x, int y, MouseButtons mouseButtons)
        {
            
        }

        internal void KeyboardAction(Keys keys)
        {
            if (this.inGame)
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
                    this.inGame = false;
                    this.inMenu = true;
                }
                if(keys == Keys.E)
                {
                    if(currentLevel.HaveContainableObjects())
                    {
                        List<Item> containement = currentLevel.GetContent();
                        this.cm.AddContent(containement);
                        this.inGame = false;
                        this.inMenu = true;
                    }
                }
                this.currentLevel.MovePlayer(dxdy);
            }
            else if (this.inMenu)
            {
                if(keys == Keys.Tab)
                {
                    this.inMenu = false;
                    this.inGame = true;
                    this.cm.ClearContent();
                }
            }
        }
    }
}
