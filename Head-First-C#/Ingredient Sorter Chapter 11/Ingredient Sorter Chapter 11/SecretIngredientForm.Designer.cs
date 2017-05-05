namespace Ingredient_Sorter_Chapter_11
{
    partial class SecretIngredientForm
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
            this.btnGetIngredient = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSuzannesDelegate = new System.Windows.Forms.Button();
            this.btnAmysDelegate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetIngredient
            // 
            this.btnGetIngredient.Location = new System.Drawing.Point(12, 12);
            this.btnGetIngredient.Name = "btnGetIngredient";
            this.btnGetIngredient.Size = new System.Drawing.Size(134, 23);
            this.btnGetIngredient.TabIndex = 0;
            this.btnGetIngredient.Text = "Get the ingredient";
            this.btnGetIngredient.UseVisualStyleBackColor = true;
            this.btnGetIngredient.Click += new System.EventHandler(this.btnGetIngredient_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(152, 15);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // btnSuzannesDelegate
            // 
            this.btnSuzannesDelegate.Location = new System.Drawing.Point(12, 41);
            this.btnSuzannesDelegate.Name = "btnSuzannesDelegate";
            this.btnSuzannesDelegate.Size = new System.Drawing.Size(178, 23);
            this.btnSuzannesDelegate.TabIndex = 2;
            this.btnSuzannesDelegate.Text = "Get Suzanne\'s delegate";
            this.btnSuzannesDelegate.UseVisualStyleBackColor = true;
            this.btnSuzannesDelegate.Click += new System.EventHandler(this.btnSuzannesDelegate_Click);
            // 
            // btnAmysDelegate
            // 
            this.btnAmysDelegate.Location = new System.Drawing.Point(12, 70);
            this.btnAmysDelegate.Name = "btnAmysDelegate";
            this.btnAmysDelegate.Size = new System.Drawing.Size(178, 23);
            this.btnAmysDelegate.TabIndex = 3;
            this.btnAmysDelegate.Text = "Get Amy\'s delegate";
            this.btnAmysDelegate.UseVisualStyleBackColor = true;
            this.btnAmysDelegate.Click += new System.EventHandler(this.btnAmysDelegate_Click);
            // 
            // SecretIngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 109);
            this.Controls.Add(this.btnAmysDelegate);
            this.Controls.Add(this.btnSuzannesDelegate);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnGetIngredient);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SecretIngredientForm";
            this.Text = "Secret Ingredients";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetIngredient;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSuzannesDelegate;
        private System.Windows.Forms.Button btnAmysDelegate;
    }
}

