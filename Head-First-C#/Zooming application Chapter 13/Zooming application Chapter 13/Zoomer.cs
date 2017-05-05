using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zooming_application_Chapter_13
{
    public partial class Zoomer : UserControl
    {
        private Bitmap photo = new Bitmap(Properties.Resources.fry);

        public Zoomer()
        {
            InitializeComponent();
            using (Graphics g = this.CreateGraphics())
            {
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, this.Width, this.Height));
                Rectangle rectangle = new Rectangle(10, 10, trackBar1.Value, trackBar2.Value);
                g.DrawImage(photo, rectangle);
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Zoomer_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, this.Width, this.Height));
                Rectangle rectangle = new Rectangle(10, 10,trackBar1.Value, trackBar2.Value);
                g.DrawImage(photo, rectangle);
            }
        }
    }
}
