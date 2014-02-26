namespace HeroesPrototype
{
    
    partial class HeroesPrototype
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public bool TrainerVisibility { get; set; }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Scene = new System.Windows.Forms.Panel();
            this.ResoursesStats = new System.Windows.Forms.StatusStrip();
            this.Gold = new System.Windows.Forms.ToolStripStatusLabel();
            this.Wood = new System.Windows.Forms.ToolStripStatusLabel();
            this.Ore = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Attack = new System.Windows.Forms.ToolStripStatusLabel();
            this.Defence = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExperienceLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.LevelLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Month = new System.Windows.Forms.ToolStripStatusLabel();
            this.Week = new System.Windows.Forms.ToolStripStatusLabel();
            this.Day = new System.Windows.Forms.ToolStripStatusLabel();
            this.MovesLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainLoop = new System.ComponentModel.BackgroundWorker();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.MenuButton = new System.Windows.Forms.MenuItem();
            this.ExitButton = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.EndDay = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.BackgroundMusicSwitch = new System.Windows.Forms.MenuItem();
            this.menuItemTrainer = new System.Windows.Forms.MenuItem();
            this.menuItemRunTrainer = new System.Windows.Forms.MenuItem();
            this.Scene.SuspendLayout();
            this.ResoursesStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // Scene
            // 
            this.Scene.Controls.Add(this.ResoursesStats);
            this.Scene.Location = new System.Drawing.Point(0, 0);
            this.Scene.Margin = new System.Windows.Forms.Padding(0);
            this.Scene.Name = "Scene";
            this.Scene.Size = new System.Drawing.Size(800, 600);
            this.Scene.TabIndex = 0;
            this.Scene.Paint += new System.Windows.Forms.PaintEventHandler(this.Scene_Paint);
            this.Scene.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseAction);
            // 
            // ResoursesStats
            // 
            this.ResoursesStats.Enabled = false;
            this.ResoursesStats.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Gold,
            this.Wood,
            this.Ore,
            this.toolStripStatusLabel1,
            this.Attack,
            this.Defence,
            this.ExperienceLbl,
            this.LevelLabel,
            this.toolStripStatusLabel2,
            this.Month,
            this.Week,
            this.Day,
            this.MovesLbl});
            this.ResoursesStats.Location = new System.Drawing.Point(0, 576);
            this.ResoursesStats.Name = "ResoursesStats";
            this.ResoursesStats.Size = new System.Drawing.Size(800, 24);
            this.ResoursesStats.TabIndex = 1;
            this.ResoursesStats.Text = "statusStrip1";
            // 
            // Gold
            // 
            this.Gold.AccessibleName = "Gold";
            this.Gold.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Gold.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Gold.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.Gold.Enabled = false;
            this.Gold.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(42, 19);
            this.Gold.Text = "Gold: ";
            // 
            // Wood
            // 
            this.Wood.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Wood.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Wood.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.Wood.Enabled = false;
            this.Wood.Name = "Wood";
            this.Wood.Size = new System.Drawing.Size(49, 19);
            this.Wood.Text = "Wood: ";
            // 
            // Ore
            // 
            this.Ore.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Ore.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Ore.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.Ore.Enabled = false;
            this.Ore.Name = "Ore";
            this.Ore.Size = new System.Drawing.Size(36, 19);
            this.Ore.Text = "Ore: ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 19);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // Attack
            // 
            this.Attack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Attack.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Attack.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.Attack.Enabled = false;
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(51, 19);
            this.Attack.Text = "Attack: ";
            // 
            // Defence
            // 
            this.Defence.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Defence.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Defence.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.Defence.Enabled = false;
            this.Defence.Name = "Defence";
            this.Defence.Size = new System.Drawing.Size(60, 19);
            this.Defence.Text = "Defence: ";
            // 
            // ExperienceLbl
            // 
            this.ExperienceLbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ExperienceLbl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ExperienceLbl.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.ExperienceLbl.Enabled = false;
            this.ExperienceLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExperienceLbl.Name = "ExperienceLbl";
            this.ExperienceLbl.Size = new System.Drawing.Size(31, 19);
            this.ExperienceLbl.Text = "XP: ";
            // 
            // LevelLabel
            // 
            this.LevelLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LevelLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.LevelLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.LevelLabel.Enabled = false;
            this.LevelLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(41, 19);
            this.LevelLabel.Text = "Level:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 19);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // Month
            // 
            this.Month.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Month.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Month.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.Month.Enabled = false;
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(53, 19);
            this.Month.Text = "Month: ";
            // 
            // Week
            // 
            this.Week.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Week.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Week.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.Week.Enabled = false;
            this.Week.Name = "Week";
            this.Week.Size = new System.Drawing.Size(40, 19);
            this.Week.Text = "Week";
            // 
            // Day
            // 
            this.Day.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Day.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Day.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.Day.Enabled = false;
            this.Day.Name = "Day";
            this.Day.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Day.Size = new System.Drawing.Size(37, 19);
            this.Day.Text = "Day: ";
            this.Day.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MovesLbl
            // 
            this.MovesLbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MovesLbl.Enabled = false;
            this.MovesLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MovesLbl.Name = "MovesLbl";
            this.MovesLbl.Size = new System.Drawing.Size(42, 19);
            this.MovesLbl.Text = "Moves";
            // 
            // MainLoop
            // 
            this.MainLoop.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Update);
            this.MainLoop.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Draw);
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuButton,
            this.menuItem1,
            this.menuItem2,
            this.menuItemTrainer});
            // 
            // MenuButton
            // 
            this.MenuButton.Index = 0;
            this.MenuButton.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ExitButton});
            this.MenuButton.Text = "Menu";
            // 
            // ExitButton
            // 
            this.ExitButton.Index = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.EndDay});
            this.menuItem1.Text = "End Day";
            // 
            // EndDay
            // 
            this.EndDay.Index = 0;
            this.EndDay.Text = "End Day";
            this.EndDay.Click += new System.EventHandler(this.EndDay_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.BackgroundMusicSwitch});
            this.menuItem2.Text = "Music";
            // 
            // BackgroundMusicSwitch
            // 
            this.BackgroundMusicSwitch.Index = 0;
            this.BackgroundMusicSwitch.Shortcut = System.Windows.Forms.Shortcut.CtrlM;
            this.BackgroundMusicSwitch.Text = "Background music Off";
            this.BackgroundMusicSwitch.Click += new System.EventHandler(this.BackgroundMusicSwitch_Click);
            // 
            // menuItemTrainer
            // 
            this.menuItemTrainer.Index = 3;
            this.menuItemTrainer.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemRunTrainer});
            this.menuItemTrainer.Text = "Trainer";
            this.menuItemTrainer.Visible = false;
            // 
            // menuItemRunTrainer
            // 
            this.menuItemRunTrainer.Index = 0;
            this.menuItemRunTrainer.Shortcut = System.Windows.Forms.Shortcut.CtrlT;
            this.menuItemRunTrainer.Text = "Run Trainer";
            this.menuItemRunTrainer.Click += new System.EventHandler(this.menuItemRunTrainer_Click);
            // 
            // HeroesPrototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.Scene);
            this.Menu = this.MainMenu;
            this.Name = "HeroesPrototype";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeroesPrototype";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyboard);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouse);
            this.Scene.ResumeLayout(false);
            this.Scene.PerformLayout();
            this.ResoursesStats.ResumeLayout(false);
            this.ResoursesStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Scene;
        private System.ComponentModel.BackgroundWorker MainLoop;
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem MenuButton;
        private System.Windows.Forms.MenuItem ExitButton;
        private System.Windows.Forms.StatusStrip ResoursesStats;
        private System.Windows.Forms.ToolStripStatusLabel Gold;
        private System.Windows.Forms.ToolStripStatusLabel Wood;
        private System.Windows.Forms.ToolStripStatusLabel Ore;
        private System.Windows.Forms.ToolStripStatusLabel Attack;
        private System.Windows.Forms.ToolStripStatusLabel Defence;
        private System.Windows.Forms.ToolStripStatusLabel Month;
        private System.Windows.Forms.ToolStripStatusLabel Week;
        private System.Windows.Forms.ToolStripStatusLabel Day;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem EndDay;
        private System.Windows.Forms.ToolStripStatusLabel MovesLbl;
        private System.Windows.Forms.ToolStripStatusLabel ExperienceLbl;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem BackgroundMusicSwitch;
        private System.Windows.Forms.MenuItem menuItemRunTrainer;
        public System.Windows.Forms.MenuItem menuItemTrainer;
		private System.Windows.Forms.ToolStripStatusLabel LevelLabel;
    }
}

