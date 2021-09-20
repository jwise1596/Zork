using System;


namespace Zork
{
    class Program
    {
        private static Room CurrentRoom
        {
            get
            {
                return Rooms[Location.Row, Location.Column];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            while (true)
            { 
                Console.Write($"{CurrentRoom.Name}\n> ");
               Commands command = Commands.UNKNOWN;
                while (command == Commands.QUIT)
                {
                    break;
                }

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.LOOK:
                        Console.WriteLine(CurrentRoom.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = Move(command) ? $"You moved {command}." : "The way is shut!";
                        break;

                    default:
                        outputString = "Unknown command.";
                        break;
                }

                Console.WriteLine(outputString);
            }

            Console.WriteLine("Finished");
        }

        private static Commands ToCommand(string commandString) => (Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN);

        private static bool Move(Commands command)
        {
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH when LocationRow < Rooms.Length - 1:
                    LocationRow++;
                    didMove = true;
                    break;

                case Commands.SOUTH when LocationRow > 0:
                    LocationRow--;
                    didMove = true;
                    break;

                case Commands.EAST when LocationColumn < Rooms.Length - 1:
                    LocatonColumn++;
                    didMove = true;
                    break;

                case Commands.WEST when LocationColumn > 0:
                        LocationColumn--;
                        didMove = true;
                        break;
            }

            return didMove;
        }

        private static readonly Room[,] Rooms = {
            { new Room("Rocky Trail"), new Room("South of House"), new Room("Canyon View") },
            { new Room("Forest"), new Room("West of House"), new Room("Behind House") },
            { new Room("Dense Woods"), new Room("North of House"), new Room("Clearing") }
        };

        private static void InitializeRoomDescriptions()
        {

        }

        private static (int Row, int Column) Location = (1, 1);
    }  
}
