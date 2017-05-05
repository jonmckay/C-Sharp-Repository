using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lumberjack_Chapter_8
{
    public partial class LumberjackForm : Form
    {
        Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();
        public LumberjackForm()
        {
            InitializeComponent();
        }

        private void btnAddFlapjacks_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (radCrispy.Checked == true)
            {
                food = Flapjack.Crispy;
            }
            else if(radSoggy.Checked == true)
            {
                food = Flapjack.Soggy;
            }
            else if (radBrowned.Checked == true)
            {
                food = Flapjack.Browned;
            }
            else
            {
                food = Flapjack.Banana;
            }

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjack(food, (int)nudFood.Value);

            RedrawList();
        }

        private void RedrawList()
        {
            int positionInQueue = 1;
            lbLine.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                lbLine.Items.Add(positionInQueue + ". " + lumberjack.Name + Environment.NewLine);
                positionInQueue++;
            }
            if (breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                tbOutput.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                tbOutput.Text = currentLumberjack.Name + " has " + currentLumberjack.FlajackCount + " flapjacks";
            }
            lbLine.Hide();
            lbLine.Show();
        }

        private void btnNextLumberjack_Click(object sender, EventArgs e)
        {
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            RedrawList();
        }

        private void btnAddLumberjack_Click(object sender, EventArgs e)
        {
            breakfastLine.Enqueue(new Lumberjack(tbLumberjackName.Text));
            tbLumberjackName.Text = "";
            RedrawList();
        }

    }
}
