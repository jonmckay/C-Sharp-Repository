using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Quest
{
    public partial class QuestForm : Form
    {
        public QuestForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reads the location of the player, enemies, and any weapons currently in the dungeon
        /// and moves the PictureBoxes to match them.
        /// </summary>
        private void UpdateCharacters()
        {
            throw new NotImplementedException();
        }

        private void QuestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
