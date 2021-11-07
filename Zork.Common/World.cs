using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Linq;
using Newtonsoft.Json;

namespace Zork.Common
{
    public class World : INotifyPropertyChanged
    {
        public List<Room> Rooms { get; set; }
        public Dictionary<string, Room> mRoomsByName;
        [JsonProperty]
        public string StartingLocation { get; set; }

        [JsonIgnore]
        public Dictionary<string, Room> RoomsByName { get; set; }

        public Player SpawnPlayer() => new Player(this, StartingLocation);

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
           RoomsByName = new Dictionary<string, Room>();
           foreach (Room room in Rooms)
           {
                RoomsByName.Add(room.Name, room);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }

}