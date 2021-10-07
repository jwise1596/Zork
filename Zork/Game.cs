using Newtonsoft.Json;
using System.Runtime.Serialization;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Zork
{
    public class Game
    {
        public World World { get; set; }
        public string StartingLocation { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        private bool IsRunning { get; set; }

        public string WelcomeMessage { get; set; }
        public string ExitMessage { get; set; }

      public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }

        public void Run()
        {
            Console.WriteLine(WelcomeMessage);

            IsRunning = true;
            Room previousRoom = null;
            while (IsRunning)
            {
                Console.WriteLine(Player.CurrentRoom);
                if (Player.PreviousRoom != Player.CurrentRoom)
                {
                    Console.WriteLine(Player.CurrentRoom.Description);
                    Player.PreviousRoom = Player.CurrentRoom;
                }

                Console.Write("> ");
                Commands command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        IsRunning = false,
                        Console.WriteLine(ExitMessage);
                        break;

                    case Commands.LOOK:
                        Console.WriteLine(Player.CurrentRoom.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = Enum.Parse<Directions>(command.ToString(), true);
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

