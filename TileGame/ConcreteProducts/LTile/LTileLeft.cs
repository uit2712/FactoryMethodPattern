using System.Collections.Generic;
using System.Drawing;
using TileGame.Assets;
using TileGame.Products;

namespace TileGame.ConcreteProducts.LTile
{
    class LTileLeft : Tile
    {
        public LTileLeft()
        {
            _brush = Brushes.Green;
            /*
              x
              x
             xx
             */
            _states.Add(new List<Point>()
            {
                new Point(1, 0),
                new Point(1, 1),
                new Point(1, 2),
                new Point(0, 2)
            });
            /*
             xxx
               x
             */
            _states.Add(new List<Point>()
            {
                new Point(0, 0),
                new Point(1, 0),
                new Point(2, 0),
                new Point(2, 1)
            });
            /*
             xx
             x
             x
             */
            _states.Add(new List<Point>()
            {
                new Point(0, 0),
                new Point(1, 0),
                new Point(0, 1),
                new Point(0, 2)
            });
            /*
             x
             xxx
             */
            _states.Add(new List<Point>()
            {
                new Point(0, 0),
                new Point(0, 1),
                new Point(1, 1),
                new Point(2, 1)
            });
            RandomState();
        }

        public override void Draw(Graphics graphics)
        {
            DrawAssets.Instance().DrawTile(graphics, this, _radius);
        }
    }
}
