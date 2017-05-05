using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overhauled_Beehive_Simulator_Chapter_12
{
    public partial class HiveForm : Form
    {
        public Renderer renderer { get; set; }

        public HiveForm()
        {
            InitializeComponent();
        }

        private void HiveForm_Paint(object sender, PaintEventArgs e)
        {
            renderer.PaintHive(e.Graphics);
        }

    }
}
