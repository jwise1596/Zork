using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Linq;
using System.IO;

namespace Zork
{
    public class Player
    {
        public World World { get; }

        [JsonIgnore]
        public Room Location { get; private set; }
        public Room CurrentRoom { get; set; }

        public Room PreviousRoom { get; set; }

        [JsonIgnore]
        public string LocationName
        {
            get
            {
                return LocationName?.Name;
            }
            set
            {
                Location = World?.RoomsByName.GetValueOrDefault(value);
            }
        }

        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = CurrentRoom.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove)
            {
                CurrentRoom = destination;
            }

            return isValidMove;
        }
    }
}
