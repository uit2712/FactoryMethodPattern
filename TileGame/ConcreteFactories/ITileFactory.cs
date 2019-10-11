using TileGame.AbstractFactories;
using TileGame.ConcreteProducts.ITile;
using TileGame.Enums;
using TileGame.Products;

namespace TileGame.ConcreteFactories
{
    class ITileFactory : ITileAbstractFactory
    {
        private static ITileFactory _instance;
        private lTile _tile = new lTile();

        private ITileFactory()
        {

        }

        public static ITileFactory Instance()
        {
            if (_instance == null)
                _instance = new ITileFactory();

            return _instance;
        }

        public Tile MakeTile(EDirection direction = EDirection.NONE)
        {
            _tile.RandomState();
            return _tile;
        }
    }
}
