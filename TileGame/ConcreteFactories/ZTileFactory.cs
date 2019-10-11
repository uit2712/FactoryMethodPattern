using TileGame.AbstractFactories;
using TileGame.ConcreteProducts.ZTile;
using TileGame.Enums;
using TileGame.Products;

namespace TileGame.ConcreteFactories
{
    class ZTileFactory : ITileAbstractFactory
    {
        private static ZTileFactory _instance;
        private ZTileLeft _zTileLeft = new ZTileLeft();
        private ZTileRight _zTileRight = new ZTileRight();

        private ZTileFactory()
        {

        }

        public static ZTileFactory Instance()
        {
            if (_instance == null)
                _instance = new ZTileFactory();

            return _instance;
        }

        public Tile MakeTile(EDirection direction)
        {
            switch (direction)
            {
                case EDirection.LEFT:
                    _zTileLeft.RandomState();
                    return _zTileLeft;
                case EDirection.RIGHT:
                    _zTileRight.RandomState();
                    return _zTileRight;
                default: return null;
            }
        }
    }
}
