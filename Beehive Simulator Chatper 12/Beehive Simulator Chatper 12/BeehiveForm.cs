using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive_Simulator_Chapter_12
{
    public partial class BeehiveForm : Form
    {
        private World world;
        private DateTime start = DateTime.Now;
        private DateTime end;
        private int framesRun = 0;
        private Random random = new Random();

        public BeehiveForm()
        {
            InitializeComponent();


            world = new World(new BeeMessage(sendMessage));
            timer1.Interval = 50;   // Run every 50 milliseconds
            timer1.Tick += new EventHandler(RunFrame);  // We set the handler to our own method, RunFrame()
            timer1.Enabled = false; // Timer starts off
            UpdateStats(new TimeSpan());    // We also start out by updating stats, with a new TimeSpan (0 time elapsed)
        }

        private void RunFrame(object sender, EventArgs e)
        {
            framesRun++;
            world.Go(random);
            end = DateTime.Now;
            TimeSpan frameDuration = end - start;
            start = end;
            UpdateStats(frameDuration);
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
    }
}
