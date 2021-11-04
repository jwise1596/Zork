using System;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using Newtonsoft.Json;
using Zork.Common;

namespace ZorkBuilder.WinForms
{
    public partial class MainForm : Form
    {
        //ublic static string AssemblyTitle = AssemblyTitle.GetExecutingAssembly().GetCustomAttribute<AssemblyTitle>;
        private GameViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel != value)
                {
                    _viewModel = value;
                    gameViewModelBindingSource.DataSource = _viewModel;
                }
            }
        }

        //private bool IsWorldLoaded
        //{
            //get => _isWorldLoaded;
            //set
            //{
            //  _isWorldLoaded = value;
            //  mainTabControl.Enabled = _isWorldLaoded;
            //}
        //}

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();
            //IsWorldLoaded = false;

           // _neighborControlMap = new Dictionary<NeighborDirections, NeighborControl>
            //{
              //  {NeighborDirections.North, northDirectionItemControl },
                //{NeighborDirections.South, southDirectionsItemControl },
                //{NeighborDirections.East, eastDirectionItemControl },
                //{NeighborDirections.West, westDirectionsItemControl }
            //};
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.");
        }

        private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                {
                    string jsonString = File.ReadAllText(openFileDialog.FileName);
                    Game game = JsonConvert.DeserializeObject<Game>(jsonString);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room(addRoomForm.RoomName);
                    ViewModel.Game.World.Rooms.Add(room);
                    //RefreshData();
                    //SelectedRoom = room;
                    //ViewModel.IsModifeid = true;
                }
                else
                {
                    MessageBox.Show($"Room name \"{addRoomForm.RoomName}\" already exists.");
                }
            }
        }


        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Delete this room?") == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)roomsListBox.SelectedItem);
                //roomsListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = roomsListBox.SelectedItem != null;
           // Room selectedRoom = roomsListBox.SelectedNeighbor as Room;
           //foreach (KeyValuePair<NeighborDirections, NeighborControl> entry in _neighborControlMap)
            //{
            //    entry.Value.Room = selectedRoom;
            //}
        }

        private Room _SelectedRoom;
        private Room _StartingLocation;
        private GameViewModel _viewModel;
       
        //private readonly Dictionary<Directions, NeighborView> DirectionNeighborViewMap;
        //private bool _RefreshingData;
    }
}
