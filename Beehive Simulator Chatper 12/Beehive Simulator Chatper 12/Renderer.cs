using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive_Simulator_Chapter_12
{
    class Renderer
    {
        /*************************************
        * FIELDS AND PROPERTIES
        *************************************/
        private World world;
        private HiveForm hiveForm;
        private FieldForm fieldForm;

        private Dictionary<Flower, PictureBox> flowerLookup = new Dictionary<Flower, PictureBox>();
        private Dictionary<Bee, BeeControl> beeLookup = new Dictionary<Bee, BeeControl>();


    }
}
