using System;
using System.Drawing;
using System.Windows.Forms;
using HeroesPrototype.CharacterAssets;
using HeroesPrototype.Geometry;
using HeroesPrototype.Items;

namespace HeroesPrototype
{
    /// <summary>
    /// This class wraps the functionality provided by
    /// background worker and have instance of panel
    /// graphics ( passed in the constructor )
    /// </summary>
    public class MainScene
    {
        public const int ScreenToMapUnits = 50;

        private readonly Graphics scene;

        private readonly Size2D sceneDimension;

        private readonly Level currentLevel;
        private MainCharacter mainCharacter;

        private readonly Bitmap buff;
        private readonly Graphics buffG;

        private Calendar calend;

        public MainScene(Graphics panelGraphics, Size2D sceneSize)
        {
            this.scene = panelGraphics;

            this.sceneDimension = sceneSize;

            this.currentLevel = new Level(this.sceneDimension);

            this.mainCharacter = new MainCharacter(new Point2D(this.currentLevel.MapSize.Width / 2, this.currentLevel.MapSize.Width / 2),
                new Point2D(this.sceneDimension.Width / 2, this.sceneDimension.Height / 2));

            this.buff = new Bitmap(this.sceneDimension.Width, this.sceneDimension.Height);
            this.buffG = Graphics.FromImage(this.buff);
            this.calend = new Calendar();
            this.MainCharacter.Moves = MainCharacter.MaxMoves;

        }


        public MainCharacter MainCharacter
        {
            get
            {
                return this.mainCharacter;
            }
            set
            {
                this.mainCharacter = value;
            }
        }

        public Calendar Calend
        {
            get
            {
                return this.calend;
            }
            set
            {
                this.calend = value;
            }
        }

        internal void Draw()
        {
            this.scene.DrawImage(this.buff, new Point(0, 0)); // Here we draw the buffer on the screen
        }

        internal void GameLoop()
        {
            this.buffG.DrawImage(this.currentLevel.GetSprite(), this.currentLevel.Origin.X, this.currentLevel.Origin.Y); // Here we draw the map on the buffer
            this.buffG.DrawImage(this.mainCharacter.GetSprite(), this.mainCharacter.ScreenCoordinates.X, this.mainCharacter.ScreenCoordinates.Y); // Here we draw the character on the buffer
        }

        internal void MouseAction(int x, int y, MouseButtons mouseButtons)
        {
        }

        internal void KeyboardAction(Keys keys)
        {
            if (this.MainCharacter.Moves > 0)
            {
                Point2D dxdy = new Point2D(0, 0);
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
                this.MovePosition(dxdy);
            }

        }

        private void MovePosition(Point2D dxdy)
        {
            Point2D newPlPos = this.mainCharacter.WorldPosition + dxdy;
            if (newPlPos.X >= 0 && newPlPos.X < this.currentLevel.MapSize.Width &&
                newPlPos.Y >= 0 && newPlPos.Y < this.currentLevel.MapSize.Height)
            {
                Rectangle2D newVis = this.currentLevel.VisibleSpace + dxdy;
                if (newVis.Left >= 0 &&
                    newVis.Right <= this.currentLevel.MapSize.Width &&
                    newVis.Top >= 0 &&
                    newVis.Bottom < this.currentLevel.MapSize.Height)
                {
                    Item itm = currentLevel.GetItem(newPlPos);
                    if (itm != null)
                    {
                        if (itm is Gold)
                        {
                            this.MainCharacter.Gold += (uint)itm.Quantity;
                            MessageBox.Show("You received " + itm.Quantity+" Gold!");
                        }
                        this.mainCharacter.AddItem(itm);
                    }
                    if (!this.currentLevel.IsPositionOccupied(newPlPos))
                    {
                        this.mainCharacter.MoveTo(newPlPos);
                        this.currentLevel.VisibleSpace = newVis;
                        this.currentLevel.SetNotUpToDate();
                        this.MainCharacter.Moves--;
                    }
                }
            }
        }
    }
}
