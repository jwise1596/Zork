using System;
using System.IO;
using System.ComponentModel;
using Zork.Common;
using Newtonsoft.Json;

namespace ZorkBuilder.WinForms
{
    internal class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public BindingList<Room> Rooms { get; set; }
        public string FileName { get; set; }
        public string StartingLocation { get; set; }
        public Game Game
        {

            set
            {
                if (_game != value)
                {
                    _game = value;
                    if (_game !=null)
                    {
                        Rooms = new BindingList<Room>(_game.World.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                    
                }
                
            }
        }

        public GameViewModel(Game game = null)
        {
            Game = game;
        }
        public void SaveWorld()
        {
            if (string.IsNullOrEmpty(FileName))
            {
                throw new InvalidProgramException("Filename expected.");
            }
            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamwriter = new StreamWriter(FileName))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamwriter))
            {
                serializer.Serialize(jsonWriter, _game);
            }
        }

        private Game _game;
    }
}
