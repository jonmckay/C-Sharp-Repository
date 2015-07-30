namespace Beehive_Simulator_Chapter_12
{
    partial class BeehiveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeehiveForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbStart = new System.Windows.Forms.ToolStripButton();
            this.tsbReset = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Bees = new System.Windows.Forms.Label();
            this.lblNumOfBees = new System.Windows.Forms.Label();
            this.Flowers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HoneyInHive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NectarInFlowers = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FramesRun = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FrameRate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStart,
            this.tsbReset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbStart
            // 
            this.tsbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbStart.Image = ((System.Drawing.Image)(resources.GetObject("tsbStart.Image")));
            this.tsbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStart.Name = "tsbStart";
            this.tsbStart.Size = new System.Drawing.Size(95, 22);
            this.tsbStart.Text = "Start Simulation";
            this.tsbStart.Click += new System.EventHandler(this.tsbStart_Click);
            // 
            // tsbReset
            // 
            this.tsbReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReset.Image = ((System.Drawing.Image)(resources.GetObject("tsbReset.Image")));
            this.tsbReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReset.Name = "tsbReset";
            this.tsbReset.Size = new System.Drawing.Size(39, 22);
            this.tsbReset.Text = "Reset";
            this.tsbReset.Click += new System.EventHandler(this.tsbReset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 164);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(105, 17);
            this.tsslStatus.Text = "Simulation paused";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Bees, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNumOfBees, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Flowers, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.HoneyInHive, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.NectarInFlowers, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.FramesRun, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.FrameRate, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 139);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Bees
            // 
            this.Bees.AutoSize = true;
            this.Bees.Location = new System.Drawing.Point(145, 0);
            this.Bees.Name = "Bees";
            this.Bees.Size = new System.Drawing.Size(31, 13);
            this.Bees.TabIndex = 2;
            this.Bees.Text = "Bees";
            // 
            // lblNumOfBees
            // 
            this.lblNumOfBees.Location = new System.Drawing.Point(3, 0);
            this.lblNumOfBees.Name = "lblNumOfBees";
            this.lblNumOfBees.Size = new System.Drawing.Size(46, 18);
            this.lblNumOfBees.TabIndex = 0;
            this.lblNumOfBees.Text = "# Bees";
            // 
            // Flowers
            // 
            this.Flowers.AutoSize = true;
            this.Flowers.Location = new System.Drawing.Point(145, 20);
            this.Flowers.Name = "Flowers";
            this.Flowers.Size = new System.Drawing.Size(43, 13);
            this.Flowers.TabIndex = 3;
            this.Flowers.Text = "Flowers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Flowers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total honey in the hive";
            // 
            // HoneyInHive
            // 
            this.HoneyInHive.AutoSize = true;
            this.HoneyInHive.Location = new System.Drawing.Point(145, 40);
            this.HoneyInHive.Name = "HoneyInHive";
            this.HoneyInHive.Size = new System.Drawing.Size(69, 13);
            this.HoneyInHive.TabIndex = 5;
            this.HoneyInHive.Text = "HoneyInHive";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total nectar in the field";
            // 
            // NectarInFlowers
            // 
            this.NectarInFlowers.AutoSize = true;
            this.NectarInFlowers.Location = new System.Drawing.Point(145, 60);
            this.NectarInFlowers.Name = "NectarInFlowers";
            this.NectarInFlowers.Size = new System.Drawing.Size(84, 13);
            this.NectarInFlowers.TabIndex = 7;
            this.NectarInFlowers.Text = "NectarInFlowers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Frames run";
            // 
            // FramesRun
            // 
            this.FramesRun.AutoSize = true;
            this.FramesRun.Location = new System.Drawing.Point(145, 80);
            this.FramesRun.Name = "FramesRun";
            this.FramesRun.Size = new System.Drawing.Size(64, 13);
            this.FramesRun.TabIndex = 9;
            this.FramesRun.Text = "Frames Run";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Frame rate";
            // 
            // FrameRate
            // 
            this.FrameRate.AutoSize = true;
            this.FrameRate.Location = new System.Drawing.Point(145, 100);
            this.FrameRate.Name = "FrameRate";
            this.FrameRate.Size = new System.Drawing.Size(59, 13);
            this.FrameRate.TabIndex = 11;
            this.FrameRate.Text = "FrameRate";
            // 
            // BeehiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 186);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "BeehiveForm";
            this.Text = "Beehive Simulator";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbStart;
        private System.Windows.Forms.ToolStripButton tsbReset;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNumOfBees;
        private System.Windows.Forms.Label Bees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Flowers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label HoneyInHive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label NectarInFlowers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label FramesRun;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label FrameRate;
        private System.Windows.Forms.Timer timer1;
    }
}

