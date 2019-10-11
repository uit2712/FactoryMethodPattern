using System;
using System.Collections.Generic;
using System.Drawing;
using TileGame.Assets;
using TileGame.Products;

namespace TileGame.ConcreteProducts.ZTile
{
    class ZTileLeft : Tile
    {
        public ZTileLeft()
        {
            _brush = Brushes.Red;
            /*
             x
             xx
              x
             */
            _states.Add(new List<Point>()
            {
                new Point(0, 0),
                new Point(0, 1),
                new Point(1, 1),
                new Point(1, 2)
            });
            /*
             xx
            xx
             */
            _states.Add(new List<Point>()
            {
                new Point(1, 0),
                new Point(2, 0),
                new Point(0, 1),
                new Point(1, 1)
            });
        }

        public override void Draw(Graphics graphics)
        {
            DrawAssets.Instance().DrawTile(graphics, this, _radius);
        }
    }
}
