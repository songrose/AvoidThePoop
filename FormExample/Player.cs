using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FormExample
{
    class Player : Movable
    {
        Label scorelabel = new Label();
        int playerNum;
        private int score = 0;
        private bool active;
        public Player(int num)
        {
            playerNum = num;
            scorelabel.Location = new Point(13, 30 * playerNum);
            scorelabel.Text = "Player " + playerNum + " score: " + score;
                active = true;

        }
        public void setScore(int n)
        {
            scorelabel.Text = "Player " + playerNum + " score: " + score;

            score = n;
        }
        public Label getScoreLabel()
        {
            return scorelabel;
        }
        public void gameLose()
        {
            active = false;
        }
        public bool getActive()
        {
            return active;
        }
    }
}
