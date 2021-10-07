using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Zork
{
    public class Player
    {
        public World World { get; }

        public Room CurrentRoom { get; set; }

        public Room PreviousRoom { get; set; }

        public Player(World world)
        {
            World = world;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = CurrentRoom.Neighbors.TryGetValue(direction, out Room neighbor);
            if (isValidMove)
            {
                CurrentRoom = neighbor;
            }

            return isValidMove;
        }
    }
}
