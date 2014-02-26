using HeroesPrototype.CharacterAssets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HeroesPrototype
{
    public partial class BuyMenu : Form
    {
        CharacterBase charac;
        public BuyMenu(CharacterBase charac)
        {
            InitializeComponent();
            this.charac = charac;
        }

        public void AddItems(List<Unit> units)
        {
            foreach (var unit in units)
            {
                this.listBox1.Items.Add(unit);
            }
            this.listBox1.SelectedItem = this.listBox1.Items[0];
        }

        private void AddToHero(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count > 0)
            {
                var current = this.listBox1.SelectedItem as Unit;
                if (this.charac.Gold < current.Price)
                {
                    MessageBox.Show("You don't have enough gold.");
                }
                else
                {
                    this.charac.Units.Add(current);
                    this.charac.Gold -= (int)current.Price;
                    this.listBox1.Items.Remove(current);
                    if (this.listBox1.Items.Count > 0)
                    {
                        this.listBox1.SelectedItem = this.listBox1.Items[0];
                    }
                }
            }
            else
            {
                MessageBox.Show("Nothing to buy");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
