using System;
using System.Linq;
using System.Windows.Forms;

namespace HeroesPrototype
{
    public static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main()
		{ // Test
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
            Application.Run(new HeroesPrototype());
		}
	}
}