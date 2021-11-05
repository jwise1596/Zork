using System;
using System.IO;
using System.ComponentModel;
using Zork.Common;
using System.Runtime.CompilerServices;

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
                if (_game != value)
                {
                    
                }
                
            }
        }
        private string FullPath { get; set; }
        public bool IsModified { get; set; }
        //public string Filename => FullPath != null ? Path.

        private Game _game;
    }
}
