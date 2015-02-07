using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Overloading_Chapter_8
{
    public partial class CardForm : Form
    {
        public CardForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Card cardToCheck = new Card(Card.suits.Clubs, Card.values.Three);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Card.suits.Clubs);
            MessageBox.Show(doesItMatch.ToString());

        }
    }
}
