using System;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {
        private World RoomsByName 
        {
            get => mRoomsByName;
            set => mRoomsByName = value;
        }

        private World mRoomsByName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RoomsByName = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                openFileDialog.DefaultExt = openFileDialog.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
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

    }
}
