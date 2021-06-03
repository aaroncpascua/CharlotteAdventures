using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace CharlotteAdventures
{
    public partial class CharlotteAdventures : Form
    {
        private Player _player;
        private Monster _currentMonster;

        public CharlotteAdventures()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house in Greensboro, NC.");

            _player = new Player(10, 10, 20, 0, 1);
            MoveTo(World.LocationByID(World.LOCATION_ID_LIGHTRAIL));
            _player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_TI84), 1));

            lblHP.Text = _player.CurrentHP.ToString();
            lblDB.Text = _player.DB.ToString();
            lblEXP.Text = _player.EXPPoints.ToString();
            lblLVL.Text = _player.LVL.ToString();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            Moveto(_player.CurrentLocation.LocationToNorth);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            Moveto(_player.CurrentLocation.LocationToSouth);
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToEast);
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToWest);
        }

        private void MoveTo(Location newLocation)
        {

        }
    }
}
