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

        Point prevPoint;
        Pen pen = new Pen(Color.Blue);

        List<Krug> krg;

        Point location;


        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            krg = new List<Krug>();
            krg.Add(new Krug(new Point(200, 200), 90, 2));

            
        }



        /*private void pictureBox1_Click(object sender, EventArgs e)
        {
            krg = new List<Krug>();
            krg.Add(new Krug(new Point(200, 200), 90, 2));
        }



        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
             prevPoint = e.Location;

             int minX = Math.Min(prevPoint.X, e.Location.X);
             int minY = Math.Min(prevPoint.Y, e.Location.Y);

             krg = new List<Krug>();
             krg.Add(new Krug(new Point(minX, minY), 90, 2));
          
          
             g.DrawEllipse(pen, minX, minY, 30, 30);
          

           
        } */



        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            foreach (Krug k in krg)
            {
                k.Move();
                k.Draw(g);
            }
        }
    }
}

