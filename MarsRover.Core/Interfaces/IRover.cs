using MarsRover.Core.Entities;
using MarsRover.Core.Entities.Enums;

namespace MarsRover.Core.Interfaces
{
    public interface IRover
    {
        Place Place { get; set; }
        Position Position { get; set; }
        Direction Direction { get; set; }
        void SetPosition(Position position, Direction direction);
        void Process(string moves);
    }
}
