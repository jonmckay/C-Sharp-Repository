namespace The_Quest
{
    partial class QuestForm
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestForm));
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnAttackDown = new System.Windows.Forms.Button();
            this.btnAttackRight = new System.Windows.Forms.Button();
            this.btnAttackLeft = new System.Windows.Forms.Button();
            this.btnAttackUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbBat = new System.Windows.Forms.PictureBox();
            this.pbGhost = new System.Windows.Forms.PictureBox();
            this.pbWizard = new System.Windows.Forms.PictureBox();
            this.pbSwordInv = new System.Windows.Forms.PictureBox();
            this.pbRedPot = new System.Windows.Forms.PictureBox();
            this.pbBluePot = new System.Windows.Forms.PictureBox();
            this.pbBomb = new System.Windows.Forms.PictureBox();
            this.pbBattleaxe = new System.Windows.Forms.PictureBox();
            this.pbBow = new System.Windows.Forms.PictureBox();
            this.pbSword = new System.Windows.Forms.PictureBox();
            this.pbQuiver = new System.Windows.Forms.PictureBox();
            this.pbMace = new System.Windows.Forms.PictureBox();
            this.pbGhoul = new System.Windows.Forms.PictureBox();
            this.pbRedPotInv = new System.Windows.Forms.PictureBox();
            this.pbBluePotInv = new System.Windows.Forms.PictureBox();
            this.pbBombInv = new System.Windows.Forms.PictureBox();
            this.pbBattleaxeInv = new System.Windows.Forms.PictureBox();
            this.pbBowInv = new System.Windows.Forms.PictureBox();
            this.pbQuiverInv = new System.Windows.Forms.PictureBox();
            this.pbMaceInv = new System.Windows.Forms.PictureBox();
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblBat = new System.Windows.Forms.Label();
            this.lblGhost = new System.Windows.Forms.Label();
            this.lblGhoul = new System.Windows.Forms.Label();
            this.lblPlayerHitPoint = new System.Windows.Forms.Label();
            this.lblBatHitPoints = new System.Windows.Forms.Label();
            this.lblGhostHitPoints = new System.Windows.Forms.Label();
            this.lblGhoulHitPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwordInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedPot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBluePot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBattleaxe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedPotInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBluePotInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBombInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBattleaxeInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBowInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuiverInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaceInv)).BeginInit();
            this.tlpStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(661, 32);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 0;
            this.btnMoveUp.Text = "Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.MoveClick);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(616, 61);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeft.TabIndex = 1;
            this.btnMoveLeft.Text = "Left";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.MoveClick);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(706, 61);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRight.TabIndex = 2;
            this.btnMoveRight.Text = "Right";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.MoveClick);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(661, 90);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 3;
            this.btnMoveDown.Text = "Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.MoveClick);
            // 
            // btnAttackDown
            // 
            this.btnAttackDown.Location = new System.Drawing.Point(661, 232);
            this.btnAttackDown.Name = "btnAttackDown";
            this.btnAttackDown.Size = new System.Drawing.Size(75, 23);
            this.btnAttackDown.TabIndex = 7;
            this.btnAttackDown.Text = "Down";
            this.btnAttackDown.UseVisualStyleBackColor = true;
            this.btnAttackDown.Click += new System.EventHandler(this.AttackClick);
            // 
            // btnAttackRight
            // 
            this.btnAttackRight.Location = new System.Drawing.Point(706, 203);
            this.btnAttackRight.Name = "btnAttackRight";
            this.btnAttackRight.Size = new System.Drawing.Size(75, 23);
            this.btnAttackRight.TabIndex = 6;
            this.btnAttackRight.Text = "Right";
            this.btnAttackRight.UseVisualStyleBackColor = true;
            this.btnAttackRight.Click += new System.EventHandler(this.AttackClick);
            // 
            // btnAttackLeft
            // 
            this.btnAttackLeft.Location = new System.Drawing.Point(616, 203);
            this.btnAttackLeft.Name = "btnAttackLeft";
            this.btnAttackLeft.Size = new System.Drawing.Size(75, 23);
            this.btnAttackLeft.TabIndex = 5;
            this.btnAttackLeft.Text = "Left";
            this.btnAttackLeft.UseVisualStyleBackColor = true;
            this.btnAttackLeft.Click += new System.EventHandler(this.AttackClick);
            // 
            // btnAttackUp
            // 
            this.btnAttackUp.Location = new System.Drawing.Point(661, 174);
            this.btnAttackUp.Name = "btnAttackUp";
            this.btnAttackUp.Size = new System.Drawing.Size(75, 23);
            this.btnAttackUp.TabIndex = 4;
            this.btnAttackUp.Text = "Up";
            this.btnAttackUp.UseVisualStyleBackColor = true;
            this.btnAttackUp.Click += new System.EventHandler(this.AttackClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Move";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Attack";
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPlayer.BackgroundImage")));
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(79, 60);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(30, 30);
            this.pbPlayer.TabIndex = 10;
            this.pbPlayer.TabStop = false;
            this.pbPlayer.Visible = false;
            // 
            // pbBat
            // 
            this.pbBat.BackColor = System.Drawing.Color.Transparent;
            this.pbBat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBat.BackgroundImage")));
            this.pbBat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBat.Location = new System.Drawing.Point(115, 60);
            this.pbBat.Name = "pbBat";
            this.pbBat.Size = new System.Drawing.Size(30, 30);
            this.pbBat.TabIndex = 11;
            this.pbBat.TabStop = false;
            this.pbBat.Visible = false;
            // 
            // pbGhost
            // 
            this.pbGhost.BackColor = System.Drawing.Color.Transparent;
            this.pbGhost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGhost.BackgroundImage")));
            this.pbGhost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbGhost.Location = new System.Drawing.Point(151, 60);
            this.pbGhost.Name = "pbGhost";
            this.pbGhost.Size = new System.Drawing.Size(30, 30);
            this.pbGhost.TabIndex = 12;
            this.pbGhost.TabStop = false;
            this.pbGhost.Visible = false;
            // 
            // pbWizard
            // 
            this.pbWizard.BackColor = System.Drawing.Color.Transparent;
            this.pbWizard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWizard.BackgroundImage")));
            this.pbWizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbWizard.Location = new System.Drawing.Point(187, 60);
            this.pbWizard.Name = "pbWizard";
            this.pbWizard.Size = new System.Drawing.Size(30, 30);
            this.pbWizard.TabIndex = 13;
            this.pbWizard.TabStop = false;
            this.pbWizard.Visible = false;
            // 
            // pbSwordInv
            // 
            this.pbSwordInv.BackColor = System.Drawing.Color.Transparent;
            this.pbSwordInv.BackgroundImage = global::The_Quest.Properties.Resources.swordInv;
            this.pbSwordInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbSwordInv.Location = new System.Drawing.Point(79, 320);
            this.pbSwordInv.Name = "pbSwordInv";
            this.pbSwordInv.Size = new System.Drawing.Size(50, 50);
            this.pbSwordInv.TabIndex = 14;
            this.pbSwordInv.TabStop = false;
            this.pbSwordInv.Visible = false;
            this.pbSwordInv.Click += new System.EventHandler(this.InventoryItemClick);
            // 
            // pbRedPot
            // 
            this.pbRedPot.BackColor = System.Drawing.Color.Transparent;
            this.pbRedPot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRedPot.BackgroundImage")));
            this.pbRedPot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbRedPot.Location = new System.Drawing.Point(79, 96);
            this.pbRedPot.Name = "pbRedPot";
            this.pbRedPot.Size = new System.Drawing.Size(30, 30);
            this.pbRedPot.TabIndex = 15;
            this.pbRedPot.TabStop = false;
            this.pbRedPot.Visible = false;
            // 
            // pbBluePot
            // 
            this.pbBluePot.BackColor = System.Drawing.Color.Transparent;
            this.pbBluePot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBluePot.BackgroundImage")));
            this.pbBluePot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBluePot.Location = new System.Drawing.Point(475, 61);
            this.pbBluePot.Name = "pbBluePot";
            this.pbBluePot.Size = new System.Drawing.Size(30, 30);
            this.pbBluePot.TabIndex = 16;
            this.pbBluePot.TabStop = false;
            this.pbBluePot.Visible = false;
            // 
            // pbBomb
            // 
            this.pbBomb.BackColor = System.Drawing.Color.Transparent;
            this.pbBomb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBomb.BackgroundImage")));
            this.pbBomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBomb.Location = new System.Drawing.Point(439, 60);
            this.pbBomb.Name = "pbBomb";
            this.pbBomb.Size = new System.Drawing.Size(30, 30);
            this.pbBomb.TabIndex = 17;
            this.pbBomb.TabStop = false;
            this.pbBomb.Visible = false;
            // 
            // pbBattleaxe
            // 
            this.pbBattleaxe.BackColor = System.Drawing.Color.Transparent;
            this.pbBattleaxe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBattleaxe.BackgroundImage")));
            this.pbBattleaxe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBattleaxe.Location = new System.Drawing.Point(403, 60);
            this.pbBattleaxe.Name = "pbBattleaxe";
            this.pbBattleaxe.Size = new System.Drawing.Size(30, 30);
            this.pbBattleaxe.TabIndex = 18;
            this.pbBattleaxe.TabStop = false;
            this.pbBattleaxe.Visible = false;
            // 
            // pbBow
            // 
            this.pbBow.BackColor = System.Drawing.Color.Transparent;
            this.pbBow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBow.BackgroundImage")));
            this.pbBow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBow.Location = new System.Drawing.Point(367, 60);
            this.pbBow.Name = "pbBow";
            this.pbBow.Size = new System.Drawing.Size(30, 30);
            this.pbBow.TabIndex = 19;
            this.pbBow.TabStop = false;
            this.pbBow.Visible = false;
            // 
            // pbSword
            // 
            this.pbSword.BackColor = System.Drawing.Color.Transparent;
            this.pbSword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSword.BackgroundImage")));
            this.pbSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbSword.Location = new System.Drawing.Point(331, 60);
            this.pbSword.Name = "pbSword";
            this.pbSword.Size = new System.Drawing.Size(30, 30);
            this.pbSword.TabIndex = 20;
            this.pbSword.TabStop = false;
            this.pbSword.Visible = false;
            // 
            // pbQuiver
            // 
            this.pbQuiver.BackColor = System.Drawing.Color.Transparent;
            this.pbQuiver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbQuiver.BackgroundImage")));
            this.pbQuiver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbQuiver.Location = new System.Drawing.Point(295, 60);
            this.pbQuiver.Name = "pbQuiver";
            this.pbQuiver.Size = new System.Drawing.Size(30, 30);
            this.pbQuiver.TabIndex = 21;
            this.pbQuiver.TabStop = false;
            this.pbQuiver.Visible = false;
            // 
            // pbMace
            // 
            this.pbMace.BackColor = System.Drawing.Color.Transparent;
            this.pbMace.BackgroundImage = global::The_Quest.Properties.Resources.mace;
            this.pbMace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbMace.Location = new System.Drawing.Point(259, 60);
            this.pbMace.Name = "pbMace";
            this.pbMace.Size = new System.Drawing.Size(30, 30);
            this.pbMace.TabIndex = 22;
            this.pbMace.TabStop = false;
            this.pbMace.Visible = false;
            // 
            // pbGhoul
            // 
            this.pbGhoul.BackColor = System.Drawing.Color.Transparent;
            this.pbGhoul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGhoul.BackgroundImage")));
            this.pbGhoul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbGhoul.Location = new System.Drawing.Point(223, 60);
            this.pbGhoul.Name = "pbGhoul";
            this.pbGhoul.Size = new System.Drawing.Size(30, 30);
            this.pbGhoul.TabIndex = 23;
            this.pbGhoul.TabStop = false;
            this.pbGhoul.Visible = false;
            // 
            // pbRedPotInv
            // 
            this.pbRedPotInv.BackColor = System.Drawing.Color.Transparent;
            this.pbRedPotInv.BackgroundImage = global::The_Quest.Properties.Resources.potion_redInv;
            this.pbRedPotInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbRedPotInv.Location = new System.Drawing.Point(359, 320);
            this.pbRedPotInv.Name = "pbRedPotInv";
            this.pbRedPotInv.Size = new System.Drawing.Size(50, 50);
            this.pbRedPotInv.TabIndex = 24;
            this.pbRedPotInv.TabStop = false;
            this.pbRedPotInv.Visible = false;
            this.pbRedPotInv.Click += new System.EventHandler(this.InventoryItemClick);
            // 
            // pbBluePotInv
            // 
            this.pbBluePotInv.BackColor = System.Drawing.Color.Transparent;
            this.pbBluePotInv.BackgroundImage = global::The_Quest.Properties.Resources.potion_blueInv;
            this.pbBluePotInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBluePotInv.Location = new System.Drawing.Point(303, 320);
            this.pbBluePotInv.Name = "pbBluePotInv";
            this.pbBluePotInv.Size = new System.Drawing.Size(50, 50);
            this.pbBluePotInv.TabIndex = 25;
            this.pbBluePotInv.TabStop = false;
            this.pbBluePotInv.Visible = false;
            this.pbBluePotInv.Click += new System.EventHandler(this.InventoryItemClick);
            // 
            // pbBombInv
            // 
            this.pbBombInv.BackColor = System.Drawing.Color.Transparent;
            this.pbBombInv.BackgroundImage = global::The_Quest.Properties.Resources.bombInv;
            this.pbBombInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBombInv.Location = new System.Drawing.Point(247, 320);
            this.pbBombInv.Name = "pbBombInv";
            this.pbBombInv.Size = new System.Drawing.Size(50, 50);
            this.pbBombInv.TabIndex = 26;
            this.pbBombInv.TabStop = false;
            this.pbBombInv.Visible = false;
            this.pbBombInv.Click += new System.EventHandler(this.InventoryItemClick);
            // 
            // pbBattleaxeInv
            // 
            this.pbBattleaxeInv.BackColor = System.Drawing.Color.Transparent;
            this.pbBattleaxeInv.BackgroundImage = global::The_Quest.Properties.Resources.battleaxeInv;
            this.pbBattleaxeInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBattleaxeInv.Location = new System.Drawing.Point(191, 320);
            this.pbBattleaxeInv.Name = "pbBattleaxeInv";
            this.pbBattleaxeInv.Size = new System.Drawing.Size(50, 50);
            this.pbBattleaxeInv.TabIndex = 27;
            this.pbBattleaxeInv.TabStop = false;
            this.pbBattleaxeInv.Visible = false;
            this.pbBattleaxeInv.Click += new System.EventHandler(this.InventoryItemClick);
            // 
            // pbBowInv
            // 
            this.pbBowInv.BackColor = System.Drawing.Color.Transparent;
            this.pbBowInv.BackgroundImage = global::The_Quest.Properties.Resources.bowInv;
            this.pbBowInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBowInv.Location = new System.Drawing.Point(135, 320);
            this.pbBowInv.Name = "pbBowInv";
            this.pbBowInv.Size = new System.Drawing.Size(50, 50);
            this.pbBowInv.TabIndex = 28;
            this.pbBowInv.TabStop = false;
            this.pbBowInv.Visible = false;
            this.pbBowInv.Click += new System.EventHandler(this.InventoryItemClick);
            // 
            // pbQuiverInv
            // 
            this.pbQuiverInv.BackColor = System.Drawing.Color.Transparent;
            this.pbQuiverInv.BackgroundImage = global::The_Quest.Properties.Resources.quiverInv;
            this.pbQuiverInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbQuiverInv.Location = new System.Drawing.Point(415, 320);
            this.pbQuiverInv.Name = "pbQuiverInv";
            this.pbQuiverInv.Size = new System.Drawing.Size(50, 50);
            this.pbQuiverInv.TabIndex = 29;
            this.pbQuiverInv.TabStop = false;
            this.pbQuiverInv.Visible = false;
            this.pbQuiverInv.Click += new System.EventHandler(this.InventoryItemClick);
            // 
            // pbMaceInv
            // 
            this.pbMaceInv.BackColor = System.Drawing.Color.Transparent;
            this.pbMaceInv.BackgroundImage = global::The_Quest.Properties.Resources.maceInv;
            this.pbMaceInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbMaceInv.Location = new System.Drawing.Point(471, 320);
            this.pbMaceInv.Name = "pbMaceInv";
            this.pbMaceInv.Size = new System.Drawing.Size(50, 50);
            this.pbMaceInv.TabIndex = 30;
            this.pbMaceInv.TabStop = false;
            this.pbMaceInv.Visible = false;
            this.pbMaceInv.Click += new System.EventHandler(this.InventoryItemClick);
            // 
            // tlpStats
            // 
            this.tlpStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpStats.ColumnCount = 2;
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.44304F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.55696F));
            this.tlpStats.Controls.Add(this.lblPlayer, 0, 0);
            this.tlpStats.Controls.Add(this.lblBat, 0, 1);
            this.tlpStats.Controls.Add(this.lblGhost, 0, 2);
            this.tlpStats.Controls.Add(this.lblGhoul, 0, 3);
            this.tlpStats.Controls.Add(this.lblPlayerHitPoint, 1, 0);
            this.tlpStats.Controls.Add(this.lblBatHitPoints, 1, 1);
            this.tlpStats.Controls.Add(this.lblGhostHitPoints, 1, 2);
            this.tlpStats.Controls.Add(this.lblGhoulHitPoints, 1, 3);
            this.tlpStats.Location = new System.Drawing.Point(622, 266);
            this.tlpStats.Name = "tlpStats";
            this.tlpStats.RowCount = 4;
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.Size = new System.Drawing.Size(158, 125);
            this.tlpStats.TabIndex = 31;
            // 
            // lblPlayer
            // 
            this.lblPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(10, 9);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Player";
            // 
            // lblBat
            // 
            this.lblBat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBat.AutoSize = true;
            this.lblBat.Location = new System.Drawing.Point(16, 40);
            this.lblBat.Name = "lblBat";
            this.lblBat.Size = new System.Drawing.Size(23, 13);
            this.lblBat.TabIndex = 1;
            this.lblBat.Text = "Bat";
            // 
            // lblGhost
            // 
            this.lblGhost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGhost.AutoSize = true;
            this.lblGhost.Location = new System.Drawing.Point(10, 71);
            this.lblGhost.Name = "lblGhost";
            this.lblGhost.Size = new System.Drawing.Size(35, 13);
            this.lblGhost.TabIndex = 2;
            this.lblGhost.Text = "Ghost";
            // 
            // lblGhoul
            // 
            this.lblGhoul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGhoul.AutoSize = true;
            this.lblGhoul.Location = new System.Drawing.Point(10, 102);
            this.lblGhoul.Name = "lblGhoul";
            this.lblGhoul.Size = new System.Drawing.Size(35, 13);
            this.lblGhoul.TabIndex = 3;
            this.lblGhoul.Text = "Ghoul";
            // 
            // lblPlayerHitPoint
            // 
            this.lblPlayerHitPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayerHitPoint.AutoSize = true;
            this.lblPlayerHitPoint.Location = new System.Drawing.Point(70, 9);
            this.lblPlayerHitPoint.Name = "lblPlayerHitPoint";
            this.lblPlayerHitPoint.Size = new System.Drawing.Size(73, 13);
            this.lblPlayerHitPoint.TabIndex = 4;
            this.lblPlayerHitPoint.Text = "PlayerHitPoint";
            // 
            // lblBatHitPoints
            // 
            this.lblBatHitPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBatHitPoints.AutoSize = true;
            this.lblBatHitPoints.Location = new System.Drawing.Point(74, 40);
            this.lblBatHitPoints.Name = "lblBatHitPoints";
            this.lblBatHitPoints.Size = new System.Drawing.Size(65, 13);
            this.lblBatHitPoints.TabIndex = 5;
            this.lblBatHitPoints.Text = "BatHitPoints";
            // 
            // lblGhostHitPoints
            // 
            this.lblGhostHitPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGhostHitPoints.AutoSize = true;
            this.lblGhostHitPoints.Location = new System.Drawing.Point(68, 71);
            this.lblGhostHitPoints.Name = "lblGhostHitPoints";
            this.lblGhostHitPoints.Size = new System.Drawing.Size(77, 13);
            this.lblGhostHitPoints.TabIndex = 6;
            this.lblGhostHitPoints.Text = "GhostHitPoints";
            // 
            // lblGhoulHitPoints
            // 
            this.lblGhoulHitPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGhoulHitPoints.AutoSize = true;
            this.lblGhoulHitPoints.Location = new System.Drawing.Point(68, 102);
            this.lblGhoulHitPoints.Name = "lblGhoulHitPoints";
            this.lblGhoulHitPoints.Size = new System.Drawing.Size(77, 13);
            this.lblGhoulHitPoints.TabIndex = 7;
            this.lblGhoulHitPoints.Text = "GhoulHitPoints";
            // 
            // QuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(795, 401);
            this.Controls.Add(this.tlpStats);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbMaceInv);
            this.Controls.Add(this.pbQuiverInv);
            this.Controls.Add(this.pbBowInv);
            this.Controls.Add(this.pbBattleaxeInv);
            this.Controls.Add(this.pbBombInv);
            this.Controls.Add(this.pbBluePotInv);
            this.Controls.Add(this.pbRedPotInv);
            this.Controls.Add(this.pbGhoul);
            this.Controls.Add(this.pbSwordInv);
            this.Controls.Add(this.pbWizard);
            this.Controls.Add(this.pbGhost);
            this.Controls.Add(this.pbBat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttackDown);
            this.Controls.Add(this.btnAttackRight);
            this.Controls.Add(this.btnAttackLeft);
            this.Controls.Add(this.btnAttackUp);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.pbMace);
            this.Controls.Add(this.pbQuiver);
            this.Controls.Add(this.pbSword);
            this.Controls.Add(this.pbBow);
            this.Controls.Add(this.pbBattleaxe);
            this.Controls.Add(this.pbBomb);
            this.Controls.Add(this.pbBluePot);
            this.Controls.Add(this.pbRedPot);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "QuestForm";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.QuestForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuestForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwordInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedPot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBluePot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBattleaxe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedPotInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBluePotInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBombInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBattleaxeInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBowInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuiverInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaceInv)).EndInit();
            this.tlpStats.ResumeLayout(false);
            this.tlpStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnAttackDown;
        private System.Windows.Forms.Button btnAttackRight;
        private System.Windows.Forms.Button btnAttackLeft;
        private System.Windows.Forms.Button btnAttackUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbBat;
        private System.Windows.Forms.PictureBox pbGhost;
        private System.Windows.Forms.PictureBox pbWizard;
        private System.Windows.Forms.PictureBox pbSwordInv;
        private System.Windows.Forms.PictureBox pbRedPot;
        private System.Windows.Forms.PictureBox pbBluePot;
        private System.Windows.Forms.PictureBox pbBomb;
        private System.Windows.Forms.PictureBox pbBattleaxe;
        private System.Windows.Forms.PictureBox pbBow;
        private System.Windows.Forms.PictureBox pbSword;
        private System.Windows.Forms.PictureBox pbQuiver;
        private System.Windows.Forms.PictureBox pbMace;
        private System.Windows.Forms.PictureBox pbGhoul;
        private System.Windows.Forms.PictureBox pbRedPotInv;
        private System.Windows.Forms.PictureBox pbBluePotInv;
        private System.Windows.Forms.PictureBox pbBombInv;
        private System.Windows.Forms.PictureBox pbBattleaxeInv;
        private System.Windows.Forms.PictureBox pbBowInv;
        private System.Windows.Forms.PictureBox pbQuiverInv;
        private System.Windows.Forms.PictureBox pbMaceInv;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblBat;
        private System.Windows.Forms.Label lblGhost;
        private System.Windows.Forms.Label lblGhoul;
        private System.Windows.Forms.Label lblPlayerHitPoint;
        private System.Windows.Forms.Label lblBatHitPoints;
        private System.Windows.Forms.Label lblGhostHitPoints;
        private System.Windows.Forms.Label lblGhoulHitPoints;
    }
}

