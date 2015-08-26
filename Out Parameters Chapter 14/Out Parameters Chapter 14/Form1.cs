using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Out_Parameters_Chapter_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        public int ReturnThreeValues(out double half, out int twice)
        {
            int value = random.Next(1000);
            half = ((double)value) / 2;
            twice = value * 2;
            return value;
        }

        public void ModifyAnIntAndButton(ref int value, ref Button button)
        {
            int i = value;
            i *= 5;
            value = i - 3;
            button = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            double b;
            int c;
            a = ReturnThreeValues(out b, out c);
            Console.WriteLine("value = {0}, half = {1}, double = {2}", a, b, c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int q = 100;
            Button b = button3;
            ModifyAnIntAndButton(ref q, ref b);
            Console.WriteLine("q = {0}, b.Text = {1}", q, b.Text);
        }
    }
}
