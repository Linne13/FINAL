using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        Graphics g;

        int w;
        int h;
        Point prevPoint;
        Pen pen = new Pen(Color.Blue);

       

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;

          
            int minX = Math.Min(prevPoint.X, e.Location.X);
            int minY = Math.Min(prevPoint.Y, e.Location.Y);

            g.DrawEllipse(pen, minX, minY, 30, 30);


        }


        public class Krug
        {
            public Point location;
            public int x;
            public int y;

            public Brush b = new SolidBrush(Color.Blue);

            public Krug(Point p, int xx, int yy)
            {
                location = new Point();
                location = p;
                x = xx;
                y = yy;
            }

            public void Move()
            {
                location.X += x;
                location.Y += y;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }
    }
}
