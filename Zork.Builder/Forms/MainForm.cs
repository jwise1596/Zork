using System;
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

        private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Not yet implemented.");
        }


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
        int newRoomCount = 0;
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
        }       
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
            deleteButton.Enabled = roomsListBox.SelectedItem != null;
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
        private GameViewModel _viewModel;
        private bool _isWorldLoaded;


    }
}
