using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302220087
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool text;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!text)
            {
                label1.Text = "" + 1;
                text = true;

            } else
            {
                label1.Text = label1.Text + "" + 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!text)
            {
                label1.Text = "" + 4;
                text = true;
            }
            else
            {
                label1.Text = label1.Text + "" + 4;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!text)
            {
                label1.Text = "" + 6;
                text = true;
            }
            else
            {
                label1.Text = label1.Text + "" + 6;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!text)
            {
                label1.Text = "" + 2;
                text = true;
            }
            else
            {
                label1.Text = label1.Text + "" + 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!text)
            {
                label1.Text = "" + 3;
                text = true;
            }
            else
            {
                label1.Text = label1.Text + "" + 3;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!text)
            {
                label1.Text = "" + 5;
                text = true;
            }
            else
            {
                label1.Text = label1.Text + "" + 5;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!text)
            {
                label1.Text = "" + 7;
                text = true;
            }
            else
            {
                label1.Text = label1.Text + "" + 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!text)
            {
                label1.Text = "" + 8;
                text = true;
            }
            else
            {
                label1.Text = label1.Text + "" + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!text)
            {
                label1.Text = "" + 9;
                text = true;
            }
            else
            {
                label1.Text = label1.Text + "" + 9;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!text)
            {
                label1.Text = "" + 0;
                text = true;
            }
            else
            {
                label1.Text = label1.Text + "" + 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!text)
            {
                label1.Text = "+";
                text = true;

            }
            else
            {
                label1.Text = label1.Text + "+";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!text)
            {
                label1.Text = "=";
                text = true;

            }
            else
            {
                label1.Text = label1.Text + "=" + "1389";
            }
        }

        
    }
}
