using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int cnt = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;
            label12.ForeColor = Color.Black;

            cnt++;

            if(cnt == 1)
            { label1.ForeColor = Color.Red; }

            if(cnt == 2)
            { label2.ForeColor = Color.Red;
            }

            if (cnt == 3)

            { label3.ForeColor = Color.Red;
            }

            if (cnt == 4)

            { label4.ForeColor = Color.Red;
            
            }

            if (cnt == 5)

            { label5.ForeColor = Color.Red;
            }

            if (cnt == 6)

            { label6.ForeColor = Color.Red;
            
            }

            if (cnt == 7)

            { label7.ForeColor = Color.Red;
            }

            if (cnt == 8)

            { label8.ForeColor = Color.Red;
           
            }

            if (cnt == 9)

            { label9.ForeColor = Color.Red;
           
            }

            if (cnt == 10)

            { label10.ForeColor = Color.Red;
           
            }

            if (cnt == 11)

            { label11.ForeColor = Color.Red;
           
            }

            if (cnt == 12)

            { label12.ForeColor = Color.Red;

            cnt = 0;
            }

           

            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
