using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using static System.Drawing.Color;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;


namespace FormExample
{

    class Game
    {
        public Player p1;
        public Player p2;
        protected static int counter = 0;
        private Form form;
        public Timer gameTime;
        ArrayList poopList;
        public Movable platform;
        Label scorelabel = new Label();
        public Game(Form form)
        {
            poopList = new ArrayList();

            gameTime = new Timer();
            gameTime.Enabled = true;
            gameTime.Interval = 5;
            gameTime.Tick += new EventHandler(OnGameTimeTick);

            this.form = form;
            Movable.mainForm = form;
            p1 = new Player(1);
            p1.Size = new Size(20, 20);
            p1.Location = new Point(Boundary.endX/2, Boundary.endY);
            p1.BackColor = Color.FromArgb(100, 0, 255, 255);



            this.form = form;
            Movable.mainForm = form;
            p2 = new Player(2);
            p2.Size = new Size(20, 20);
            p2.Location = new Point(Boundary.endX/3, Boundary.endY);
            p2.BackColor = Color.FromArgb(100, 255, 255, 0);


            //draws the bottom line

            platform = new Movable();
            platform.Size = new Size(Boundary.endX + 20, 5);
            platform.Location = new Point(0, Boundary.endY + 20) ;
            platform.BackColor = Color.Black;
            platform.bringToFront();

            // configuring label
           
            form.Controls.Add(p1.getScoreLabel());
            form.Controls.Add(p2.getScoreLabel());

        }



        private void OnGameTimeTick(object sender, EventArgs e)
        {


            counter++;
            if(counter == 100)
            {
                counter = 0;
            }

            if((counter % 5) == 0)
            {
                poopList.Add(new Poop(0));

            }


            int checkBottom = Boundary.endY - 70;
            for (int i = poopList.Count - 1; i >= 0; i--)
            {
                Poop p = (Poop) poopList[i];
                //checking if Y location is 
                if (p.Location.Y > checkBottom )
                {
                    if (p.Bounds.IntersectsWith(platform.Bounds)) {
                        poopList.RemoveAt(i);
                        p.remove();
                        p = null;
                        setScore(p1, p2, Score.score++);
                     
                    }
                    if (p1.getActive()&& p != null && p.Bounds.IntersectsWith(p1.Bounds))
                    {
                        p1.setScore(Score.score);      
                        poopList.RemoveAt(i);
                        p.remove();
                        p = null;
                        p1.BackColor = Color.Red;
                        p1.gameLose();
                        
                    }
                    if (p2.getActive() && p != null && p.Bounds.IntersectsWith(p2.Bounds))
                    {
                        p2.setScore(Score.score);
                        poopList.RemoveAt(i);
                        p.remove();
                        p = null;
                        p2.BackColor = Color.Red;

                        p2.gameLose();
                    }


                }
                if (p != null) p.Location = new Point(p.Location.X, p.Location.Y + 10);

                if(!p1.getActive() && !p2.getActive())
                {
                    gameTime.Interval=100000;
                }

            }
            counter++;
            //int x = p2.Location.X;
            //int playerSpeed = 20;
            //p2.Location = new Point(x - playerSpeed, p2.Location.Y);

        }
        public void setScore(Player p1, Player p2, int score)
        {
            if (p1.getActive())
            {
                p1.setScore(score);
            }
            if (p2.getActive())
            {
                p2.setScore(score);
            }

        }

    }
}
