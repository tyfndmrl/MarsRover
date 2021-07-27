﻿using MarsRover.Core.Entities.Enums;

namespace MarsRover.Core.Entities
{
    public struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
