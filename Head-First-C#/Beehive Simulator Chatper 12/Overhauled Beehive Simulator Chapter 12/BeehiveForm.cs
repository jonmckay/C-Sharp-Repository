using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overhauled_Beehive_Simulator_Chapter_12
{
    public partial class BeehiveForm : Form
    {
        private World world;
        private DateTime start = DateTime.Now;
        private DateTime end;
        private int framesRun = 0;
        private Random random = new Random();
        private Renderer renderer;

        private HiveForm hiveForm;
        private FieldForm fieldForm;

        public BeehiveForm()
        {
            InitializeComponent();
            world = new World(new BeeMessage(sendMessage));
            timer1.Interval = 50;   // Run every 50 milliseconds
            timer1.Tick += new EventHandler(RunFrame);  // We set the handler to our own method, RunFrame()
            timer1.Enabled = false; // Timer starts off
            UpdateStats(new TimeSpan());    // We also start out by updating stats, with a new TimeSpan (0 time elapsed)

            hiveForm = new HiveForm();
            fieldForm = new FieldForm();

            // Show the two forms
            MoveChildForms();
            hiveForm.Show(this);
            fieldForm.Show(this);
            ResetSimulator();
        }

        private void MoveChildForms()
        {
            hiveForm.Location = new Point(Location.X + Width + 10, Location.Y);
            fieldForm.Location = new Point(Location.X, Location.Y + Math.Max(Height, hiveForm.Height) + 10);
        }

        private void RunFrame(object sender, EventArgs e)
        {
            framesRun++;
            world.Go(random);
            end = DateTime.Now;
            TimeSpan frameDuration = end - start;
            start = end;
            UpdateStats(frameDuration);
            hiveForm.Invalidate();
            fieldForm.Invalidate();
        }

        private void UpdateStats(TimeSpan frameDuration)
        {
            Bees.Text = world.Bees.Count.ToString();
            Flowers.Text = world.Flowers.Count.ToString();
            HoneyInHive.Text = String.Format("{0:f3}", world.Hive.Honey);
            double nectar = 0;
            foreach (Flower flower in world.Flowers)
            {
                nectar += flower.Nectar;
            }
            NectarInFlowers.Text = String.Format("{0:f3}", nectar);
            FramesRun.Text = framesRun.ToString();
            double milliSeconds = frameDuration.TotalMilliseconds;

            /* The frame rate is the number of frames run per second. We're
             * using a TimeSpan object to store how long it took to run the
             * frame. We divide 1000 by the number of milliseconds it took to run the frame--that
             * gives us the total number of milliseconds it took to run the last frame.
             */
            if (milliSeconds != 0.0)
            {
                FrameRate.Text = string.Format("{0:f0} ({1:f1}ms)", 1000 / milliSeconds, milliSeconds);
            }
            else
            {
                FrameRate.Text = "N/A";
            }
        }

        public void sendMessage(int ID, string Message)
        {
            statusStrip1.Items[0].Text = "Bee #" + ID + ": " + Message;
            var beeGroups =
                from bee in world.Bees
                group bee by bee.CurrentState into beeGroup
                orderby beeGroup.Key
                select beeGroup;
            listBox1.Items.Clear();
            foreach (var group in beeGroups)
            {
                // Makes sure the plural is right. "1 bee" "3 bees"
                string s;
                if (group.Count() == 1)
                {
                    s = "";
                }
                else
                {
                    s = "s";
                }
                listBox1.Items.Add(group.Key.ToString() + ": " + group.Count() + " bee" + s);
                if (group.Key == BeeState.Idle && group.Count() == world.Bees.Count() && framesRun > 0)
                {
                    listBox1.Items.Add("Simulation ended: all bees are idle");
                    toolStrip1.Items[0].Text = "Simulation ended";
                    statusStrip1.Items[0].Text = "Simulation ended";
                    timer1.Enabled = false;
                }
            }
        }

        private void tsbStart_Click(object sender, EventArgs e)
        {
            // Start simulation
            if (timer1.Enabled)
            {
                tsbStart.Text = "Resume Simulation";
                timer1.Stop();
            }
            else
            {
                tsbStart.Text = "Pause Simulation";
                timer1.Start();
            }
        }

        private void tsbReset_Click(object sender, EventArgs e)
        {
            framesRun = 0;
            world = new World(new BeeMessage(sendMessage));
            if (!timer1.Enabled)
            {
                tsbStart.Text = "Start Simulation";
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            // Save a reference to the current world and framesRun. If There's a problem, we can revert to these and keep running
            World currentWorld = world;
            int currentFramesRun = framesRun;

            bool enabled = timer1.Enabled;
            if (enabled)
            {
                timer1.Stop();
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Simulator File (*.bees)|*.bees";
            openFileDialog.CheckPathExists = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.Title = "Choose a file with a simulation to load";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    using (Stream input = File.OpenRead(openFileDialog.FileName))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        world = (World)bf.Deserialize(input);
                        framesRun = (int)bf.Deserialize(input);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to read the simulator file\r\n" + ex.Message, "Bee Simulator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    world = currentWorld;
                    framesRun = currentFramesRun;
                }
            }

            world.Hive.MessageSender = new BeeMessage(sendMessage);
            foreach (Bee bee in world.Bees)
            {
                bee.MessageSender = new BeeMessage(sendMessage);
            }

            if (enabled)
            {
                timer1.Start();
            }

            renderer = new Renderer(world, hiveForm, fieldForm);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            bool enabled = timer1.Enabled;
            if (enabled)
            {
                timer1.Stop();
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Simulator File (*.bees)|*.bees";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.Title = "Choose a file to save the current simulation";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Stream output = File.OpenWrite(saveFileDialog.FileName))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(output, world);
                        bf.Serialize(output, framesRun);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to save the simulator file\r\n" + ex.Message, "Bee Simulator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (enabled)
            {
                timer1.Start();
            }

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void BeehiveForm_Move(object sender, EventArgs e)
        {
            MoveChildForms();
        }

        private void ResetSimulator()
        {
            framesRun = 0;
            world = new World(new BeeMessage(sendMessage));
            renderer = new Renderer(world, hiveForm, fieldForm);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            renderer.AnimateBees();
        }
    }
}
