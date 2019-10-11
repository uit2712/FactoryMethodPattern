using System.Drawing;
using System.Windows.Forms;

namespace TileGame
{
    public partial class FrmTetrisGame : Form
    {
        public FrmTetrisGame()
        {
            InitializeComponent();

            pnlGameScreen.Width = _game.Screen.Width;
            pnlGameScreen.Height = _game.Screen.Height;
            pnlGameScreen.Controls.Add(_game.Screen);
        }

        private TetrisGame _game = new TetrisGame(new GameScreen(new Size(20, 20), 10, 20, Color.Orange));

        private void FrmTetrisGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FrmTetrisGame_KeyDown(object sender, KeyEventArgs e)
        {
            _game.Update(e.KeyCode);
        }
    }
}
