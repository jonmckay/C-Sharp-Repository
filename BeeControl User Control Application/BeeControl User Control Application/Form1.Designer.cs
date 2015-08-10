namespace BeeControl_User_Control_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.beeControl1 = new BeeControl_User_Control_Application.BeeControl();
            this.SuspendLayout();
            // 
            // beeControl1
            // 
            this.beeControl1.BackColor = System.Drawing.Color.Transparent;
            this.beeControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("beeControl1.BackgroundImage")));
            this.beeControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beeControl1.Location = new System.Drawing.Point(52, 58);
            this.beeControl1.Name = "beeControl1";
            this.beeControl1.Size = new System.Drawing.Size(150, 150);
            this.beeControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.beeControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BeeControl beeControl1;
    }
}

