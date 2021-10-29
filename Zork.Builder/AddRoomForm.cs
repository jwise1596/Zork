using System;
using System.Windows.Forms;

namespace ZorkBuilder.WinForms
{
    public partial class AddRoomForm : Form
    {
        public string RoomName => roomNameTextBox.Text;
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void roomNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
