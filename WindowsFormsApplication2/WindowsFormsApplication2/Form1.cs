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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;

            
            int minX = Math.Min(prevPoint.X, e.Location.X);
            int minY = Math.Min(prevPoint.Y, e.Location.Y);

            g.DrawEllipse(pen, minX, minY, 30, 30);
            

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;

          
            int minX = Math.Min(prevPoint.X, e.Location.X);
            int minY = Math.Min(prevPoint.Y, e.Location.Y);

            g.DrawEllipse(pen, minX, minY, 30, 30);
        }
    }
}
