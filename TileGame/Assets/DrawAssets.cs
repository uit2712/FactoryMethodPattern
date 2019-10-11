using System.Drawing;
using System.Drawing.Drawing2D;
using TileGame.Products;

namespace TileGame.Assets
{
    class DrawAssets
    {
        private static DrawAssets _instance;

        private DrawAssets()
        {

        }

        public static DrawAssets Instance()
        {
            if (_instance == null)
                _instance = new DrawAssets();

            return _instance;
        }

        public void DrawTile(Graphics graphics, Tile tile, int radius)
        {
            if (graphics == null || tile == null)
                return;

            foreach (Point element in tile.CurrentState)
            {
                Rectangle rectangle = new Rectangle(tile.Position.X + element.X * tile.Size.Width, tile.Position.Y + element.Y * tile.Size.Height, tile.Size.Width, tile.Size.Height);
                graphics.FillPath(tile.Brush, RoundedRectangle(rectangle, radius));
            }
        }

        public void FillRectangle(Graphics graphics, Brush brush, Rectangle rectangle, int radius)
        {
            graphics.FillPath(brush, RoundedRectangle(rectangle, radius));
        }

        private GraphicsPath RoundedRectangle(Rectangle r, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddLine(r.Left + d, r.Top, r.Right - d, r.Top);
            path.AddArc(Rectangle.FromLTRB(r.Right - d, r.Top, r.Right, r.Top + d), -90, 90);
            path.AddLine(r.Right, r.Top + d, r.Right, r.Bottom - d);
            path.AddArc(Rectangle.FromLTRB(r.Right - d, r.Bottom - d, r.Right, r.Bottom), 0, 90);
            path.AddLine(r.Right - d, r.Bottom, r.Left + d, r.Bottom);
            path.AddArc(Rectangle.FromLTRB(r.Left, r.Bottom - d, r.Left + d, r.Bottom), 90, 90);
            path.AddLine(r.Left, r.Bottom - d, r.Left, r.Top + d);
            path.AddArc(Rectangle.FromLTRB(r.Left, r.Top, r.Left + d, r.Top + d), 180, 90);
            path.CloseFigure();

            return path;
        }
    }
}
