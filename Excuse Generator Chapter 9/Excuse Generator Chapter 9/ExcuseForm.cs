using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excuse_Generator_Chapter_9
{
    public partial class ExcuseForm : Form
    {
        Excuse currentExcuse = new Excuse();
        Random random = new Random();
        private bool formChanged = false;
        private string selectedFolder = "";

        public ExcuseForm()
        {
            InitializeComponent();
            currentExcuse.LastUsed = LastUsed.Value;
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            // User selects a folder
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                currentExcuse.ExcusePath = fbd.SelectedPath;
                selectedFolder = fbd.SelectedPath;
                btnSave.Enabled = true;
                btnOpen.Enabled = true;
                btnRandom.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(currentExcuse.Description) || String.IsNullOrEmpty(currentExcuse.Results))
            {
                MessageBox.Show("Please specify an excuse and a result", "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();

            // Set the initial directory to the folder selected
            sfd.InitialDirectory = selectedFolder;

            sfd.FileName = tbExcuse.Text;
            currentExcuse.Description = tbExcuse.Text;
            currentExcuse.Results = tbResults.Text;

            sfd.Filter = "Excuse files (*.excuse) |*.excuse|All files (*.*)|*.*";

            // Open up a save file dialog
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                currentExcuse.Save(sfd.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse Written");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (CheckChanged())
            {
                // Set initial directory
                ofd.InitialDirectory = selectedFolder;

                ofd.Filter = "Excuse files (*.excuse) |*.excuse|All Files (*.*)|*.*";

                ofd.FileName = tbExcuse.Text + ".excuse";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    bool clearForm = false;
                    try
                    {
                        currentExcuse = new Excuse(ofd.FileName);
                        try
                        {
                            UpdateForm(false);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            MessageBox.Show("The excuse file '" + ofd.FileName + "' had some invalid data", "Unable to open the excuse");
                            clearForm = true;
                        }
                    }
                    catch (SerializationException ex)
                    {
                        MessageBox.Show("An error occurred while opening the excuse '" + ofd.FileName + "'\n" + ex.Message, "Unable to open the excuse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearForm = true;
                    }
                    finally
                    {
                        if (clearForm)
                        {
                            tbExcuse.Text = "";
                            tbResults.Text = "";
                            LastUsed.Value = DateTime.Now;
                        }
                    }
                }
            }
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show("The current excuse has not been saved. Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            string[] fileNames = Directory.GetFiles(selectedFolder, "*.excuse");
            if (fileNames.Length == 0)
            {
                MessageBox.Show("Please specify a folder with excuse files in it", "No excuse files found");
            }
            else
            {
                try
                {
                    if (CheckChanged())
                    {
                        currentExcuse = new Excuse(random, selectedFolder);
                    }
                }
                catch (SerializationException)
                {
                    currentExcuse = new Excuse();
                    currentExcuse.Description = "";
                    currentExcuse.Results = "";
                    currentExcuse.LastUsed = DateTime.Now;
                    MessageBox.Show("Your excuse file was invalid.", "Unable to open a random excuse");
                }
                finally
                {
                    UpdateForm(false);
                }
            }
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.tbExcuse.Text = currentExcuse.Description;
                this.tbResults.Text = currentExcuse.Results;
                this.LastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    lblFileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                    this.Text = "Excuse Manager";
                }
                else
                {
                    this.Text = "Excuse Manager*";
                }
                this.formChanged = changed;
            }
        }

        private void tbExcuse_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = tbExcuse.Text;
            UpdateForm(true);
        }

        private void tbResults_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = tbResults.Text;
            UpdateForm(true);
        }

        private void LastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = LastUsed.Value;
            UpdateForm(true);
        }
    }
}
