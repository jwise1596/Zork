using System;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {

        public WorldViewModel(World world = null)
        {
            World = world;
        }
        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = (File.ReadAllText(openFileDialog.FileName));
                    openFileDialog.DefaultExt = openFileDialog.FileName;
                }
                catch
                {

                }
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
