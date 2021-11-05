﻿using System;
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
        private Dictionary<Directions, string> NeighborNames { get; set; }

        //[JsonProperty(PropertyName = "Rooms", Order = 0)]
        public List<Room> Rooms { get; set; }

        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors { get; private set; }

        public static bool operator ==(Room lhs, Room rhs)
        {
            if (ReferenceEquals(lhs, rhs))
            {
                return true;
            }

            if (lhs is null || rhs is null)
            {
                return false;
            }

            return lhs.Name == rhs.Name;
        }

        public Room(string name = null, string description = null)
        {
            Name = name;
            Description = description;
        }
        public static bool operator !=(Room lhs, Room rhs) => !(lhs == rhs);

        public event PropertyChangedEventHandler PropertyChanged;

        public override bool Equals(object obj) => obj is Room room ? this == room : false;

        public bool Equals(Room other) => this == other;
        public override string ToString() => Name;

        //public override int GetHashCode() => Name.GetHashCode();

        public void UpdateNeighbors(World world) => Neighbors = (from entry in NeighborNames
                                                                let room = world.RoomsByName.GetValueOrDefault(entry.Value)
                                                                where room != null
                                                                select (Direction: entry.Key, Room: room))
                                                                .ToDictionary(KeyValuePair => KeyValuePair.Direction, KeyValuePair => KeyValuePair.Room);
    }
}
