using System.Drawing;

namespace TileGame.Interfaces
{
    interface ITile
    {
        void Draw(Graphics graphics);
        void MoveLeft();
        void MoveRight();
        void MoveDown();
    }
}
