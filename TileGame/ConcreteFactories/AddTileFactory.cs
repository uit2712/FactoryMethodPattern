using TileGame.AbstractFactories;
using TileGame.ConcreteProducts.AddTile;
using TileGame.Enums;
using TileGame.Interfaces;
using TileGame.Products;

namespace TileGame.ConcreteFactories
{
    class AddTileFactory : ITileAbstractFactory
    {
        private static AddTileFactory _instance;
        private AddTile _tile = new AddTile();

        private AddTileFactory()
        {

        }

        public static AddTileFactory Instance()
        {
            if (_instance == null)
                _instance = new AddTileFactory();

            return _instance;
        }

        public Tile MakeTile(EDirection direction = EDirection.NONE)
        {
            _tile.RandomState();
            return _tile;
        }
    }
}
