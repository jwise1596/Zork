using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork.Builder.ViewModels
{
    public World world
    {

    }
    class WorldViewModel(World world = null)
    {
        World = world;
    }
}
