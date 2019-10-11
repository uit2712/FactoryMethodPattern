using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TileGame.Assets;
using TileGame.ConcreteCreators;
using TileGame.Enums;
using TileGame.Products;

namespace TileGame
{
    class TetrisGame
    {
        private GameScreen _gameScreen;
        private TileInfo[,] _tileInfos;
        private Tile _currentTile;
        private Timer _timerMoveTileDown = new Timer();

        public Panel Screen
        {
            get { return _gameScreen.Screen; }
        }

        public TetrisGame(GameScreen gameScreen)
        {
            _gameScreen = gameScreen;
            _gameScreen.Screen.Paint += pnlGameScreen_Paint;
            _tileInfos = new TileInfo[_gameScreen.Rows, _gameScreen.Columns];
            for (int i = 0; i < _tileInfos.GetLength(0); i++)
                for (int j = 0; j < _tileInfos.GetLength(1); j++)
                    _tileInfos[i, j] = new TileInfo(Brushes.Transparent, new Point(j, i));
            _currentTile = TileFactory.Instance().MakeTile(ETileType.LTILE, EDirection.LEFT);

            _timerMoveTileDown.Interval = 1500; // 1.5s
            _timerMoveTileDown.Tick += timerMoveTileDown_Tick;
            _timerMoveTileDown.Enabled = true;
        }

        private void timerMoveTileDown_Tick(object sender, System.EventArgs e)
        {
            _currentTile.MoveDown();
            Draw();
        }

        private void FreezeCurrentTile()
        {
            if (!_gameScreen.ScreenRectangle.Contains(_currentTile.Position))
                return;

            List<TileInfo> tileInfos = _currentTile.TileInfos;
            foreach (TileInfo tileInfo in tileInfos)
                _tileInfos[tileInfo.Position.X, tileInfo.Position.Y] = tileInfo;
        }

        private void pnlGameScreen_Paint(object sender, PaintEventArgs e)
        {
            if (_gameScreen.GridGraphics == null)
                return;

            for (int i = 0; i < _gameScreen.Columns; i++)
                _gameScreen.GridGraphics.DrawLine(_gameScreen.Pen, new Point(i * _gameScreen.UnitSize.Width, 0), new Point(i * _gameScreen.UnitSize.Width, _gameScreen.Screen.Height));
            for (int i = 0; i < _gameScreen.Rows; i++)
                _gameScreen.GridGraphics.DrawLine(_gameScreen.Pen, new Point(0, i * _gameScreen.UnitSize.Height), new Point(_gameScreen.Screen.Width, i * _gameScreen.UnitSize.Height));

            for (int i = 0; i < _tileInfos.GetLength(0); i++)
                for (int j = 0; j < _tileInfos.GetLength(1); j++)
                {
                    Rectangle rectangle = new Rectangle(new Point(_tileInfos[i, j].Position.X * _gameScreen.UnitSize.Width, _tileInfos[i, j].Position.Y * _gameScreen.UnitSize.Height), _gameScreen.UnitSize);
                    DrawAssets.Instance().FillRectangle(_gameScreen.ConstantGraphics, _tileInfos[i, j].Brush, rectangle, 5);
                }

            Draw();
        }

        public void Draw()
        {
            _gameScreen.TilesGraphics.Clear(Color.Transparent);
            _currentTile.Draw(_gameScreen.TilesGraphics);
        }

        public void Update(Keys key)
        {
            if (!(key == Keys.Left || key == Keys.Right || key == Keys.Down || key == Keys.Space))
                return;

            switch(key)
            {
                case Keys.Left: _currentTile.MoveLeft(); break;
                case Keys.Right: _currentTile.MoveRight(); break;
                case Keys.Down: _currentTile.MoveDown(); break;
                case Keys.Space: _currentTile.Rotate(); break;
                default: break;
            }
            Draw();
        }
    }
}
