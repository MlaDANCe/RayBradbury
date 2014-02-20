using System;
using System.Drawing;
using System.Linq;

namespace HeroesPrototype.CharacterAssets
{
	public static class CharacterSprites
	{
		public static readonly Bitmap[] CharacterLeft = new Bitmap[]
		{
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s1_l.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s2_l.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s3_l.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s4_l.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s5_l.png"))
		};

		public static readonly Bitmap[] CharacterRight = new Bitmap[]
		{
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s1_r.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s2_r.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s3_r.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s4_r.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s5_r.png"))
		};

		public static readonly Bitmap[] CharacterTop = new Bitmap[]
		{
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s1_u.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s2_u.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s3_u.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s4_u.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s5_u.png"))
		};

		public static readonly Bitmap[] CharacterBottom = new Bitmap[]
		{
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s1_b.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s2_b.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s3_b.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s4_b.png")),
			new Bitmap(Bitmap.FromFile(@"..\..\sprites\charac\Heroes\keroez_s5_b.png"))
		};
	}
}