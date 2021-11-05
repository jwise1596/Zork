using System;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace ZorkBuilder.WinForms
{
    public partial class AddRoomForm : Form
    {
        public string RoomName => nameTextBox.Text;
        public AddRoomForm()
        {
            InitializeComponent();
            okButton.Enabled = false;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }
    }
}
