namespace House_Project_Chapter_7
{
    partial class HouseForm
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
            this.btnGoHere = new System.Windows.Forms.Button();
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.btnGoThroughDoor = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGoHere
            // 
            this.btnGoHere.Location = new System.Drawing.Point(12, 214);
            this.btnGoHere.Name = "btnGoHere";
            this.btnGoHere.Size = new System.Drawing.Size(89, 23);
            this.btnGoHere.TabIndex = 0;
            this.btnGoHere.Text = "Go here:";
            this.btnGoHere.UseVisualStyleBackColor = true;
            this.btnGoHere.Click += new System.EventHandler(this.btnGoHere_Click);
            // 
            // cbLocations
            // 
            this.cbLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(107, 214);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(263, 21);
            this.cbLocations.TabIndex = 1;
            // 
            // btnGoThroughDoor
            // 
            this.btnGoThroughDoor.Location = new System.Drawing.Point(12, 244);
            this.btnGoThroughDoor.Name = "btnGoThroughDoor";
            this.btnGoThroughDoor.Size = new System.Drawing.Size(358, 23);
            this.btnGoThroughDoor.TabIndex = 2;
            this.btnGoThroughDoor.Text = "Go through the door";
            this.btnGoThroughDoor.UseVisualStyleBackColor = true;
            this.btnGoThroughDoor.Click += new System.EventHandler(this.btnGoThroughDoor_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 12);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(358, 196);
            this.tbDescription.TabIndex = 3;
            // 
            // HouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 279);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.btnGoThroughDoor);
            this.Controls.Add(this.cbLocations);
            this.Controls.Add(this.btnGoHere);
            this.Name = "HouseForm";
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoHere;
        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.Button btnGoThroughDoor;
        private System.Windows.Forms.TextBox tbDescription;
    }
}

