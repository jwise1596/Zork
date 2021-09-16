﻿using System;


namespace Zork
{
    class Program
    {
        private static string Location
        {
            get
            {
                return Rooms[LocationColumn];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            while (true)
            { 
                Console.Write($"{Location}\n> ");
                Commands command = ToCommand(Console.ReadLine().Trim());
                if (command == Commands.QUIT)
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
                        outputString = "This is an open field west of a white house, with a boarded front door. \nA rubber mat saying 'Welcome to Zork!' lies by the door.";
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

        private static readonly string[,] Rooms = {
            { "Rocky Trail", "South of House", "Canyon View" },
            { "Forest", "West of House", "Behind House" },
            { "Dense Woods", "North of House", "Clearing" }
        };
        private static (int Row, int Column) Location = (1, 1);
    }  
}
