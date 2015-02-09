namespace Lumberjack_Chapter_8
{
    partial class LumberjackForm
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
            this.tbLumberjackName = new System.Windows.Forms.TextBox();
            this.btnAddLumberjack = new System.Windows.Forms.Button();
            this.nudFood = new System.Windows.Forms.NumericUpDown();
            this.radCrispy = new System.Windows.Forms.RadioButton();
            this.radSoggy = new System.Windows.Forms.RadioButton();
            this.radBrowned = new System.Windows.Forms.RadioButton();
            this.radBanana = new System.Windows.Forms.RadioButton();
            this.btnAddFlapjacks = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnNextLumberjack = new System.Windows.Forms.Button();
            this.lbLine = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFood)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lumberjack name";
            // 
            // tbLumberjackName
            // 
            this.tbLumberjackName.Location = new System.Drawing.Point(147, 19);
            this.tbLumberjackName.Name = "tbLumberjackName";
            this.tbLumberjackName.Size = new System.Drawing.Size(131, 22);
            this.tbLumberjackName.TabIndex = 1;
            // 
            // btnAddLumberjack
            // 
            this.btnAddLumberjack.Location = new System.Drawing.Point(24, 47);
            this.btnAddLumberjack.Name = "btnAddLumberjack";
            this.btnAddLumberjack.Size = new System.Drawing.Size(254, 27);
            this.btnAddLumberjack.TabIndex = 2;
            this.btnAddLumberjack.Text = "Add lumberjack";
            this.btnAddLumberjack.UseVisualStyleBackColor = true;
            this.btnAddLumberjack.Click += new System.EventHandler(this.btnAddLumberjack_Click);
            // 
            // nudFood
            // 
            this.nudFood.Location = new System.Drawing.Point(147, 107);
            this.nudFood.Name = "nudFood";
            this.nudFood.Size = new System.Drawing.Size(95, 22);
            this.nudFood.TabIndex = 4;
            // 
            // radCrispy
            // 
            this.radCrispy.AutoSize = true;
            this.radCrispy.Location = new System.Drawing.Point(147, 135);
            this.radCrispy.Name = "radCrispy";
            this.radCrispy.Size = new System.Drawing.Size(68, 21);
            this.radCrispy.TabIndex = 5;
            this.radCrispy.TabStop = true;
            this.radCrispy.Text = "Crispy";
            this.radCrispy.UseVisualStyleBackColor = true;
            // 
            // radSoggy
            // 
            this.radSoggy.AutoSize = true;
            this.radSoggy.Location = new System.Drawing.Point(147, 162);
            this.radSoggy.Name = "radSoggy";
            this.radSoggy.Size = new System.Drawing.Size(69, 21);
            this.radSoggy.TabIndex = 6;
            this.radSoggy.TabStop = true;
            this.radSoggy.Text = "Soggy";
            this.radSoggy.UseVisualStyleBackColor = true;
            // 
            // radBrowned
            // 
            this.radBrowned.AutoSize = true;
            this.radBrowned.Location = new System.Drawing.Point(147, 189);
            this.radBrowned.Name = "radBrowned";
            this.radBrowned.Size = new System.Drawing.Size(84, 21);
            this.radBrowned.TabIndex = 7;
            this.radBrowned.TabStop = true;
            this.radBrowned.Text = "Browned";
            this.radBrowned.UseVisualStyleBackColor = true;
            // 
            // radBanana
            // 
            this.radBanana.AutoSize = true;
            this.radBanana.Location = new System.Drawing.Point(147, 216);
            this.radBanana.Name = "radBanana";
            this.radBanana.Size = new System.Drawing.Size(78, 21);
            this.radBanana.TabIndex = 8;
            this.radBanana.TabStop = true;
            this.radBanana.Text = "Banana";
            this.radBanana.UseVisualStyleBackColor = true;
            // 
            // btnAddFlapjacks
            // 
            this.btnAddFlapjacks.Location = new System.Drawing.Point(147, 243);
            this.btnAddFlapjacks.Name = "btnAddFlapjacks";
            this.btnAddFlapjacks.Size = new System.Drawing.Size(171, 27);
            this.btnAddFlapjacks.TabIndex = 9;
            this.btnAddFlapjacks.Text = "Add flapjacks";
            this.btnAddFlapjacks.UseVisualStyleBackColor = true;
            this.btnAddFlapjacks.Click += new System.EventHandler(this.btnAddFlapjacks_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNextLumberjack);
            this.groupBox1.Controls.Add(this.tbOutput);
            this.groupBox1.Location = new System.Drawing.Point(139, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 339);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed a lumberjack";
            // 
            // tbOutput
            // 
            this.tbOutput.BackColor = System.Drawing.SystemColors.Control;
            this.tbOutput.Location = new System.Drawing.Point(8, 196);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(171, 68);
            this.tbOutput.TabIndex = 0;
            // 
            // btnNextLumberjack
            // 
            this.btnNextLumberjack.Location = new System.Drawing.Point(6, 306);
            this.btnNextLumberjack.Name = "btnNextLumberjack";
            this.btnNextLumberjack.Size = new System.Drawing.Size(173, 27);
            this.btnNextLumberjack.TabIndex = 1;
            this.btnNextLumberjack.Text = "Next lumberjack";
            this.btnNextLumberjack.UseVisualStyleBackColor = true;
            this.btnNextLumberjack.Click += new System.EventHandler(this.btnNextLumberjack_Click);
            // 
            // lbLine
            // 
            this.lbLine.FormattingEnabled = true;
            this.lbLine.ItemHeight = 16;
            this.lbLine.Location = new System.Drawing.Point(5, 134);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(128, 276);
            this.lbLine.TabIndex = 11;
            // 
            // LumberjackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 431);
            this.Controls.Add(this.lbLine);
            this.Controls.Add(this.btnAddFlapjacks);
            this.Controls.Add(this.radBanana);
            this.Controls.Add(this.radBrowned);
            this.Controls.Add(this.radSoggy);
            this.Controls.Add(this.radCrispy);
            this.Controls.Add(this.nudFood);
            this.Controls.Add(this.btnAddLumberjack);
            this.Controls.Add(this.tbLumberjackName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "LumberjackForm";
            this.Text = "Breakfast for Lumberjacks";
            ((System.ComponentModel.ISupportInitialize)(this.nudFood)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLumberjackName;
        private System.Windows.Forms.Button btnAddLumberjack;
        private System.Windows.Forms.NumericUpDown nudFood;
        private System.Windows.Forms.RadioButton radCrispy;
        private System.Windows.Forms.RadioButton radSoggy;
        private System.Windows.Forms.RadioButton radBrowned;
        private System.Windows.Forms.RadioButton radBanana;
        private System.Windows.Forms.Button btnAddFlapjacks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNextLumberjack;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.ListBox lbLine;
    }
}

