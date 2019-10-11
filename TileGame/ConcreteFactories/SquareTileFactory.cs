using TileGame.AbstractFactories;
using TileGame.ConcreteProducts.SquareTile;
using TileGame.Enums;
using TileGame.Products;

namespace TileGame.ConcreteFactories
{
    class SquareTileFactory : ITileAbstractFactory
    {
        private static SquareTileFactory _instance;
        private SquareTile _tile = new SquareTile();

        private SquareTileFactory()
        {

        }

        public static SquareTileFactory Instance()
        {
            if (_instance == null)
                _instance = new SquareTileFactory();

            return _instance;
        }

        public Tile MakeTile(EDirection direction = EDirection.NONE)
        {
            _tile.RandomState();
            return _tile;
        }
    }
}
