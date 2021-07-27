namespace MarsRover.Core.Entities
{
    public struct Place
    {
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Place(int x, int y, int startX = 0, int startY = 0)
        {
            StartX = startX;
            StartY = startY;
            X = x;
            Y = y;
        }
    }
}
