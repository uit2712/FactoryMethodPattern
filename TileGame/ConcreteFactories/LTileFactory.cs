using TileGame.AbstractFactories;
using TileGame.ConcreteProducts.LTile;
using TileGame.Enums;
using TileGame.Products;

namespace TileGame.ConcreteFactories
{
    class LTileFactory : ITileAbstractFactory
    {
        private static LTileFactory _instance;
        private LTileLeft _lTileLeft = new LTileLeft();
        private LTileRight _lTileRight = new LTileRight();

        private LTileFactory()
        {

        }

        public static LTileFactory Instance()
        {
            if (_instance == null)
                _instance = new LTileFactory();

            return _instance;
        }

        public Tile MakeTile(EDirection direction = EDirection.NONE)
        {
            switch(direction)
            {
                case EDirection.LEFT:
                    _lTileLeft.RandomState();
                    return _lTileLeft;
                case EDirection.RIGHT:
                    _lTileRight.RandomState();
                    return _lTileRight;
                default: return null;
            }
        }
    }
}
