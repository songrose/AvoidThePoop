using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExample
{
    public partial class GameArea : Form
    {
         int GameAreaWidth = Boundary.windowSizeX;
         int GameAreaHeight = Boundary.windowSizeY;
        Game game;

        public GameArea()
        {
            this.Height = GameAreaHeight;
            this.Width = GameAreaWidth;
            game = new Game(this);


            InitializeComponent();

        }

        private void GameArea_Paint(object sender, PaintEventArgs e)
        {
            Boundary.drawBorder(e);
        }


        private void GameArea_KeyDown(object sender, KeyEventArgs e)
        {
            int x = game.p2.Location.X;
            int playerSpeed = 20;
            if (e.KeyCode == Keys.Left && x - 25 >= -10)
            {
                //   game.p2.Location = new Point(this.Width - (game.p2.Width * 2), y - playerSpeed);
                game.p2.Location = new Point(x - playerSpeed, game.p2.Location.Y);
            }
            else if (e.KeyCode == Keys.Right && x + playerSpeed <= (Boundary.endX))
            {

                game.p2.Location = new Point(x + playerSpeed, game.p2.Location.Y);
            }
        }
    }
}
