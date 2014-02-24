﻿using HeroesPrototype.Units;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroesPrototype
{
    public partial class BuyMenu : Form
    {
        public BuyMenu()
        {
            InitializeComponent();
        }

        public void AddItems(List<Unit> units)
        {
            this.listBox1.Items.Add(units[0].Name);
        }
    }
}