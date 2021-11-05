using System;
using System.Windows.Forms;

namespace ZorkBuilder.WinForms
{
    public partial class AddRoomForm : Form
    {
        public string RoomName
        {
            get => nameTextBox.Text;
            set => nameTextBox.Text = value;
        }
        public AddRoomForm()
        {
            InitializeComponent();
            okButton.Enabled = false;
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }

    }
}
