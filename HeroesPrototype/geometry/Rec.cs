using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype.geometry
{
    public class Rec
    {
        public int L { get; set; }
        public int R { get; set; }
        public int T { get; set; }
        public int B { get; set; }

        public Rec(P2d ul, D2d wh)
        {
            this.L = ul.X;
            this.R = ul.X + wh.W;
            this.T = ul.Y;
            this.B = ul.Y + wh.H;
        }
        public Rec()
        {}
        public static Rec operator+(Rec a, P2d p)
        {
            Rec b = new Rec();
            b.L = a.L + p.X;
            b.R = a.R + p.X;
            b.T = a.T + p.Y;
            b.B = a.B + p.Y;
            return b;
        }
        public static Rec operator-(Rec a, P2d p)
        {
            Rec b = new Rec();
            b.L = a.L - p.X;
            b.R = a.R - p.X;
            b.T = a.T - p.Y;
            b.B = a.B - p.Y;
            return b;
        }
    }
}
