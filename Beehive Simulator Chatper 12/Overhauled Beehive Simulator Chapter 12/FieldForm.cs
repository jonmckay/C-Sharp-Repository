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
    public partial class FieldForm : Form
    {
        public Renderer renderer { get; set; }

        public FieldForm()
        {
            InitializeComponent();
        }

        private void FieldForm_Paint(object sender, PaintEventArgs e)
        {
            renderer.PaintField(e.Graphics);
        }
    }
}
