using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication2
{
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
}
