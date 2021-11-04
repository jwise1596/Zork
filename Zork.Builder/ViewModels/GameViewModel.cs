using System;
using System.IO;
using System.ComponentModel;
using Zork.Common;

namespace ZorkBuilder.WinForms
{
    internal class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public BindingList<Room> Rooms { get; set; }
        public string FileName { get; set; }
        public Game Game
        {
            get => _game;
            set
            {
                if (_game != null)
                {
                    //_game.PropertyChanged -= Game_PropertyChanged;
                    //_game.World.PropertyChanged -= Game;
                    if (Game.World?.Rooms != null)
                    {
                        foreach (Room room in Game.World.Rooms)
                        {
                            //room.PropertyChanged -= Game.World.Rooms;
                        }
                    }
                }
                _game = value;
                if (_game != null)
                {
                   // _game.PropertyChanged += Game_Property;
                   // _game.World.PropertyChanged += Game.World;
                    if (Game.World?.Rooms != null)
                    {
                        foreach (Room room in Game.World.Rooms)
                        {
                            //room.PropertyChanged += Game.World.Rooms;
                        }
                    }

                }
                
            }
        }
        private string FullPath { get; set; }
        public bool IsModified { get; set; }
        //public string Filename => FullPath != null ? Path.

        //private void Game_PropertyChanged(object sender)
        //{
         //   IsModified = true;
           // PropertyChanged?.Invoke(sender, e);
        //}
        private Game _game;
    }
}
