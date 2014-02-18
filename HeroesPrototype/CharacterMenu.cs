using HeroesPrototype.geometry;
using HeroesPrototype.Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesPrototype
{
    public class CharacterMenu : Menu
    {
        private Menu sidebar;
        private Menu mainMenu;
        private List<Item> currentContent;
        private bool haveContent;
        public CharacterMenu(P2d p, D2d d) : base(p,d)
        {
            this.sidebar = new Menu(new P2d(50, 50), new D2d(100, this.S.H - 100));
            this.mainMenu = new Menu(new P2d(sidebar.P.X + sidebar.S.W + 50, 50),
                new D2d(base.S.W - sidebar.S.W - 150, this.S.H - 100));
            this.haveContent = false;
        }
        public void ClearContent()
        {
            this.currentContent = new List<Item>();
            this.haveContent = false;
        }
        public void AddContent(List<Item> content)
        {
            this.currentContent = content;
            this.haveContent = true;
        }
        public override System.Drawing.Bitmap GetMenu()
        {
            
            Bitmap menu = base.GetMenu();
            Graphics g = Graphics.FromImage(menu);
            if (this.haveContent)
            {
                Bitmap cont = this.DrawContent();
                g.DrawImage(cont, sidebar.P.X, sidebar.P.Y);
            }
            else
            {
                g.DrawImage(sidebar.GetMenu(), sidebar.P.X, sidebar.P.Y);
            }
            g.DrawImage(this.mainMenu.GetMenu(), mainMenu.P.X, mainMenu.P.Y);
            return menu;
        }

        private Bitmap DrawContent()
        {
            Bitmap cont = this.sidebar.GetMenu();
            Graphics g = Graphics.FromImage(cont);
            Font f = new Font("Arial", 12.0f);
            SolidBrush b = new SolidBrush(Color.Black);
            for (int i = 0; i < this.currentContent.Count; i++)
            {
                string name = string.Empty;
                if(this.currentContent[i] is Gold)
                {
                    name = "Gold";
                }
                string quantity = this.currentContent[i].Quantity.ToString();
                g.DrawString(name + " " + quantity, f, b, new Point(this.sidebar.P.X - 50, this.sidebar.P.Y - 50));
            }
            return cont;
        }
    }
}
