using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planee
{
    internal class Plane
    {
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }

        public Plane (int X, int Y, int W, int H)
        {
            this.x = X;
            this.y = Y;
            this.w = W;
            this.h = H;
        }

        public void DrawPlane(Graphics g, Pen p)
        {
            g.DrawRectangle(p, x, y, w, h);
        }
    }
}
