using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace HeroesPrototype
{
	public partial class HeroesPrototype : Form
	{
		private MainScene scene;

		public HeroesPrototype()
		{
			this.InitializeComponent();
			this.scene = new MainScene(this.Scene.CreateGraphics(), new Geometry.Size2D(this.Scene.Width, this.Scene.Height));
			this.MainLoop.RunWorkerAsync();
		}

		private void Draw(object sender, RunWorkerCompletedEventArgs e)
		{
			this.scene.Draw();
			this.MainLoop.RunWorkerAsync();
		}

		private void Update(object sender, DoWorkEventArgs e)
		{
			this.scene.GameLoop();

			Thread.Sleep(50);
		}

		private void HandleMouse(object sender, MouseEventArgs e)
		{
		}

		private void HandleKeyboard(object sender, KeyEventArgs e)
		{
			this.scene.KeyboardAction(e.KeyCode);
		}

		private void MouseAction(object sender, MouseEventArgs e)
		{
			this.scene.MouseAction(e.X, e.Y, e.Button);
		}

		private void Scene_Paint(object sender, PaintEventArgs e)
		{
		}
	}
}