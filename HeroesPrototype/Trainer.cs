namespace HeroesPrototype
{
    using System;
    using System.Windows.Forms;

    public partial class Trainer : Form
    {
        private MainScene mainScene;

        public Trainer(MainScene mainScene)
        {
            this.InitializeComponent();
            this.mainScene = mainScene;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number = 0;
            int uintNum = 0;
            if (int.TryParse(txtDefence.Text, out number)) this.mainScene.MainCharacter.Defense += number;
            if (int.TryParse(TxtAttack.Text, out number)) this.mainScene.MainCharacter.Attack += number;
            if (int.TryParse(txtGold.Text, out uintNum)) this.mainScene.MainCharacter.Gold += uintNum;
            if (int.TryParse(txtWood.Text, out uintNum)) this.mainScene.MainCharacter.Wood += uintNum;
            if (int.TryParse(txtOre.Text, out uintNum)) this.mainScene.MainCharacter.Ore += uintNum;
            if (int.TryParse(txtMoves.Text, out number)) this.mainScene.MainCharacter.Moves += number;
            if (int.TryParse(txtMaxMoves.Text, out number)) this.mainScene.MainCharacter.MaxMoves += number;
            if (int.TryParse(txtXp.Text, out uintNum)) this.mainScene.MainCharacter.Experience += uintNum;
        }

        private void btnChangeTo_Click(object sender, EventArgs e)
        {
            int number = 0;
            int uintNum = 0;
            if (int.TryParse(txtDefence.Text, out number)) this.mainScene.MainCharacter.Defense = number;
            if (int.TryParse(TxtAttack.Text, out number)) this.mainScene.MainCharacter.Attack = number;
            if (int.TryParse(txtGold.Text, out uintNum)) this.mainScene.MainCharacter.Gold = uintNum;
            if (int.TryParse(txtWood.Text, out uintNum)) this.mainScene.MainCharacter.Wood = uintNum;
            if (int.TryParse(txtOre.Text, out uintNum)) this.mainScene.MainCharacter.Ore = uintNum;
            if (int.TryParse(txtMoves.Text, out number)) this.mainScene.MainCharacter.Moves = number;
            if (int.TryParse(txtMaxMoves.Text, out number)) this.mainScene.MainCharacter.MaxMoves = number;
            if (int.TryParse(txtXp.Text, out uintNum)) this.mainScene.MainCharacter.Experience = uintNum;
        }

        private void btnClearTxt_Click(object sender, EventArgs e)
        {
            txtDefence.Clear();
            TxtAttack.Clear();
            txtGold.Clear();
            txtWood.Clear();
            txtOre.Clear();
            txtMoves.Clear();
            txtMaxMoves.Clear();
            txtXp.Clear();
        }

        private void btnUpdateLvl_Click(object sender, EventArgs e)
        {
            mainScene.MainCharacter.IsTrainerOn = true;
            int counterAtt = 0;
            int counterDef = 0;
            int counterLvl = 0;

            while (this.mainScene.MainCharacter.Experience >= this.mainScene.MainCharacter.Level * 1000)
            {
                this.mainScene.MainCharacter.Experience = this.mainScene.MainCharacter.Experience - this.mainScene.MainCharacter.Level * 1000;
                this.mainScene.MainCharacter.Level++;
                counterLvl++;
                
                // string attributeMessage = string.Empty;
                switch (this.mainScene.MainCharacter.random.Next(2))
                {
                    case 0:
                        this.mainScene.MainCharacter.Attack++;
                        counterAtt++;
                        // attributeMessage = "You have gained 1 Attack";
                        break;
                    case 1:
                        this.mainScene.MainCharacter.Defense++;
                        counterDef++;
                        // attributeMessage = "You have gained 1 Defense";
                        break;
                }
            }
            MessageBox.Show("You gained "+counterLvl+" levels, "+counterAtt+" Attack and "+counterDef+" Defence points!");
            //this.mainScene.MainCharacter.UpdateLevel();
            mainScene.MainCharacter.IsTrainerOn = false;
        }
    }
}
