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
            this.Scene = new System.Windows.Forms.Panel();
            this.MainLoop = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Scene
            // 
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
            // HeroesPrototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.Scene);
            this.Name = "HeroesPrototype";
            this.Text = "HeroesPrototype";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyboard);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouse);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Scene;
        private System.ComponentModel.BackgroundWorker MainLoop;
    }
}

