using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Go_Fish_Chapter_8
{
    public partial class GoFishForm : Form
    {
        public GoFishForm()
        {
            InitializeComponent();
        }

        private Game game;

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPlayerName.Text))
            {
                MessageBox.Show("Please enter your name", "Can't start the game yet");
                return;
            }
             game = new Game(tbPlayerName.Text, new List<string> { "Joe", "Bob" }, textProgress);
             btnStartGame.Enabled = false;
             tbPlayerName.Enabled = false;
             btnAskForCard.Enabled = true;
             UpdateForm();
        }
        
        private void UpdateForm()
        {
            lbPlayerHand.Items.Clear();
            foreach (String cardName in game.GetPlayerCardNames())
            {
                lbPlayerHand.Items.Add(cardName);
            }
            textBooks.Text = game.DescribeBooks();
            textProgress.Text += game.DescribePlayerHands();
            textProgress.SelectionStart = textProgress.Text.Length;
            textProgress.ScrollToCaret();
        }

        private void btnAskForCard_Click(object sender, EventArgs e)
        {
            textProgress.Text = "";
            if (lbPlayerHand.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a card");
                return;
            }
            if (game.PlayOneRound(lbPlayerHand.SelectedIndex))
            {
                textProgress.Text += "The winner is... " + game.GetWinnerName();
                textBooks.Text = game.DescribeBooks();
                btnAskForCard.Enabled = false;
            }
            else
            {
                UpdateForm();
            }

        }

    }
}
