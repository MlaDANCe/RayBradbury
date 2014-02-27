using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HeroesPrototype.CharacterAssets;
using HeroesPrototype.Geometry;
using HeroesPrototype.Items;
using HeroesPrototype.MapObjects;
using System.Text.RegularExpressions;

namespace HeroesPrototype
{
    /// <summary>
    /// This class wraps the functionality provided by
    /// background worker and have instance of panel
    /// graphics ( passed in the constructor )
    /// </summary>
    public class MainScene
    {
        public const string LostBattleSoundAddres = @"..\..\WAVs\41-defeated-in-combat.wav";
        public const string WonBattleSoundAddres = @"..\..\WAVs\40-win-combat.wav";
        public const int ScreenToMapUnits = 50;
        private readonly Graphics scene;
        private readonly Size2D sceneDimension;
        private Level currentLevel;
        private MainCharacter mainCharacter;
        private readonly Bitmap buff;
        private readonly Graphics buffG;

        private Calendar calend;
        private System.Media.SoundPlayer BattleSounds = new System.Media.SoundPlayer();

        public MainScene(Graphics panelGraphics, Size2D sceneSize)
        {

            this.scene = panelGraphics;

            this.sceneDimension = sceneSize;

            this.CurrentLevel = new Level(this.sceneDimension);

            this.mainCharacter = new MainCharacter(currentLevel.StartPosition,
                new Point2D(this.sceneDimension.Width / 2, this.sceneDimension.Height / 2));

            this.buff = new Bitmap(this.sceneDimension.Width, this.sceneDimension.Height);
            this.buffG = Graphics.FromImage(this.buff);
            this.calend = new Calendar();
            this.MainCharacter.Moves = MainCharacter.MaxMoves;

        }


        public Level CurrentLevel
        {
            get
            {
                return this.currentLevel;
            }
            set
            {
                this.currentLevel = value;
            }
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

        public Calendar Calend //returns the calendar object for days passed in the gmae
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
            else
            {
                if (keys == Keys.Up || keys == Keys.Down || keys == Keys.Left || keys == Keys.Right)
                {
                    MessageBox.Show("You don't have more moves for the day, please end the day!");
                }
            }
            if (keys == Keys.End)
            {
                this.Calend.Day++;
                this.MainCharacter.Moves = MainCharacter.MaxMoves;
                if (Calend.Day % 28 == 0)
                {
                    MessageBox.Show("The sun rises, a new month begins and new population is born! You receive +25% of your gold! ");
                    MainCharacter.Gold += MainCharacter.Gold * 25 / 100;
                }
                else if (Calend.Day % 7 == 0)
                {
                    MessageBox.Show("The sun rises, a new week begins and new population is born! You receive +15% of your gold! ");
                    MainCharacter.Gold += MainCharacter.Gold * 15 / 100;
                }
                else
                {
                    MessageBox.Show("The sun rises and a new day begins!");
                }
            }

        }

