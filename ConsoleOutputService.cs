using System;

namespace Zork
{
    internal class ConsoleOutputService : IOutputService
    {
        pulic void Write(object value)
        {
            Console.Write(value);
        }

        public void WriteLine(object value)
        {
            Console.WriteLine(value);
        }
    }
}