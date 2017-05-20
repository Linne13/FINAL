using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cnt1 = 0;
        int cnt2 = 0;
        int cnt3 = 0;
        int cnt4 = 0;
        int cnt5 = 0;
        int cnt6 = 0;
        int cnt7 = 0;
        int cnt8 = 0;
        int cnt9 = 0;


        int p1 = 0;


        public static bool Prime(int a)
        {
            for (int i = 2; i < a * a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }

            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void display_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cnt1++;
            button1.Text = "" + cnt1;


          
            if(Prime(cnt1) == true)
            {
                p1++;
            }

            display.Text = "" + p1;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            cnt2++;
            button2.Text = "" + cnt2;
            if (Prime(cnt2) == true)
            {
                p1++;
            }

            display.Text = "" + p1;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            cnt3++;
            button3.Text = "" + cnt3;
            if (Prime(cnt3) == true)
            {
                p1++;
            }

            display.Text = "" + p1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnt4++;
            button4.Text = "" + cnt4;
            if (Prime(cnt4) == true)
            {
                p1++;
            }

            display.Text = "" + p1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnt5++;
            button5.Text = "" + cnt5;
            if (Prime(cnt5) == true)
            {
                p1++;
            }

            display.Text = "" + p1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cnt6++;
            button6.Text = "" + cnt6;
            if (Prime(cnt6) == true)
            {
                p1++;
            }

            display.Text = "" + p1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cnt7++;
            button7.Text = "" + cnt7;
            if (Prime(cnt7) == true)
            {
                p1++;
            }

            display.Text = "" + p1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cnt8++;
            button8.Text = "" + cnt8;
            if (Prime(cnt8) == true)
            {
                p1++;
            }

            display.Text = "" + p1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cnt9++;
            button9.Text = "" + cnt9;
            if (Prime(cnt9) == true)
            {
                p1++;
            }

            display.Text = "" + p1;
        }

       

    }
}
