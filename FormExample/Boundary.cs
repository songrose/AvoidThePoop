﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FormExample
{
    class Boundary
    {
        public static int startX = 100;
        public static int startY = 50;
        public static int endX = 700;
        public static int endY = 500;
        public static int padding = 200;
        public static int windowSizeX = endX - startX;
        public static int windowSizeY = endY - startY;


        public static int intervalWindow = 100;

        public static void drawBorder(PaintEventArgs e)
        {

            /**
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.Blue, 1);
            l.DrawLine(p,  new Point(startX, startY), new Point(startX, endY)); //west line
            l.DrawLine(p, startX, startY, endX, startY); //north line

            l.DrawLine(p, endX, endY, endX, startY); //east line
            l.DrawLine(p, new Point(startX, endY), new Point(endX, endY)); //south line

            l.Dispose();
    **/
        }
        
    }
}
