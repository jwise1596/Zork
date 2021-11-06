using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Zork.Common
{
    public class Room : IEquatable<Room>, INotifyPropertyChanged
    {
        [JsonProperty(PropertyName = "Names", Order = 1)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "Descriptions", Order = 2)]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "Neighbors", Order = 3)]
        public Dictionary<Directions, string> NeighborNames { get; set; }

        public List<Room> Rooms { get; set; }

        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors { get; set; }

        public Room(string name = null, string description = null)
        {
            Name = name;
            Description = description;
        }

        public override string ToString() => Name;
        public bool Equals(Room other) => this == other;
        public override bool Equals(object obj) => obj is Room room ? this == room : false;

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
