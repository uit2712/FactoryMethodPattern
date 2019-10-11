using System.Collections.Generic;
using System.Drawing;
using TileGame.Assets;
using TileGame.Products;

namespace TileGame.ConcreteProducts.AddTile
{
    class AddTile : Tile
    {
        public AddTile()
        {
            _brush = Brushes.Blue;
            /*
             x
             xx
             x
             */
            _states.Add(new List<Point>()
            {
                new Point(0, 0),
                new Point(0, 1),
                new Point(0, 2),
                new Point(1, 1)
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
                new Point(1, 1)
            });
            /*
              x
             xx
              x
             */
            _states.Add(new List<Point>()
            {
                new Point(1, 0),
                new Point(1, 1),
                new Point(1, 2),
                new Point(0, 1)
            });
            /*
              x
             xxx
             */
            _states.Add(new List<Point>()
            {
                new Point(1, 0),
                new Point(0, 1),
                new Point(1, 1),
                new Point(2, 1)
            });
        }

        public override void Draw(Graphics graphics)
        {
            DrawAssets.Instance().DrawTile(graphics, this, _radius);
        }
    }
}
