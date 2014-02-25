using System;
using System.Linq;
using System.Windows.Forms;

namespace HeroesPrototype
{
   
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{ // Test
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new HeroesPrototype());
		}
	}
}