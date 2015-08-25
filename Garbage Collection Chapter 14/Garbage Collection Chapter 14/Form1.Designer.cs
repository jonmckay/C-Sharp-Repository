namespace Garbage_Collection_Chapter_14
{
    partial class CloneForm
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
            this.btnCloneOne = new System.Windows.Forms.Button();
            this.btnCloneTwo = new System.Windows.Forms.Button();
            this.btnGC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloneOne
            // 
            this.btnCloneOne.Location = new System.Drawing.Point(12, 12);
            this.btnCloneOne.Name = "btnCloneOne";
            this.btnCloneOne.Size = new System.Drawing.Size(88, 23);
            this.btnCloneOne.TabIndex = 0;
            this.btnCloneOne.Text = "Clone #1";
            this.btnCloneOne.UseVisualStyleBackColor = true;
            this.btnCloneOne.Click += new System.EventHandler(this.btnCloneOne_Click);
            // 
            // btnCloneTwo
            // 
            this.btnCloneTwo.Location = new System.Drawing.Point(12, 41);
            this.btnCloneTwo.Name = "btnCloneTwo";
            this.btnCloneTwo.Size = new System.Drawing.Size(88, 23);
            this.btnCloneTwo.TabIndex = 1;
            this.btnCloneTwo.Text = "Clone #2";
            this.btnCloneTwo.UseVisualStyleBackColor = true;
            this.btnCloneTwo.Click += new System.EventHandler(this.btnCloneTwo_Click);
            // 
            // btnGC
            // 
            this.btnGC.Location = new System.Drawing.Point(12, 70);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(88, 23);
            this.btnGC.TabIndex = 2;
            this.btnGC.Text = "GC";
            this.btnGC.UseVisualStyleBackColor = true;
            this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
            // 
            // CloneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(116, 106);
            this.Controls.Add(this.btnGC);
            this.Controls.Add(this.btnCloneTwo);
            this.Controls.Add(this.btnCloneOne);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CloneForm";
            this.Text = "Clones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloneOne;
        private System.Windows.Forms.Button btnCloneTwo;
        private System.Windows.Forms.Button btnGC;
    }
}

