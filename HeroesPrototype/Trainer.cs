namespace HeroesPrototype
{
    using System;
    using System.Windows.Forms;
    public partial class Trainer : Form
    {
        private MainScene mainScene;

        public Trainer(MainScene mainScene)
        {
            InitializeComponent();
            this.mainScene = mainScene;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number = 0;
            int uintNum = 0;
            if (int.TryParse(txtDefence.Text, out number)) mainScene.MainCharacter.Defense += number;
            if (int.TryParse(TxtAttack.Text, out number)) mainScene.MainCharacter.Attack += number;
            if (int.TryParse(txtGold.Text, out uintNum)) mainScene.MainCharacter.Gold += uintNum;
            if (int.TryParse(txtWood.Text, out uintNum)) mainScene.MainCharacter.Wood += uintNum;
            if (int.TryParse(txtOre.Text, out uintNum)) mainScene.MainCharacter.Ore += uintNum;
            if (int.TryParse(txtMoves.Text, out number)) mainScene.MainCharacter.Moves += number;
            if (int.TryParse(txtMaxMoves.Text, out number)) mainScene.MainCharacter.MaxMoves += number;
            if (int.TryParse(txtXp.Text, out uintNum)) mainScene.MainCharacter.Experience += uintNum;
        }

        private void btnChangeTo_Click(object sender, EventArgs e)
        {
            int number = 0;
            int uintNum = 0;
            if (int.TryParse(txtDefence.Text, out number)) mainScene.MainCharacter.Defense = number;
            if (int.TryParse(TxtAttack.Text, out number)) mainScene.MainCharacter.Attack = number;
            if (int.TryParse(txtGold.Text, out uintNum)) mainScene.MainCharacter.Gold = uintNum;
            if (int.TryParse(txtWood.Text, out uintNum)) mainScene.MainCharacter.Wood = uintNum;
            if (int.TryParse(txtOre.Text, out uintNum)) mainScene.MainCharacter.Ore = uintNum;
            if (int.TryParse(txtMoves.Text, out number)) mainScene.MainCharacter.Moves = number;
            if (int.TryParse(txtMaxMoves.Text, out number)) mainScene.MainCharacter.MaxMoves = number;
            if (int.TryParse(txtXp.Text, out uintNum)) mainScene.MainCharacter.Experience = uintNum;
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
    }
}
