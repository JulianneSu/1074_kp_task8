using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planee
{
    public partial class Form1 : Form
    {

        Plane p1, p2;
        Graphics g;
        Pen pn1,pn2,pnr;
        int x = 0, y = 0, w = 100, h = 50;
        
        Random r = new Random();

        bool right1 = true;
        bool down1 = true;
        bool right2 = true;
        bool down2 = true;
        bool col = false;
        bool firstcol = true;


        public Form1()
        {
            InitializeComponent();


            p1 = new Plane(x, y, w, h);
            p2 = new Plane( 470 - w,100, w, h);
            g = CreateGraphics();
            timer1.Enabled = true;

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
                        

            if (p1.x + w > 470 || p1.x < 0 )
            {
                right1 = !right1;
                col = true;
            }
            if (p1.y >= 300 || p1.y < 0  )
            {
                down1 = !down1;
                col = true;
            }


            if (firstcol == true)
            { pnr = new Pen(Color.FromArgb(0, 0, 0),4);}

            if (col == true)
            {
                pnr = new Pen(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)),4);
                col = false;
                firstcol = false;
            }
            
            
            //if (p2.x + w > 470 || p2.x < 0 || p1.x <= p2.x + w || p1.x >= p2.x - w)
            //{
            //    right2 = !right2;
            //}
            //if (p2.y >= 300 || p2.y < 0 || p1.y <= p2.y + h || p1.y >= p2.y - h)
            //{
            //    down2 = !down2;
            //}

 
            
            p1.x += right1 ? 30 : -30;
            p1.y += down1 ? 30 : -30;
            
            //p2.x += right2 ? 50 : -50;
            //p2.y += down2 ? 50 : -50;

            p1.DrawPlane(g, pnr);
            //p2.DrawPlane(g, pn2);
        }

    }
}
