using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Chapter_8
{
    public partial class CardForm : Form
    {
        public CardForm()
        {
            InitializeComponent();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Card card = new Card((Card.suits)random.Next(4), (Card.values)random.Next(1, 14));
            MessageBox.Show(card.Name);
        }
    }
}
