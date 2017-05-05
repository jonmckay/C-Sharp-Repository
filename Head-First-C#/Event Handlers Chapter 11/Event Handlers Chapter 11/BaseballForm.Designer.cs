namespace Event_Handlers_Chapter_11
{
    partial class BaseballForm
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
            this.btnPlayBall = new System.Windows.Forms.Button();
            this.nudTrajectory = new System.Windows.Forms.NumericUpDown();
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrajectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlayBall
            // 
            this.btnPlayBall.Location = new System.Drawing.Point(75, 64);
            this.btnPlayBall.Name = "btnPlayBall";
            this.btnPlayBall.Size = new System.Drawing.Size(75, 23);
            this.btnPlayBall.TabIndex = 0;
            this.btnPlayBall.Text = "Play ball!";
            this.btnPlayBall.UseVisualStyleBackColor = true;
            this.btnPlayBall.Click += new System.EventHandler(this.btnPlayBall_Click);
            // 
            // nudTrajectory
            // 
            this.nudTrajectory.Location = new System.Drawing.Point(75, 12);
            this.nudTrajectory.Name = "nudTrajectory";
            this.nudTrajectory.Size = new System.Drawing.Size(94, 20);
            this.nudTrajectory.TabIndex = 1;
            this.nudTrajectory.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudDistance
            // 
            this.nudDistance.Location = new System.Drawing.Point(75, 38);
            this.nudDistance.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.Size = new System.Drawing.Size(94, 20);
            this.nudDistance.TabIndex = 2;
            this.nudDistance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trajectory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Distance";
            // 
            // BaseballForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 100);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDistance);
            this.Controls.Add(this.nudTrajectory);
            this.Controls.Add(this.btnPlayBall);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseballForm";
            this.Text = "Baseball";
            ((System.ComponentModel.ISupportInitialize)(this.nudTrajectory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayBall;
        private System.Windows.Forms.NumericUpDown nudTrajectory;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