        private void MovePosition(Point2D dxdy)//moves player to the given point
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
                    IDrawable obj = currentLevel.GetObject(newPlPos);
                    if (obj != null)
                    {
                        if (obj is IBattle)//battle here
                        {
                            BattleMethod(ref newPlPos, obj);
                            // return;
                        }

                        else if (obj is Spawnable)
                        {
                            OpenSpawnMenu(obj);
                        }
                        else if (obj is Item)
                        {
                            AddToHero(obj);
                        }
                        if ((obj as Castle) != null)
                        {
                            if (!(obj as Castle).IsSpawnable)
                            {
                                if (mainCharacter.Level >= 20)
                                {
                                    // MessageBox.Show("Final battle, you will win or die against the army of Mordor!");
                                    DialogResult dialogResult = MessageBox.Show(
                                        "Final battle, you will win or die against the army of Mordor! Are you sure you want to battle?",
                                        "Boss Battle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        System.Media.SoundPlayer VictorySounds = new System.Media.SoundPlayer(@"..\..\WAVs\06-stronghold-towns.wav");// tyk trqbva da slojish adresa na WIN CAMPAIGN i vsi4ko raboti 

                                        VictorySounds.Play();
                                        MessageBox.Show("VICTORY!");
                                        
                                        Application.Exit();
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("You need to be at least level 20 to be able to defeat your enemy!");
                                }
                            }
                        }


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

        private void BattleMethod(ref Point2D newPlPos, IDrawable obj)//method used to engage in battle and place the hero on the apropriate position after the battle
        {

            Unit unit = obj as Unit;
            if (unit != null)
            {
                int battlePowerEnemy = unit.Attack * unit.Quantity;
                int defPowerEnemy = unit.Defence * unit.Health * unit.Quantity;
                int heroPower = mainCharacter.AttackPower();
                int heroDefense = mainCharacter.DefensePower();

                string unitType = unit.GetType().ToString();
                unitType = unitType.Substring(unitType.LastIndexOf(".") + 1);

                DialogResult dialogResult = MessageBox.Show(
                    "Danger! " + unit.Quantity + " " + unitType + " !" +
                    "\nEnemy Attack: " + battlePowerEnemy + ";  Enemy Defense: " + defPowerEnemy + "!" +
                    "\nHero Attack: " + mainCharacter.AttackPower().ToString() + ";  Hero Defense: " +
                    mainCharacter.DefensePower().ToString() + "!" + "\n Are you sure you want to battle?",
                     "Battle stats", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (heroDefense / battlePowerEnemy >= defPowerEnemy / heroPower)
                    {
                        this.BattleSounds.SoundLocation = WonBattleSoundAddres;
                        BattleSounds.Play();
                        int pillage = (int)battlePowerEnemy / 7 * 10;
                        mainCharacter.Gold += pillage;
                        MessageBox.Show(String.Format("You have won the battle!\n You have earned {0} goooold and {0} experience!", pillage));
                        mainCharacter.Experience += pillage;
                        if (obj as Castle == null)
                        {
                            currentLevel.SetReplacedTerrain(newPlPos);
                        }
                        HeroesPrototype.Sounds.PlayLooping();
                    }
                    else
                    {
                        this.BattleSounds.SoundLocation = LostBattleSoundAddres;

                        BattleSounds.Play();

                        int pillage = (int)battlePowerEnemy / 7 * 10;

                        if (mainCharacter.Gold <= pillage)
                        {
                            mainCharacter.Gold = 0;
                        }
                        else
                        {
                            mainCharacter.Gold -= pillage;
                        }

                        int lossUnits = 100 - 100 * (heroDefense / battlePowerEnemy) / (defPowerEnemy / heroPower);
                        int c = mainCharacter.Units.Sum(item => item.Quantity) * lossUnits / 100;
                        int count = 0;
                        while (count < c && count < mainCharacter.Units.Count)
                        {
                            mainCharacter.Units.RemoveAt(count);
                            c++;
                        }
                        MessageBox.Show(String.Format("You have lost the battle!\n You have lost {0} goooold and {1}% of your units", pillage, lossUnits));
                        HeroesPrototype.Sounds.PlayLooping();
                        this.mainCharacter.WorldPosition = currentLevel.PlayerInitPosit;
                        this.MainCharacter.Moves = 0;
                        currentLevel.InitialiseMap();
                        currentLevel.SetNotUpToDate();
                    }
                }
            }

        }

        private void OpenSpawnMenu(IDrawable obj)
        {
            var spwn = obj as Spawnable;
            if (spwn.IsSpawnable)
            {
                var units = spwn.BuyUnits((int)this.mainCharacter.Gold);
                BuyMenu m = new BuyMenu(this.mainCharacter);
                m.AddItems(units);
                m.Visible = true;
                m.Activate();

            }
        }

        private void AddToHero(IDrawable obj)
        {
            Item itm = obj as Item;
            if (itm is Gold)
            {
                MessageBox.Show("You received " + itm.GoldQuantity + " Gold!");
                this.MainCharacter.Gold += (int)itm.GoldQuantity;
            }
            else if (itm is Ore)
            {
                MessageBox.Show("You received " + itm.GoldQuantity + " Ore!");
                this.MainCharacter.Ore += (int)itm.GoldQuantity;
            }
            else if (itm is Wood)
            {
                MessageBox.Show("You received " + itm.GoldQuantity + " Wood!");
                this.MainCharacter.Wood += (int)itm.GoldQuantity;
            }
            else if (itm is CampFire)
            {
                string woodOrOre;
                if ((int)itm.WoodQuantity > (int)itm.OreQuantity)
                {
                    woodOrOre = "Wood";
                }
                else
                {
                    woodOrOre = "Ore";
                }
                MessageBox.Show("You received " + itm.GoldQuantity + " Gold and 5 " + woodOrOre);
                this.MainCharacter.Gold += (int)itm.GoldQuantity;
                this.MainCharacter.Wood += (int)itm.WoodQuantity;
                this.MainCharacter.Ore += (int)itm.OreQuantity;
            }
            else if (itm is TreasureChest)
            {
                MessageBox.Show("You received " + itm.GoldQuantity + " Gold and " + itm.ExperienceQuantity + " Experience!");
                this.MainCharacter.Gold += itm.GoldQuantity;
                this.MainCharacter.Experience += itm.ExperienceQuantity;
            }
            this.mainCharacter.AddItem(itm);
        }


    }
}
