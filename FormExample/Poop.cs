using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FormExample
{
    class Poop : Movable
    {
        public Poop(int num)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, Boundary.endX);
            this.Size = new Size(40, 40);
            this.Location = new Point(randomNumber, -20);
            this.BackColor = Color.Brown;

            
        }
    }
}
