namespace Go_Fish_Chapter_8
{
    partial class GoFishForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lbPlayerHand = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textProgress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBooks = new System.Windows.Forms.TextBox();
            this.btnAskForCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your name";
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(12, 33);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(147, 20);
            this.tbPlayerName.TabIndex = 1;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(165, 33);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(147, 21);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Start the game!";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lbPlayerHand
            // 
            this.lbPlayerHand.FormattingEnabled = true;
            this.lbPlayerHand.Location = new System.Drawing.Point(318, 33);
            this.lbPlayerHand.Name = "lbPlayerHand";
            this.lbPlayerHand.Size = new System.Drawing.Size(175, 407);
            this.lbPlayerHand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your hand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Game progress";
            // 
            // textProgress
            // 
            this.textProgress.BackColor = System.Drawing.SystemColors.Control;
            this.textProgress.Location = new System.Drawing.Point(15, 75);
            this.textProgress.Multiline = true;
            this.textProgress.Name = "textProgress";
            this.textProgress.ReadOnly = true;
            this.textProgress.Size = new System.Drawing.Size(296, 268);
            this.textProgress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Books";
            // 
            // textBooks
            // 
            this.textBooks.BackColor = System.Drawing.SystemColors.Control;
            this.textBooks.Location = new System.Drawing.Point(15, 360);
            this.textBooks.Multiline = true;
            this.textBooks.Name = "textBooks";
            this.textBooks.ReadOnly = true;
            this.textBooks.Size = new System.Drawing.Size(296, 106);
            this.textBooks.TabIndex = 8;
            // 
            // btnAskForCard
            // 
            this.btnAskForCard.Enabled = false;
            this.btnAskForCard.Location = new System.Drawing.Point(318, 443);
            this.btnAskForCard.Name = "btnAskForCard";
            this.btnAskForCard.Size = new System.Drawing.Size(175, 23);
            this.btnAskForCard.TabIndex = 9;
            this.btnAskForCard.Text = "Ask for a card";
            this.btnAskForCard.UseVisualStyleBackColor = true;
            this.btnAskForCard.Click += new System.EventHandler(this.btnAskForCard_Click);
            // 
            // GoFishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 478);
            this.Controls.Add(this.btnAskForCard);
            this.Controls.Add(this.textBooks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPlayerHand);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.label1);
            this.Name = "GoFishForm";
            this.Text = "Go Fish!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.ListBox lbPlayerHand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBooks;
        private System.Windows.Forms.Button btnAskForCard;
    }
}

