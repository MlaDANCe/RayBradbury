namespace HeroesPrototype
{
    partial class Trainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.TxtAttack = new System.Windows.Forms.TextBox();
            this.txtGold = new System.Windows.Forms.TextBox();
            this.LblGold = new System.Windows.Forms.Label();
            this.LblAttack = new System.Windows.Forms.Label();
            this.GrbResources = new System.Windows.Forms.GroupBox();
            this.GrbAttributes = new System.Windows.Forms.GroupBox();
            this.txtOre = new System.Windows.Forms.TextBox();
            this.txtWood = new System.Windows.Forms.TextBox();
            this.txtDefence = new System.Windows.Forms.TextBox();
            this.txtXp = new System.Windows.Forms.TextBox();
            this.LblDefence = new System.Windows.Forms.Label();
            this.LblXp = new System.Windows.Forms.Label();
            this.LblOre = new System.Windows.Forms.Label();
            this.LblWood = new System.Windows.Forms.Label();
            this.LblMaxMoves = new System.Windows.Forms.Label();
            this.txtMaxMoves = new System.Windows.Forms.TextBox();
            this.btnChangeTo = new System.Windows.Forms.Button();
            this.LblMoves = new System.Windows.Forms.Label();
            this.txtMoves = new System.Windows.Forms.TextBox();
            this.btnClearTxt = new System.Windows.Forms.Button();
            this.GrbResources.SuspendLayout();
            this.GrbAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(237, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TxtAttack
            // 
            this.TxtAttack.Location = new System.Drawing.Point(104, 40);
            this.TxtAttack.Name = "TxtAttack";
            this.TxtAttack.Size = new System.Drawing.Size(126, 20);
            this.TxtAttack.TabIndex = 3;
            // 
            // txtGold
            // 
            this.txtGold.Location = new System.Drawing.Point(115, 40);
            this.txtGold.Name = "txtGold";
            this.txtGold.Size = new System.Drawing.Size(101, 20);
            this.txtGold.TabIndex = 4;
            // 
            // LblGold
            // 
            this.LblGold.AutoSize = true;
            this.LblGold.Location = new System.Drawing.Point(35, 43);
            this.LblGold.Name = "LblGold";
            this.LblGold.Size = new System.Drawing.Size(35, 13);
            this.LblGold.TabIndex = 5;
            this.LblGold.Text = "Gold: ";
            // 
            // LblAttack
            // 
            this.LblAttack.AutoSize = true;
            this.LblAttack.Location = new System.Drawing.Point(27, 43);
            this.LblAttack.Name = "LblAttack";
            this.LblAttack.Size = new System.Drawing.Size(44, 13);
            this.LblAttack.TabIndex = 6;
            this.LblAttack.Text = "Attack: ";
            // 
            // GrbResources
            // 
            this.GrbResources.Controls.Add(this.LblWood);
            this.GrbResources.Controls.Add(this.LblOre);
            this.GrbResources.Controls.Add(this.txtWood);
            this.GrbResources.Controls.Add(this.txtOre);
            this.GrbResources.Controls.Add(this.LblGold);
            this.GrbResources.Controls.Add(this.txtGold);
            this.GrbResources.Location = new System.Drawing.Point(39, 18);
            this.GrbResources.Name = "GrbResources";
            this.GrbResources.Size = new System.Drawing.Size(222, 246);
            this.GrbResources.TabIndex = 7;
            this.GrbResources.TabStop = false;
            this.GrbResources.Text = "Resources";
            // 
            // GrbAttributes
            // 
            this.GrbAttributes.Controls.Add(this.LblMoves);
            this.GrbAttributes.Controls.Add(this.txtMoves);
            this.GrbAttributes.Controls.Add(this.LblMaxMoves);
            this.GrbAttributes.Controls.Add(this.txtMaxMoves);
            this.GrbAttributes.Controls.Add(this.LblXp);
            this.GrbAttributes.Controls.Add(this.LblDefence);
            this.GrbAttributes.Controls.Add(this.txtXp);
            this.GrbAttributes.Controls.Add(this.txtDefence);
            this.GrbAttributes.Controls.Add(this.LblAttack);
            this.GrbAttributes.Controls.Add(this.TxtAttack);
            this.GrbAttributes.Location = new System.Drawing.Point(307, 18);
            this.GrbAttributes.Name = "GrbAttributes";
            this.GrbAttributes.Size = new System.Drawing.Size(236, 246);
            this.GrbAttributes.TabIndex = 8;
            this.GrbAttributes.TabStop = false;
            this.GrbAttributes.Text = "Attributes";
            // 
            // txtOre
            // 
            this.txtOre.Location = new System.Drawing.Point(115, 66);
            this.txtOre.Name = "txtOre";
            this.txtOre.Size = new System.Drawing.Size(101, 20);
            this.txtOre.TabIndex = 6;
            // 
            // txtWood
            // 
            this.txtWood.Location = new System.Drawing.Point(115, 92);
            this.txtWood.Name = "txtWood";
            this.txtWood.Size = new System.Drawing.Size(101, 20);
            this.txtWood.TabIndex = 7;
            // 
            // txtDefence
            // 
            this.txtDefence.Location = new System.Drawing.Point(104, 66);
            this.txtDefence.Name = "txtDefence";
            this.txtDefence.Size = new System.Drawing.Size(126, 20);
            this.txtDefence.TabIndex = 7;
            // 
            // txtXp
            // 
            this.txtXp.Location = new System.Drawing.Point(104, 92);
            this.txtXp.Name = "txtXp";
            this.txtXp.Size = new System.Drawing.Size(126, 20);
            this.txtXp.TabIndex = 8;
            // 
            // LblDefence
            // 
            this.LblDefence.AutoSize = true;
            this.LblDefence.Location = new System.Drawing.Point(27, 69);
            this.LblDefence.Name = "LblDefence";
            this.LblDefence.Size = new System.Drawing.Size(54, 13);
            this.LblDefence.TabIndex = 9;
            this.LblDefence.Text = "Defence: ";
            // 
            // LblXp
            // 
            this.LblXp.AutoSize = true;
            this.LblXp.Location = new System.Drawing.Point(27, 95);
            this.LblXp.Name = "LblXp";
            this.LblXp.Size = new System.Drawing.Size(26, 13);
            this.LblXp.TabIndex = 10;
            this.LblXp.Text = "Xp: ";
            // 
            // LblOre
            // 
            this.LblOre.AutoSize = true;
            this.LblOre.Location = new System.Drawing.Point(35, 66);
            this.LblOre.Name = "LblOre";
            this.LblOre.Size = new System.Drawing.Size(30, 13);
            this.LblOre.TabIndex = 11;
            this.LblOre.Text = "Ore: ";
            // 
            // LblWood
            // 
            this.LblWood.AutoSize = true;
            this.LblWood.Location = new System.Drawing.Point(35, 92);
            this.LblWood.Name = "LblWood";
            this.LblWood.Size = new System.Drawing.Size(42, 13);
            this.LblWood.TabIndex = 12;
            this.LblWood.Text = "Wood: ";
            // 
            // LblMaxMoves
            // 
            this.LblMaxMoves.AutoSize = true;
            this.LblMaxMoves.Location = new System.Drawing.Point(27, 144);
            this.LblMaxMoves.Name = "LblMaxMoves";
            this.LblMaxMoves.Size = new System.Drawing.Size(68, 13);
            this.LblMaxMoves.TabIndex = 13;
            this.LblMaxMoves.Text = "Max Moves: ";
            // 
            // txtMaxMoves
            // 
            this.txtMaxMoves.Location = new System.Drawing.Point(104, 144);
            this.txtMaxMoves.Name = "txtMaxMoves";
            this.txtMaxMoves.Size = new System.Drawing.Size(126, 20);
            this.txtMaxMoves.TabIndex = 15;
            // 
            // btnChangeTo
            // 
            this.btnChangeTo.Location = new System.Drawing.Point(237, 309);
            this.btnChangeTo.Name = "btnChangeTo";
            this.btnChangeTo.Size = new System.Drawing.Size(104, 34);
            this.btnChangeTo.TabIndex = 9;
            this.btnChangeTo.Text = "Change To";
            this.btnChangeTo.UseVisualStyleBackColor = true;
            this.btnChangeTo.Click += new System.EventHandler(this.btnChangeTo_Click);
            // 
            // LblMoves
            // 
            this.LblMoves.AutoSize = true;
            this.LblMoves.Location = new System.Drawing.Point(27, 121);
            this.LblMoves.Name = "LblMoves";
            this.LblMoves.Size = new System.Drawing.Size(45, 13);
            this.LblMoves.TabIndex = 16;
            this.LblMoves.Text = "Moves: ";
            // 
            // txtMoves
            // 
            this.txtMoves.Location = new System.Drawing.Point(104, 118);
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.Size = new System.Drawing.Size(126, 20);
            this.txtMoves.TabIndex = 17;
            // 
            // btnClearTxt
            // 
            this.btnClearTxt.Location = new System.Drawing.Point(237, 349);
            this.btnClearTxt.Name = "btnClearTxt";
            this.btnClearTxt.Size = new System.Drawing.Size(104, 35);
            this.btnClearTxt.TabIndex = 10;
            this.btnClearTxt.Text = "Clear text boxes";
            this.btnClearTxt.UseVisualStyleBackColor = true;
            this.btnClearTxt.Click += new System.EventHandler(this.btnClearTxt_Click);
            // 
            // Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 399);
            this.Controls.Add(this.btnClearTxt);
            this.Controls.Add(this.btnChangeTo);
            this.Controls.Add(this.GrbAttributes);
            this.Controls.Add(this.GrbResources);
            this.Controls.Add(this.btnAdd);
            this.MaximizeBox = false;
            this.Name = "Trainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trainer";
            this.GrbResources.ResumeLayout(false);
            this.GrbResources.PerformLayout();
            this.GrbAttributes.ResumeLayout(false);
            this.GrbAttributes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox TxtAttack;
        private System.Windows.Forms.TextBox txtGold;
        private System.Windows.Forms.Label LblGold;
        private System.Windows.Forms.Label LblAttack;
        private System.Windows.Forms.GroupBox GrbResources;
        private System.Windows.Forms.Label LblWood;
        private System.Windows.Forms.Label LblOre;
        private System.Windows.Forms.TextBox txtWood;
        private System.Windows.Forms.TextBox txtOre;
        private System.Windows.Forms.GroupBox GrbAttributes;
        private System.Windows.Forms.Label LblMaxMoves;
        private System.Windows.Forms.TextBox txtMaxMoves;
        private System.Windows.Forms.Label LblXp;
        private System.Windows.Forms.Label LblDefence;
        private System.Windows.Forms.TextBox txtXp;
        private System.Windows.Forms.TextBox txtDefence;
        private System.Windows.Forms.Button btnChangeTo;
        private System.Windows.Forms.Label LblMoves;
        private System.Windows.Forms.TextBox txtMoves;
        private System.Windows.Forms.Button btnClearTxt;
    }
}