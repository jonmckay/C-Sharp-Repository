namespace Card_Deck_App_Chapter_8
{
    partial class DeckForm
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
            this.btnReset1 = new System.Windows.Forms.Button();
            this.btnShuffle1 = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnShuffle2 = new System.Windows.Forms.Button();
            this.lbDeck1 = new System.Windows.Forms.ListBox();
            this.lbDeck2 = new System.Windows.Forms.ListBox();
            this.btnMoveToDeck2 = new System.Windows.Forms.Button();
            this.btnMoveToDeck1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReset1
            // 
            this.btnReset1.Location = new System.Drawing.Point(12, 279);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(120, 23);
            this.btnReset1.TabIndex = 0;
            this.btnReset1.Text = "Reset Deck #1";
            this.btnReset1.UseVisualStyleBackColor = true;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // btnShuffle1
            // 
            this.btnShuffle1.Location = new System.Drawing.Point(12, 308);
            this.btnShuffle1.Name = "btnShuffle1";
            this.btnShuffle1.Size = new System.Drawing.Size(120, 23);
            this.btnShuffle1.TabIndex = 1;
            this.btnShuffle1.Text = "Shuffle Deck #1";
            this.btnShuffle1.UseVisualStyleBackColor = true;
            this.btnShuffle1.Click += new System.EventHandler(this.btnShuffle1_Click);
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(182, 279);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(117, 23);
            this.btnReset2.TabIndex = 2;
            this.btnReset2.Text = "Reset Deck #2";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnShuffle2
            // 
            this.btnShuffle2.Location = new System.Drawing.Point(182, 308);
            this.btnShuffle2.Name = "btnShuffle2";
            this.btnShuffle2.Size = new System.Drawing.Size(117, 23);
            this.btnShuffle2.TabIndex = 3;
            this.btnShuffle2.Text = "Shuffle Deck #2";
            this.btnShuffle2.UseVisualStyleBackColor = true;
            this.btnShuffle2.Click += new System.EventHandler(this.btnShuffle2_Click);
            // 
            // lbDeck1
            // 
            this.lbDeck1.FormattingEnabled = true;
            this.lbDeck1.Location = new System.Drawing.Point(12, 35);
            this.lbDeck1.Name = "lbDeck1";
            this.lbDeck1.Size = new System.Drawing.Size(120, 238);
            this.lbDeck1.TabIndex = 4;
            // 
            // lbDeck2
            // 
            this.lbDeck2.FormattingEnabled = true;
            this.lbDeck2.Location = new System.Drawing.Point(182, 35);
            this.lbDeck2.Name = "lbDeck2";
            this.lbDeck2.Size = new System.Drawing.Size(117, 238);
            this.lbDeck2.TabIndex = 5;
            // 
            // btnMoveToDeck2
            // 
            this.btnMoveToDeck2.Location = new System.Drawing.Point(138, 79);
            this.btnMoveToDeck2.Name = "btnMoveToDeck2";
            this.btnMoveToDeck2.Size = new System.Drawing.Size(38, 23);
            this.btnMoveToDeck2.TabIndex = 6;
            this.btnMoveToDeck2.Text = ">>";
            this.btnMoveToDeck2.UseVisualStyleBackColor = true;
            this.btnMoveToDeck2.Click += new System.EventHandler(this.btnMoveToDeck2_Click);
            // 
            // btnMoveToDeck1
            // 
            this.btnMoveToDeck1.Location = new System.Drawing.Point(138, 124);
            this.btnMoveToDeck1.Name = "btnMoveToDeck1";
            this.btnMoveToDeck1.Size = new System.Drawing.Size(38, 23);
            this.btnMoveToDeck1.TabIndex = 7;
            this.btnMoveToDeck1.Text = "<<";
            this.btnMoveToDeck1.UseVisualStyleBackColor = true;
            this.btnMoveToDeck1.Click += new System.EventHandler(this.btnMoveToDeck1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Deck #1 (6 cards)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Deck #2 (52 cards)";
            // 
            // DeckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMoveToDeck1);
            this.Controls.Add(this.btnMoveToDeck2);
            this.Controls.Add(this.lbDeck2);
            this.Controls.Add(this.lbDeck1);
            this.Controls.Add(this.btnShuffle2);
            this.Controls.Add(this.btnReset2);
            this.Controls.Add(this.btnShuffle1);
            this.Controls.Add(this.btnReset1);
            this.Name = "DeckForm";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.Button btnShuffle1;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnShuffle2;
        private System.Windows.Forms.ListBox lbDeck1;
        private System.Windows.Forms.ListBox lbDeck2;
        private System.Windows.Forms.Button btnMoveToDeck2;
        private System.Windows.Forms.Button btnMoveToDeck1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

