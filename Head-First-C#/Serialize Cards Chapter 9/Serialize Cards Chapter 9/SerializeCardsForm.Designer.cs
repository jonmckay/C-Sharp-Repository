namespace Serialize_Cards_Chapter_9
{
    partial class SerializeCardsForm
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
            this.btnSaveDeck = new System.Windows.Forms.Button();
            this.btnLoadDeck = new System.Windows.Forms.Button();
            this.btnSaveDeck2 = new System.Windows.Forms.Button();
            this.btnLoadDeck2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCompareFiles = new System.Windows.Forms.Button();
            this.btnHexDumper = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveDeck
            // 
            this.btnSaveDeck.Location = new System.Drawing.Point(22, 23);
            this.btnSaveDeck.Name = "btnSaveDeck";
            this.btnSaveDeck.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDeck.TabIndex = 0;
            this.btnSaveDeck.Text = "Save Deck";
            this.btnSaveDeck.UseVisualStyleBackColor = true;
            this.btnSaveDeck.Click += new System.EventHandler(this.btnSaveDeck_Click);
            // 
            // btnLoadDeck
            // 
            this.btnLoadDeck.Location = new System.Drawing.Point(103, 23);
            this.btnLoadDeck.Name = "btnLoadDeck";
            this.btnLoadDeck.Size = new System.Drawing.Size(75, 23);
            this.btnLoadDeck.TabIndex = 1;
            this.btnLoadDeck.Text = "Load Deck";
            this.btnLoadDeck.UseVisualStyleBackColor = true;
            this.btnLoadDeck.Click += new System.EventHandler(this.btnLoadDeck_Click);
            // 
            // btnSaveDeck2
            // 
            this.btnSaveDeck2.Location = new System.Drawing.Point(22, 69);
            this.btnSaveDeck2.Name = "btnSaveDeck2";
            this.btnSaveDeck2.Size = new System.Drawing.Size(84, 23);
            this.btnSaveDeck2.TabIndex = 2;
            this.btnSaveDeck2.Text = "Save Deck 2";
            this.btnSaveDeck2.UseVisualStyleBackColor = true;
            this.btnSaveDeck2.Click += new System.EventHandler(this.btnSaveDeck2_Click);
            // 
            // btnLoadDeck2
            // 
            this.btnLoadDeck2.Location = new System.Drawing.Point(112, 69);
            this.btnLoadDeck2.Name = "btnLoadDeck2";
            this.btnLoadDeck2.Size = new System.Drawing.Size(91, 23);
            this.btnLoadDeck2.TabIndex = 3;
            this.btnLoadDeck2.Text = "Load Deck 2";
            this.btnLoadDeck2.UseVisualStyleBackColor = true;
            this.btnLoadDeck2.Click += new System.EventHandler(this.btnLoadDeck2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCompareFiles
            // 
            this.btnCompareFiles.Location = new System.Drawing.Point(12, 157);
            this.btnCompareFiles.Name = "btnCompareFiles";
            this.btnCompareFiles.Size = new System.Drawing.Size(127, 23);
            this.btnCompareFiles.TabIndex = 5;
            this.btnCompareFiles.Text = "Compare Binary Files";
            this.btnCompareFiles.UseVisualStyleBackColor = true;
            this.btnCompareFiles.Click += new System.EventHandler(this.btnCompareFiles_Click);
            // 
            // btnHexDumper
            // 
            this.btnHexDumper.Location = new System.Drawing.Point(12, 198);
            this.btnHexDumper.Name = "btnHexDumper";
            this.btnHexDumper.Size = new System.Drawing.Size(75, 23);
            this.btnHexDumper.TabIndex = 6;
            this.btnHexDumper.Text = "Hex Dumper";
            this.btnHexDumper.UseVisualStyleBackColor = true;
            this.btnHexDumper.Click += new System.EventHandler(this.btnHexDumper_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SerializeCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHexDumper);
            this.Controls.Add(this.btnCompareFiles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLoadDeck2);
            this.Controls.Add(this.btnSaveDeck2);
            this.Controls.Add(this.btnLoadDeck);
            this.Controls.Add(this.btnSaveDeck);
            this.Name = "SerializeCardsForm";
            this.Text = "Serialize Cards";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveDeck;
        private System.Windows.Forms.Button btnLoadDeck;
        private System.Windows.Forms.Button btnSaveDeck2;
        private System.Windows.Forms.Button btnLoadDeck2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCompareFiles;
        private System.Windows.Forms.Button btnHexDumper;
        private System.Windows.Forms.Button button2;
    }
}

