using System;
using System.Windows.Forms;
using Zork.Common;

namespace Zork.Builder.CustomControls
{
    public partial class NeighborControl : UserControl
    {
        public NeighborDirections NeighborDirection
        {
            get => _neighborDirection;
            set
            {
                _neighborDirection = value;
                directionTextBox.Text = _neighborDirection.ToString();
            }
        }
        public NeighborControl()
        {
            InitializeComponent();
        }
        private NeighborDirections _neighborDirection;
    }
}
