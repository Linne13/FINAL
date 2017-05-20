using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication5
{
    public class Krug
    {

        public int x;
        public int y;
        public Point location;

        Pen pen = new Pen(Color.Green);


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

        public void Draw(Graphics g)
        {
            g.DrawEllipse(pen, location.X, location.Y, 30, 30);
        }

    }
}
