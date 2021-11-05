using System;
using System.Windows.Forms;
using Zork.Common;

namespace Zork.Builder.CustomControls
{
    public partial class NeighborControl : UserControl
    {
        public NeighborDirections NeighborDirection { get => _neighborDirection; set => _neighborDirection = value; }
        public NeighborControl()
        {
            InitializeComponent();
        }

        private void NeighborControl_Load(object sender, EventArgs e)
        {

        }

        private NeighborDirections _neighborDirection;
    }
}
