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

        public void DrawRec(Graphics g, Pen p)
        {
            g.DrawRectangle(p, x, y, w, h);
        }

        public void DrawPlane(Graphics g, Pen p)
        {

            List<Point> Points = new List<Point>();
          
            Points.Add(new Point(x + 0, y + 10));
            Points.Add(new Point(x +10, y +18));
            Points.Add(new Point(x +40, y +15));
            Points.Add(new Point(x +20, y +0));
            Points.Add(new Point(x +40, y +0));
            Points.Add(new Point(x +70, y +15));
            Points.Add(new Point(x +90, y +15));
            Points.Add(new Point(x +100, y +20));
            Points.Add(new Point(x +100, y +30));
            Points.Add(new Point(x +90, y +35)); 
            Points.Add(new Point(x +70, y +35));
            Points.Add(new Point(x +40, y +50));
            Points.Add(new Point(x +20, y +50));
            Points.Add(new Point(x +40, y +35));
            Points.Add(new Point(x +10, y +32));
            Points.Add(new Point(x +0, y +40));
           

            g.DrawPolygon(p,Points.ToArray());
        }
    }
}
