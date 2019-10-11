using System.Collections.Generic;
using System.Drawing;
using TileGame.Assets;
using TileGame.Products;

namespace TileGame.ConcreteProducts.ITile
{
    class lTile : Tile
    {
        public lTile()
        {
            _brush = Brushes.Blue;
            /*
             x
             x
             x
             x
             */
            _states.Add(new List<Point>()
            {
                new Point(0, 0),
                new Point(0, 1),
                new Point(0, 2),
                new Point(0, 3)
            });
            /*
             xxxx
             */
            _states.Add(new List<Point>()
            {
                new Point(0, 1),
                new Point(1, 1),
                new Point(2, 1),
                new Point(3, 1)
            });
        }

        public override void Draw(Graphics graphics)
        {
            DrawAssets.Instance().DrawTile(graphics, this, _radius);
        }
    }
}
