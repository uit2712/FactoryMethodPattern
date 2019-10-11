using System.Drawing;
using System.Windows.Forms;

namespace TileGame
{
    class GameScreen
    {
        private int _columns;
        private int _rows;
        private Pen _pen = null;
        private Panel _screen = new Panel();
        private Graphics _gridGraphics = null;
        private Graphics _constantGraphics = null;
        private Graphics _tilesGraphics = null;
        private Size _unitSize;

        public GameScreen(Size unitSize, int columns, int rows, Color penColor)
        {
            _unitSize = unitSize;
            _columns = columns;
            _rows = rows;
            _pen = new Pen(penColor);
            _screen.Width = unitSize.Width * columns;
            _screen.Height = unitSize.Height * rows;
            _gridGraphics = _screen.CreateGraphics();
            _gridGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            _tilesGraphics = _screen.CreateGraphics();
            _tilesGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            _constantGraphics = _screen.CreateGraphics();
            _constantGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        public int Columns
        {
            get { return _columns; }
        }

        public int Rows
        {
            get { return _rows; }
        }

        public Pen Pen
        {
            get { return _pen; }
        }

        public Panel Screen
        {
            get { return _screen; }
        }

        public Graphics GridGraphics
        {
            get { return _gridGraphics; }
        }

        public Graphics ConstantGraphics
        {
            get { return _constantGraphics; }
        }

        public Graphics TilesGraphics
        {
            get { return _tilesGraphics; }
        }

        public Size UnitSize
        {
            get { return _unitSize; }
        }

        public Rectangle ScreenRectangle
        {
            get { return new Rectangle(0, 0, _screen.Width, _screen.Height); }
        }
    }
}
