using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Linq;
using System.IO;
using System.ComponentModel;

namespace Zork.Common
{
    public class Player : INotifyPropertyChanged
    {
        public World World { get; }

        [JsonIgnore]
        public Room Location { get; private set; }

        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string LocationName
        {
            get
            {
                return Location.Name;
            }
            set
            {
                Location = World?.RoomsByName.GetValueOrDefault(value);
            }
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room neighbor);
            if (isValidMove)
            {
                Location = neighbor;
            }

            return isValidMove;
        }
    }
}
