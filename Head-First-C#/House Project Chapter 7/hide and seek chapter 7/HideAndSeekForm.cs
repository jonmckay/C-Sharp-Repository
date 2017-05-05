using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hide_and_Seek_Chapter_7
{
    public partial class HideAndSeekForm : Form
    {
        int Moves;

        Location currentLocation;

        RoomWithDoor Kitchen;
        RoomWithDoor LivingRoom;
        RoomWithHidingPlace DiningRoom;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;


        OutsideWithDoor FrontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        Opponent opponent;

        public HideAndSeekForm()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(FrontYard);
            ResetGame(false);
        }

        private void CreateObjects()
        {
            // Object initialization
            
            
            DiningRoom = new RoomWithHidingPlace("Dining Room","a crystal chandelier", "in the tall armoire");                        
            LivingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob","inside the closet");
            Kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "an old screen door","in the cabinet");
            stairs = new Room("Stairs", "a wooden bannister");
            hallway = new RoomWithHidingPlace("Hallway", "a picture of a dog", "in the closet");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilet", "in the shower");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "under the bed");
            secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bed", "under the bed");

            FrontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "an old screen door");
            garden = new OutsideWithHidingPlace("garden", false, "inside the shed");
            driveway = new OutsideWithHidingPlace("Driveway", true, "in the garage");

            // Room exits
            FrontYard.Exits = new Location[] { backYard, garden, driveway };
            DiningRoom.Exits = new Location[] { LivingRoom, Kitchen };
            LivingRoom.Exits = new Location[] { FrontYard, DiningRoom };
            Kitchen.Exits = new Location[] { DiningRoom, backYard };
            backYard.Exits = new Location[] { Kitchen, garden, driveway };
            garden.Exits = new Location[] { FrontYard, backYard };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            stairs.Exits = new Location[] { LivingRoom, hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            driveway.Exits = new Location[] { backYard, FrontYard };
            bathroom.Exits = new Location[] { hallway };
            
            // Door locations
            FrontYard.DoorLocation = LivingRoom;
            LivingRoom.DoorLocation = FrontYard;

            Kitchen.DoorLocation = backYard;
            backYard.DoorLocation = Kitchen;
        }

        private void MoveToANewLocation(Location location)
        {
            Moves++;
            currentLocation = location;
            RedrawForm();
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

        private void RedrawForm()
        {
            cbLocations.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                cbLocations.Items.Add(currentLocation.Exits[i].Name);
            }
            cbLocations.SelectedIndex = 0;

            tbDescription.Text = currentLocation.Description + "\r\n (move #" + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                btnCheck.Text = "Check " + hidingPlace.HidingPlace;
                btnCheck.Visible = true;
            }
            else
            {
                btnCheck.Visible = false;
            }
            if (currentLocation is IHasExteriorDoor)
            {
                btnGoThroughDoor.Visible = true;
            }
            else
            {
                btnGoThroughDoor.Visible = false;
            }
        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("You found me in " + Moves + " moves!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                tbDescription.Text = "You found your opponent in " + Moves +
                    " moves! He was hiding " + foundLocation.HidingPlace + ".";
            }
            Moves = 0;
            btnHide.Visible = true;
            btnGoHere.Visible = false;
            btnCheck.Visible = false;
            btnGoThroughDoor.Visible = false;
            cbLocations.Visible = false;
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
            {
                ResetGame(true);
            }
            else
            {
                RedrawForm();
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnHide.Visible = false;

            for (int i = 0; i <= 10; i++)
            {
                opponent.Move();
                tbDescription.Text = i + "... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }

            tbDescription.Text = "Ready or not, here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            btnGoHere.Visible = true;
            cbLocations.Visible = true;
            MoveToANewLocation(LivingRoom);
        }

    }
}
