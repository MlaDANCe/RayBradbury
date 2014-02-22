namespace HeroesPrototype
{
    partial class HeroesPrototype
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.MainLoop = new System.ComponentModel.BackgroundWorker();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.MenuButton = new System.Windows.Forms.MenuItem();
            this.ExitButton = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.Scene.SuspendLayout();
            this.SuspendLayout();
            // 
            // Scene
            // 
            this.Scene.Controls.Add(this.statusBar1);
            this.Scene.Location = new System.Drawing.Point(0, 0);
            this.Scene.Margin = new System.Windows.Forms.Padding(0);
            this.Scene.Name = "Scene";
            this.Scene.Size = new System.Drawing.Size(800, 600);
            this.Scene.TabIndex = 0;
            this.Scene.Paint += new System.Windows.Forms.PaintEventHandler(this.Scene_Paint);
            this.Scene.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseAction);
            // 
            // MainLoop
            // 
            this.MainLoop.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Update);
            this.MainLoop.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Draw);
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuButton});
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
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 578);
            this.statusBar1.Name = "StatusBar";
            this.statusBar1.Size = new System.Drawing.Size(800, 22);
            this.statusBar1.TabIndex = 0;
            this.statusBar1.Text = "Gold: " + 0 + "; Ore: " + 100 + "; Wood: " + 50 + "; Attack: " + 5+ "; Defence: "+ 4 + 
                ";                                                Month: "+ 1 
                + "; Week: " + 1 + " Day: " + 1;
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
            this.Text = "HeroesPrototype";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyboard);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouse);
            this.Scene.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Scene;
        private System.ComponentModel.BackgroundWorker MainLoop;
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem MenuButton;
        private System.Windows.Forms.MenuItem ExitButton;
        private System.Windows.Forms.StatusBar statusBar1;
    }
}

