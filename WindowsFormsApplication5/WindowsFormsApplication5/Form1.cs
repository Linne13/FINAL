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



        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;

        List<Krug> krg;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            krg = new List<Krug>();

            krg.Add(new Krug(new Point(200,200), 90, 2));


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
    }
}
