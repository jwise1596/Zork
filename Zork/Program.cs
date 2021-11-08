using System;
using System.IO;
using Zork.Common;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);
            //instantiate classes using keyword new

            ConsoleOutputService output = new ConsoleOutputService();
            Game game = Game.Load(gameFilename, output);
            game.Run();
        }

        private enum CommandLineArguments
        {
            GameFilename = 0,
        }
    }
    
}
