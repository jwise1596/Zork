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
        }

        private void roomNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
