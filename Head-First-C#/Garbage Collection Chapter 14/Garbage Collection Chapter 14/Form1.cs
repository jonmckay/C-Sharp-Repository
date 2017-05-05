using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garbage_Collection_Chapter_14
{
    public partial class CloneForm : Form
    {
        public CloneForm()
        {
            InitializeComponent();
        }

        private void btnCloneOne_Click(object sender, EventArgs e)
        {
            using (Clone clone1 = new Clone(1))
            {
                // Do nothing!
            }
        }

        private void btnCloneTwo_Click(object sender, EventArgs e)
        {
            Clone clone2 = new Clone(2);
            clone2 = null;
        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
