using TileGame.ConcreteFactories;
using TileGame.Enums;
using TileGame.Products;

namespace TileGame.ConcreteCreators
{
    class TileFactory
    {
        private static TileFactory _instance;

        private TileFactory()
        {

        }

        public static TileFactory Instance()
        {
            if (_instance == null)
                _instance = new TileFactory();

            return _instance;
        }

        public Tile MakeTile(ETileType tileType, EDirection direction = EDirection.NONE)
        {
            switch(tileType)
            {
                case ETileType.ADDTILE: return AddTileFactory.Instance().MakeTile(direction);
                case ETileType.ITILE: return ITileFactory.Instance().MakeTile(direction);
                case ETileType.LTILE: return LTileFactory.Instance().MakeTile(direction);
                case ETileType.SQUARETILE: return SquareTileFactory.Instance().MakeTile(direction);
                case ETileType.ZTILE: return ZTileFactory.Instance().MakeTile(direction);
                default: return null;
            }
        }
    }
}
