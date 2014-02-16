using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroesPrototype
{
    public partial class HeroesPrototype : Form
    {
        private MainScene mScene;
        public HeroesPrototype()
        {
            InitializeComponent();
            // I use the namespace geometry here
            this.mScene = new MainScene(this.Scene.CreateGraphics(), new geometry.D2d(this.Scene.Width, this.Scene.Height));
            this.MainLoop.RunWorkerAsync();
        }

        private void Draw(object sender, RunWorkerCompletedEventArgs e)
        {
            mScene.Draw();
            this.MainLoop.RunWorkerAsync();
        }

        private void Update(object sender, DoWorkEventArgs e)
        {
            mScene.GameLoop();

            Thread.Sleep(100);
        }

        private void HandleMouse(object sender, MouseEventArgs e)
        {
           
        }

        private void HandleKeyboard(object sender, KeyEventArgs e)
        {
            mScene.KeyboardAction(e.KeyCode);
        }

        private void MouseAction(object sender, MouseEventArgs e)
        {
            mScene.MouseAction(e.X, e.Y, e.Button);
        }

    }
}
