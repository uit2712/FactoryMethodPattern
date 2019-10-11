using System;
using System.Collections.Generic;
using System.Drawing;
using TileGame.Interfaces;

namespace TileGame.Products
{
    abstract class Tile : ITile
    {
        protected List<Point> _currentState = new List<Point>();
        protected List<List<Point>> _states = new List<List<Point>>();
        protected readonly Size _ELEMENT_SIZE = new Size(20, 20); // pixels
        protected Point _position = new Point(0, 0);
        protected Brush _brush = Brushes.Black;
        protected Random _random = new Random();
        protected int _currentStateIndex = 0;
        protected int _radius = 5;
        public Point Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public Size Size
        {
            get { return _ELEMENT_SIZE; }
        }

        public List<Point> CurrentState
        {
            get { return _currentState; }
        }

        public Brush Brush
        {
            get { return _brush; }
        }

        public List<TileInfo> TileInfos
        {
            get
            {
                List<TileInfo> tileInfos = new List<TileInfo>();
                foreach (Point point in _currentState)
                    tileInfos.Add(new TileInfo(_brush, new Point(_position.X + point.X, _position.Y + point.Y)));

                return tileInfos;
            }
        }

        public abstract void Draw(Graphics graphics);

        public void Rotate()
        {
            _currentStateIndex = (_currentStateIndex + 1) % _states.Count;
            if (_currentStateIndex < _states.Count)
                _currentState = _states[_currentStateIndex];
        }

        public void RandomState()
        {
            if (_states.Count == 0)
                return;

            int index = _random.Next() % _states.Count;
            _currentState = _states[index];
            _currentStateIndex = index;
        }

        public void MoveLeft()
        {
            _position = new Point(_position.X - _ELEMENT_SIZE.Width, _position.Y);
        }

        public void MoveRight()
        {
            _position = new Point(_position.X + _ELEMENT_SIZE.Width, _position.Y);
        }

        public void MoveDown()
        {
            _position = new Point(_position.X, _position.Y + _ELEMENT_SIZE.Height);
        }
    }
}
