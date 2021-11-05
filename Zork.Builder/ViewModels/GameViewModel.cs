using System;
using System.ComponentModel;
using Zork.Common;

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

        //private string FullPath { get; set; }
        public bool IsModified { get; set; }
        //public string Filename => FullPath != null ? Path.

        private Game _game;

        public GameViewModel(Game game = null)
        {
            Game = game;
        }
    }
}
