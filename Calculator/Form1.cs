using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int a = 0, b, c, state = 0;
        public double d;
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Int32.Parse(textBox1.Text);
            textBox1.Text = "";
            state = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = Int32.Parse(textBox1.Text);
            textBox1.Text = "";
            state = 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = Int32.Parse(textBox1.Text);
            textBox1.Text = "";
            state = 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Int32.Parse(textBox1.Text);
            textBox1.Text = "";
            state = 4;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (a != 0 && textBox1.Text != "" && state != 0)
            {
                switch (state)
                {
                    case 1: c = a + Int32.Parse(textBox1.Text);
                        break;
                    case 2: c = a - Int32.Parse(textBox1.Text);
                        break;
                    case 3: c = a * Int32.Parse(textBox1.Text);
                        break;
                    case 4: d = (double)a / Double.Parse(textBox1.Text);
                        break;
                }
                if (state == 4)
                    textBox1.Text = d.ToString();
                else
                    textBox1.Text = c.ToString();
            }
            else
                MessageBox.Show("您的输入不合法！请重新输入！");
        }


    }
}
