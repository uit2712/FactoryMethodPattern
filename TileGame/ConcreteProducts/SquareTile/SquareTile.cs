using System.Collections.Generic;
using System.Drawing;
using TileGame.Assets;
using TileGame.Products;

namespace TileGame.ConcreteProducts.SquareTile
{
    class SquareTile : Tile
    {
        public SquareTile()
        {
            _brush = Brushes.Violet;
            /*
             xx
             xx
             */
            _states.Add(new List<Point>()
            {
                new Point(0, 0),
                new Point(1, 0),
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
