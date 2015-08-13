using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Testing_Program_Chapter_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            using (Graphics g = this.CreateGraphics())
            {
                g.DrawLine(Pens.Blue, 30, 10, 100, 45);
                g.FillRectangle(Brushes.SlateGray, new Rectangle(150, 15, 140, 90));
                g.DrawRectangle(Pens.SkyBlue, new Rectangle(150, 15, 140, 90));
                g.FillEllipse(Brushes.DarkGray, new Rectangle(45, 65, 200, 100));
                g.FillEllipse(Brushes.Silver, new Rectangle(40, 60, 200, 100));

                using (Font arial24Bold = new Font("Arial", 24, FontStyle.Bold))
                {
                    g.DrawString("Hi there!", arial24Bold, Brushes.Red, 50, 75);
                }
            }
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.FillRectangle(Brushes.SkyBlue, ClientRectangle);
                g.DrawImage(Properties.Resources.Bee_animation_1, 50, 20, 75, 75);
                g.DrawImage(Properties.Resources.Flower, 10, 130, 100, 150);

                using (Pen thickBlackPen = new Pen(Brushes.Black, 3.0F)) 
                {
                    g.DrawLines(thickBlackPen, new Point[] { new Point(130, 110), new Point(120, 160), new Point(155, 163) });
                    g.DrawCurve(thickBlackPen, new Point[] { new Point(120, 160), new Point(175, 120), new Point(215, 70) });
                }

                using (Font font = new Font("Arial", 16, FontStyle.Italic))
                {
                    SizeF size = g.MeasureString("Nectar here", font);
                    g.DrawString("Nectar here", font, Brushes.Red, new Point(215 - (int)size.Width / 2, 70 - (int)size.Height));
                }
            }
        }


    }
}
