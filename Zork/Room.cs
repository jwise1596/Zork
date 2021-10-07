using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Zork
{
    public class Room
    {
        [JsonProperty(Order =1)]
        public string Name { get; private set; }

        [JsonProperty(Order = 2)]
        public string Description { get; private set; }


        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors { get; set; }

        [JsonProperty(PropertyName = "Neighbors", Order =3)]
        public Dictionary<Directions, string> NeighborNames { get; set; }

        public static bool operator ==(Room 1hs, Room rhs)
            if (ReferenceEquals 1hs, rhs)

        public Room(string name, string description = "")
        {
            Name = name;
            Description = description;
        }

        public void UpdateNeighbors(World world)
        {
            Neighbors = new Dictionary<Directions, Room>();
            foreach (var (direction, name) in NeighborNames)
            {
                Neighbors.Add(direction, world.RoomsByName[name]);
                
            }

        }
        public override string ToString() => Name;
    }
}
