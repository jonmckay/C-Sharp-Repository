namespace GuyApplication
{
    partial class Form1
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
            this.ReceiveCash = new System.Windows.Forms.Button();
            this.GiveCash = new System.Windows.Forms.Button();
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.btnSaveJoe = new System.Windows.Forms.Button();
            this.btnLoadJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReceiveCash
            // 
            this.ReceiveCash.Location = new System.Drawing.Point(15, 92);
            this.ReceiveCash.Name = "ReceiveCash";
            this.ReceiveCash.Size = new System.Drawing.Size(92, 49);
            this.ReceiveCash.TabIndex = 0;
            this.ReceiveCash.Text = "Give $10 to Joe";
            this.ReceiveCash.UseVisualStyleBackColor = true;
            this.ReceiveCash.Click += new System.EventHandler(this.ReceiveCash_Click);
            // 
            // GiveCash
            // 
            this.GiveCash.Location = new System.Drawing.Point(113, 92);
            this.GiveCash.Name = "GiveCash";
            this.GiveCash.Size = new System.Drawing.Size(92, 49);
            this.GiveCash.TabIndex = 1;
            this.GiveCash.Text = "Receive $5 from Bob";
            this.GiveCash.UseVisualStyleBackColor = true;
            this.GiveCash.Click += new System.EventHandler(this.GiveCash_Click);
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Location = new System.Drawing.Point(12, 9);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(61, 13);
            this.joesCashLabel.TabIndex = 2;
            this.joesCashLabel.Text = "Joe Has $0";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Location = new System.Drawing.Point(12, 33);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(61, 13);
            this.bobsCashLabel.TabIndex = 3;
            this.bobsCashLabel.Text = "Bob has $0";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(12, 58);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(89, 13);
            this.bankCashLabel.TabIndex = 4;
            this.bankCashLabel.Text = "The Bank has $0";
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(15, 147);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(92, 49);
            this.joeGivesToBob.TabIndex = 5;
            this.joeGivesToBob.Text = "Joe Gives $10 to Bob";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(113, 147);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(92, 49);
            this.bobGivesToJoe.TabIndex = 6;
            this.bobGivesToJoe.Text = "Bob gives $5 to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // btnSaveJoe
            // 
            this.btnSaveJoe.Location = new System.Drawing.Point(15, 223);
            this.btnSaveJoe.Name = "btnSaveJoe";
            this.btnSaveJoe.Size = new System.Drawing.Size(92, 23);
            this.btnSaveJoe.TabIndex = 7;
            this.btnSaveJoe.Text = "Save Joe";
            this.btnSaveJoe.UseVisualStyleBackColor = true;
            this.btnSaveJoe.Click += new System.EventHandler(this.btnSaveJoe_Click);
            // 
            // btnLoadJoe
            // 
            this.btnLoadJoe.Location = new System.Drawing.Point(113, 223);
            this.btnLoadJoe.Name = "btnLoadJoe";
            this.btnLoadJoe.Size = new System.Drawing.Size(92, 23);
            this.btnLoadJoe.TabIndex = 8;
            this.btnLoadJoe.Text = "Load Joe";
            this.btnLoadJoe.UseVisualStyleBackColor = true;
            this.btnLoadJoe.Click += new System.EventHandler(this.btnLoadJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 269);
            this.Controls.Add(this.btnLoadJoe);
            this.Controls.Add(this.btnSaveJoe);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Controls.Add(this.GiveCash);
            this.Controls.Add(this.ReceiveCash);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReceiveCash;
        private System.Windows.Forms.Button GiveCash;
        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
        private System.Windows.Forms.Button btnSaveJoe;
        private System.Windows.Forms.Button btnLoadJoe;
    }
}

