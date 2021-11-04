using Newtonsoft.Json;
using System.Runtime.Serialization;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace Zork.Common
{
    public class Game : INotifyPropertyChanged
    {
        public World World { get; }
        public List<Room> Rooms { get; set; }

        [JsonIgnore]
        public Player Player { get; set; }

        [JsonIgnore]
        private bool IsRunning { get; set; }

        public string WelcomeMessage { get; set; }
        public string ExitMessage { get; set; }

      public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Run()
        {
            Console.WriteLine(WelcomeMessage);

            IsRunning = true;
            Room previousRoom = null;
            while (IsRunning)
            {
                Console.WriteLine(Player.Location);
                if (previousRoom != Player.Location)
                {
                    Console.WriteLine(Player.Location.Description);
                    previousRoom = Player.Location;
                }

                Console.Write("\n> ");
                Commands command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        IsRunning = false;
                        Console.WriteLine(ExitMessage);
                        break;

                    case Commands.LOOK:
                        Console.WriteLine(Player.Location.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = (Directions)command;
                        if (Player.Move(direction) == false)
                        {
                            Console.WriteLine("The way is shut!");
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            }
        }

        public static Game Load(string filename)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(filename));
            game.Player = game.World.SpawnPlayer();

            return game;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
    }
}

