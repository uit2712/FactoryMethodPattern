using TileGame.Enums;
using TileGame.Products;

namespace TileGame.AbstractFactories
{
    interface ITileAbstractFactory
    {
        Tile MakeTile(EDirection direction = EDirection.NONE);
    }
}
