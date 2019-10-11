using System.Drawing;

namespace TileGame
{
    class TileInfo
    {
        public Brush Brush { get; set; }
        public Point Position { get; set; }

        public TileInfo(Brush brush, Point position)
        {
            Brush = brush;
            Position = position;
        }
    }
}
