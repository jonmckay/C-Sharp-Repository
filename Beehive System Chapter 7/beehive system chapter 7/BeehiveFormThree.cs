using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive_System_Chapter_7
{
    public partial class BeehiveFormThree : Form
    {
        private GroupBox groupBox1;
        private Button assignJob;
        private Label label2;
        private Label label1;
        private NumericUpDown shifts;
        private ComboBox workerBeeJob;
        private TextBox report;
        private Button nextShift;
        //Queen queen;
        public BeehiveFormThree()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            //workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" },175);
            //workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" },114);
            //workers[2] = new Worker(new string[] { "Hive maintenance", "String patrol" },149);
            //workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
            //            "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" },155);
            //queen = new Queen(workers);
        }

        private void nextShift_Click(object sender, EventArgs e)
        {

        }

        private void assignJob_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assignJob = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.report = new System.Windows.Forms.TextBox();
            this.nextShift = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignJob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker bee Assignments";
            // 
            // assignJob
            // 
            this.assignJob.Location = new System.Drawing.Point(6, 54);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(191, 23);
            this.assignJob.TabIndex = 4;
            this.assignJob.Text = "Assign this job to a bee";
            this.assignJob.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shifts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Worker bee job";
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(209, 29);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(46, 20);
            this.shifts.TabIndex = 1;
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Hive maintenance",
            "Egg care",
            "Baby bee tutoring",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(6, 29);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(191, 21);
            this.workerBeeJob.TabIndex = 0;
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(12, 101);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(351, 167);
            this.report.TabIndex = 4;
            // 
            // nextShift
            // 
            this.nextShift.Location = new System.Drawing.Point(283, 14);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(73, 71);
            this.nextShift.TabIndex = 3;
            this.nextShift.Text = "Work the next shift";
            this.nextShift.UseVisualStyleBackColor = true;
            // 
            // BeehiveFormThree
            // 
            this.ClientSize = new System.Drawing.Size(375, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.report);
            this.Controls.Add(this.nextShift);
            this.Name = "BeehiveFormThree";
            this.Text = "Behive Form Three";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
