using System;
using System.ComponentModel;
using Zork;
using Zork.Common;

namespace ZorkBuilder.WinForms
{
    public class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Filename { get; set; }
        public BindingList<Room> Rooms { get; set; }
        public World World
        {
            set
            {
                if (_world != value)
                {
                    _world = value;
                    if (_world != null)
                    {
                        Rooms = new BindingList<Room>(_world.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }
        private World _world;
    }
}
