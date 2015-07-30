namespace Timer_Application_Chapter_12
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
            this.components = new System.ComponentModel.Container();
            this.toggleEnabled = new System.Windows.Forms.Button();
            this.startTimer = new System.Windows.Forms.Button();
            this.stopTimer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // toggleEnabled
            // 
            this.toggleEnabled.Location = new System.Drawing.Point(12, 12);
            this.toggleEnabled.Name = "toggleEnabled";
            this.toggleEnabled.Size = new System.Drawing.Size(75, 23);
            this.toggleEnabled.TabIndex = 0;
            this.toggleEnabled.Text = "Toggle Enabled";
            this.toggleEnabled.UseVisualStyleBackColor = true;
            this.toggleEnabled.Click += new System.EventHandler(this.toggleEnabled_Click);
            // 
            // startTimer
            // 
            this.startTimer.Location = new System.Drawing.Point(93, 12);
            this.startTimer.Name = "startTimer";
            this.startTimer.Size = new System.Drawing.Size(75, 23);
            this.startTimer.TabIndex = 1;
            this.startTimer.Text = "Start";
            this.startTimer.UseVisualStyleBackColor = true;
            this.startTimer.Click += new System.EventHandler(this.startTimer_Click);
            // 
            // stopTimer
            // 
            this.stopTimer.Location = new System.Drawing.Point(174, 12);
            this.stopTimer.Name = "stopTimer";
            this.stopTimer.Size = new System.Drawing.Size(75, 23);
            this.stopTimer.TabIndex = 2;
            this.stopTimer.Text = "Stop";
            this.stopTimer.UseVisualStyleBackColor = true;
            this.stopTimer.Click += new System.EventHandler(this.stopTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 49);
            this.Controls.Add(this.stopTimer);
            this.Controls.Add(this.startTimer);
            this.Controls.Add(this.toggleEnabled);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toggleEnabled;
        private System.Windows.Forms.Button startTimer;
        private System.Windows.Forms.Button stopTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

