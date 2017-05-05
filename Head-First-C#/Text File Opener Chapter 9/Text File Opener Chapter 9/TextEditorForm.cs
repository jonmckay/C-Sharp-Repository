using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_File_Opener_Chapter_9
{
    public partial class TextEditorForm : Form
    {
        private string name;

        public TextEditorForm()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = @"C:\Users\Jon\Desktop\GitHub Repo\C-Sharp-Repository\Text File Opener Chapter 9\Text File Opener Chapter 9";
            saveFileDialog1.Title = "DemoTitle.txt";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog1.FileName = "DemoTitle.txt";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox1.Text);
            }
        }
    }
}
