using MarsRover.Core.Entities;
using MarsRover.Core.Entities.Enums;
using MarsRover.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core
{
    public class Rover : IRover
    {
        public Place Place { get; set; }
        public Position Position { get; set; }
        public Direction Direction { get; set; }

        public Rover()
        { }

        public Rover(Place place, Position position, Direction direction)
        {
            Place = place;
            Position = position;
            Direction = direction;
        }

        public void SetPosition(Position position, Direction direction)
        {
            if (position.X < Place.StartX || position.X > Place.X || position.Y < Place.StartY || position.Y > Place.Y)
                throw new Exception($"Position must be in the range ({Place.StartX},{Place.StartY}) to ({Place.X},{Place.Y}).");

            Position = position;
            Direction = direction;
        }

        public void Process(string moves)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        MoveForward();
                        break;
                    case 'L':
                        RotateLeft();
                        break;
                    case 'R':
                        RotateRight();
                        break;
                    default:
                        throw new Exception($"Invalid Character {move}");
                }

                if (Position.X < Place.StartX || Position.X > Place.X || Position.Y < Place.StartY || Position.Y > Place.Y)
                    throw new Exception($"Position must be in the range (0,0) to ({Position.X},{Position.Y}).");
            }
        }

        public override string ToString()
        {
            return $"{Position.X} {Position.Y} {Direction}";
        }

        #region Private
        private void RotateLeft()
        {
            switch (Direction)
            {
                case Direction.N:
                    Direction = Direction.W;
                    break;
                case Direction.S:
                    Direction = Direction.E;
                    break;
                case Direction.E:
                    Direction = Direction.N;
                    break;
                case Direction.W:
                    Direction = Direction.S;
                    break;
                default:
                    break;
            }
        }

        private void RotateRight()
        {
            switch (Direction)
            {
                case Direction.N:
                    Direction = Direction.E;
                    break;
                case Direction.S:
                    Direction = Direction.W;
                    break;
                case Direction.E:
                    Direction = Direction.S;
                    break;
                case Direction.W:
                    Direction = Direction.N;
                    break;
                default:
                    break;
            }
        }

        private void MoveForward()
        {
            switch (this.Direction)
            {
                case Direction.N:
                    Position = new Position(Position.X, Position.Y + 1);
                    break;
                case Direction.S:
                    Position = new Position(Position.X, Position.Y - 1);
                    break;
                case Direction.E:
                    Position = new Position(Position.X + 1, Position.Y);
                    break;
                case Direction.W:
                    Position = new Position(Position.X - 1, Position.Y);
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
