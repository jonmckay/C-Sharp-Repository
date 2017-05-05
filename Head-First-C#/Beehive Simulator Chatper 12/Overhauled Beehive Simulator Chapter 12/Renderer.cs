using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overhauled_Beehive_Simulator_Chapter_12
{
    public class Renderer
    {
        /*************************************
        * FIELDS AND PROPERTIES
        *************************************/
        private World world;
        private HiveForm hiveForm;
        private FieldForm fieldForm;

        private List<Flower> deadFlowers = new List<Flower>();
        private List<Bee> retiredBees = new List<Bee>();

        private int cell = 0;
        private int frame = 0;

        private Bitmap HiveInside;
        private Bitmap HiveOutSide;
        private Bitmap Flower;

        private Bitmap[] BeeAnimationLarge;
        private Bitmap[] BeeAnimationSmall;


        /*************************************
        * CONSTRUCTORS
        *************************************/

        public Renderer(World world, HiveForm hiveForm, FieldForm fieldForm)
        {
            BeeAnimationLarge = new Bitmap[4];
            BeeAnimationSmall = new Bitmap[4];
            this.world = world;
            this.hiveForm = hiveForm;
            this.fieldForm = fieldForm;
            hiveForm.renderer = this;
            fieldForm.renderer = this;
            InitializeImages();
        }

        /*************************************
        * FUNCTIONS
        *************************************/

        public static Bitmap ResizeImage(Bitmap picture, int width, int height)
        {
            Bitmap resizedPicture = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedPicture))
            {
                graphics.DrawImage(picture, 0, 0, width, height);
            }
            return resizedPicture;
        }

        private void InitializeImages()
        {
            HiveOutSide = ResizeImage(Properties.Resources.Hive__outside_, 85, 100);
            Flower = ResizeImage(Properties.Resources.Flower, 75, 75);
            HiveInside = ResizeImage(Properties.Resources.Hive__inside_, hiveForm.ClientRectangle.Width, hiveForm.ClientRectangle.Height);

            BeeAnimationSmall[0] = ResizeImage(new Bitmap(Properties.Resources.Bee_animation_1), 20, 20);
            BeeAnimationSmall[1] = ResizeImage(new Bitmap(Properties.Resources.Bee_animation_2), 20, 20);
            BeeAnimationSmall[2] = ResizeImage(new Bitmap(Properties.Resources.Bee_animation_3), 20, 20);
            BeeAnimationSmall[3] = ResizeImage(new Bitmap(Properties.Resources.Bee_animation_4), 20, 20);

            BeeAnimationLarge[0] = ResizeImage(new Bitmap(Properties.Resources.Bee_animation_1), 40, 40);
            BeeAnimationLarge[1] = ResizeImage(new Bitmap(Properties.Resources.Bee_animation_2), 40, 40);
            BeeAnimationLarge[2] = ResizeImage(new Bitmap(Properties.Resources.Bee_animation_3), 40, 40);
            BeeAnimationLarge[3] = ResizeImage(new Bitmap(Properties.Resources.Bee_animation_4), 40, 40);

        }

        public void AnimateBees()
        {
            frame++;
            if (frame >= 6)
            {
                frame = 0;
                switch (frame)
                {
                    case 0: cell = 0; break;
                    case 1: cell = 1; break;
                    case 2: cell = 2; break;
                    case 3: cell = 3; break;
                    case 4: cell = 2; break;
                    case 5: cell = 1; break;
                    default: cell = 0; break;
                }
            }
            hiveForm.Invalidate();
            fieldForm.Invalidate();
        }

        public void PaintHive(Graphics graphics)
        {
            graphics.FillRectangle(Brushes.SkyBlue, hiveForm.ClientRectangle);
            graphics.DrawImageUnscaled(HiveInside, 0, 0);
            foreach (Bee bee in world.Bees)
            {
                if (bee.InsideHive)
                {
                    graphics.DrawImageUnscaled(BeeAnimationLarge[cell], bee.Location.X, bee.Location.Y);
                }
            }
        }

        public void PaintField(Graphics graphics)
        {
            using (Pen brownPen = new Pen(Color.Brown, 6.0F))
            {

                Rectangle skyRectangle = new Rectangle(0, 0, fieldForm.ClientSize.Width, fieldForm.ClientSize.Height / 2);
                graphics.FillRectangle(Brushes.SkyBlue, skyRectangle);
                graphics.FillRectangle(Brushes.Green, new Rectangle(0, fieldForm.ClientSize.Height / 2, fieldForm.ClientSize.Width, fieldForm.ClientSize.Height / 2));
                graphics.FillEllipse(Brushes.Yellow, new RectangleF(50, 15, 70, 70));
                graphics.DrawLine(brownPen, new Point(593, 0), new Point(593, 30));
                graphics.DrawImageUnscaled(HiveOutSide, 550, 20);
                foreach (Flower flower in world.Flowers)
                {
                    graphics.DrawImageUnscaled(Flower, flower.Location.X, flower.Location.Y);
                }
                foreach (Bee bee in world.Bees)
                {
                    if (!bee.InsideHive)
                    {
                        graphics.DrawImageUnscaled(BeeAnimationSmall[cell], bee.Location.X, bee.Location.Y);
                    }
                }
            }
        }
    }
}
