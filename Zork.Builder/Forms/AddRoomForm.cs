using System;
using System.Windows.Forms;

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
            okButton.Enabled = !string.IsNullOrWhiteSpace(RoomName);
        }
    }
}
