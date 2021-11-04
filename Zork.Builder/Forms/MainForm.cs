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

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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
                    ViewModel.Rooms.Add(room);
                }
            }
        }

        private GameViewModel _viewModel;
        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void runButtonClick(object sender, EventArgs e)
        {

        }

        private void openFileDialogue(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void northButton_Click(object sender, EventArgs e)
        {

        }

        private void roomsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void worldViewModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
