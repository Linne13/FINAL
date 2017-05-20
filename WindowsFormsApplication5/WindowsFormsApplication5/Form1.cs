using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {

        Graphics g;
        Point prevPoint;
        List<Krug> krg;
        public int cnt = 0;

        public Form1()
        {
            InitializeComponent();

            g = CreateGraphics();
        }

        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //krg = new List<Krug>();



            //krg.Add(new Krug(new Point(200,200), 0, 2));

            //timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            foreach(Krug k in krg)
            {
                k.Move();
                k.Draw(g);
               
            }

            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            
            cnt++;
            prevPoint = e.Location;

            int minX = Math.Min(prevPoint.X, e.Location.X);
            int minY = Math.Min(prevPoint.Y, e.Location.Y);
            

            krg = new List<Krug>();

            krg.Add(new Krug(new Point(minX, minY), 0, 2));
            

            timer1.Enabled = true;
        }
    }
}
