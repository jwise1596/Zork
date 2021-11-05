﻿using System;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using Newtonsoft.Json;
using Zork.Common;
using System.Reflection;
using System.Linq;

namespace ZorkBuilder.WinForms
{
    public partial class MainForm : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
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

        private bool IsWorldLoaded
        {
            get => _isWorldLoaded;
            set
            {
                _isWorldLoaded = value;
                mainTabControl.Enabled = _isWorldLoaded;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();
            IsWorldLoaded = false;
        }
           // _neighborControlMap = new Dictionary<NeighborDirections, NeighborControl>
            //{
              //  {NeighborDirections.North, northDirectionItemControl },
                //{NeighborDirections.South, southDirectionsItemControl },
                //{NeighborDirections.East, eastDirectionItemControl },
                //{NeighborDirections.West, westDirectionsItemControl }
            //};

        private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Not yet implemented.");
        }

        // Room room = new Room();
        // if (newRoomCount == 0) room.Name = "new room";
        // else room.Name = $"new room {newRoomCount}";
        // ViewModel.Rooms.Add(room);
        // roomsList.SelectedItem = ViewModel.Rooms.LastOrDefault();
        // newRoomCount++;


        private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.FileName = openFileDialog.FileName;
                IsWorldLoaded = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room existingRoom = ViewModel.Rooms.FirstOrDefault(room => room.Name.Equals(addRoomForm.RoomName, StringComparison.OrdinalIgnoreCase));
                    if (existingRoom != null)
                    {
                        MessageBox.Show("Duplicate Record Exists.");
                    }
                    else
                    {
                        Room room = new Room(addRoomForm.RoomName);
                        ViewModel.Rooms.Add(room);
                    }
                }
            }
        }       //ViewModel.Game.World.Rooms.Add(room);
                    //RefreshData();
                    //SelectedRoom = room;
                    //ViewModel.IsModified = true;
                //else
                //{
                //    MessageBox.Show($"Room name \"{addRoomForm.RoomName}\" already exists.");
                //}


        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Delete this room?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)roomsListBox.SelectedItem);
                roomsListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }
        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //deleteButton.Enabled = roomsListBox.SelectedItem != null;
           // Room selectedRoom = roomsListBox.SelectedNeighbor as Room;
           //foreach (KeyValuePair<NeighborDirections, NeighborControl> entry in _neighborControlMap)
            //{
            //    entry.Value.Room = selectedRoom;
            //}
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.FileName = saveFileDialog.FileName;
                ViewModel.SaveWorld();
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) => ViewModel.SaveWorld();


        //private readonly Dictionary<Directions, NeighborView> DirectionNeighborViewMap;
        //private bool _RefreshingData;
        //private Room _SelectedRoom;
        //private Room _StartingLocation;
        private GameViewModel _viewModel;
        private bool _isWorldLoaded;
    }
}
