using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Project_Chapter_7
{
    public partial class HouseForm : Form
    {
        private Location currentLocation;
        RoomWithDoor Kitchen;
        RoomWithDoor LivingRoom;
        Room DiningRoom;

        OutsideWithDoor FrontYard;
        OutsideWithDoor backYard;
        Outside garden;        

        public HouseForm()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(LivingRoom);
        }

        private void CreateObjects()
        {
            // Object initialization
            backYard = new OutsideWithDoor("Back Yard",true, "an old screen door");
            garden = new Outside("garden", false);
            DiningRoom = new Room("a crystal chandelier", "Dining Room");            
            FrontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            LivingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            Kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "an old screen door");
            
            // Room exits
            FrontYard.Exits = new Location[] { backYard, garden };
            DiningRoom.Exits = new Location[] { LivingRoom, Kitchen };
            LivingRoom.Exits = new Location[] { FrontYard, DiningRoom };
            Kitchen.Exits = new Location[] { DiningRoom, backYard };
            backYard.Exits = new Location[] { Kitchen, garden };
            garden.Exits = new Location[] { FrontYard, backYard };

            // Door locations
            FrontYard.DoorLocation = LivingRoom;
            LivingRoom.DoorLocation = FrontYard;

            Kitchen.DoorLocation = backYard;
            backYard.DoorLocation = Kitchen;
        }

        private void MoveToANewLocation(Location location)
        {
            // Set current location to given location
            this.currentLocation = location;

            //Clear the list of locations
            cbLocations.Items.Clear();

            // Add all exits from current location to this combo box
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                cbLocations.Items.Add(currentLocation.Exits[i].Name);
            }

            // Reset combo box position
            cbLocations.SelectedIndex = 0;

            // Description of the current location displayed in text box
            tbDescription.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
            {
                btnGoThroughDoor.Visible = true;
            }
            else
            {
                btnGoThroughDoor.Visible = false;
            }
        }

        private void btnGoHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[cbLocations.SelectedIndex]);
        }

        private void btnGoThroughDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
